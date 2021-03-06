﻿using System;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using TechTalk.SpecFlow.Tracing;
using TechTalk.SpecFlow.UnitTestProvider;

namespace TechTalk.SpecFlow.Configuration
{
    public partial class ConfigurationSectionHandler
    {
        
    }

    internal class RuntimeConfiguration
    {
        static public RuntimeConfiguration Current
        {
            get { return ObjectContainer.Configuration; }
        }

        //language settings
        public CultureInfo ToolLanguage { get; set; }

        //unit test framework settings
        public Type RuntimeUnitTestProviderType { get; set; }

        //runtime settings
        public bool DetectAmbiguousMatches { get; set; }
        public bool StopAtFirstError { get; set; }
        public MissingOrPendingStepsOutcome MissingOrPendingStepsOutcome { get; set; }
        
        //tracing settings
        public Type TraceListenerType { get; set; }
        public bool TraceSuccessfulSteps { get; set; }
        public bool TraceTimings { get; set; }
        public TimeSpan MinTracedDuration { get; set; }

        public RuntimeConfiguration()
        {
            ToolLanguage = string.IsNullOrEmpty(ConfigDefaults.ToolLanguage) ? 
                CultureInfo.GetCultureInfo(ConfigDefaults.FeatureLanguage) : 
                CultureInfo.GetCultureInfo(ConfigDefaults.ToolLanguage);

            SetUnitTestDefaultsByName(ConfigDefaults.UnitTestProviderName);

            DetectAmbiguousMatches = ConfigDefaults.DetectAmbiguousMatches;
            StopAtFirstError = ConfigDefaults.StopAtFirstError;
            MissingOrPendingStepsOutcome = ConfigDefaults.MissingOrPendingStepsOutcome;

            TraceListenerType = typeof(DefaultListener);
            TraceSuccessfulSteps = ConfigDefaults.TraceSuccessfulSteps;
            TraceTimings = ConfigDefaults.TraceTimings;
            MinTracedDuration = TimeSpan.Parse(ConfigDefaults.MinTracedDuration);
        }

        public static RuntimeConfiguration LoadFromConfigFile()
        {
            var section = (ConfigurationSectionHandler)ConfigurationManager.GetSection("specFlow");
            if (section == null)
                return new RuntimeConfiguration();

            return LoadFromConfigFile(section);
        }

        public static RuntimeConfiguration LoadFromConfigFile(ConfigurationSectionHandler configSection)
        {
            if (configSection == null) throw new ArgumentNullException("configSection");

            var config = new RuntimeConfiguration();
            if (configSection.Language != null)
            {
                config.ToolLanguage = string.IsNullOrEmpty(configSection.Language.Tool) ?
                    CultureInfo.GetCultureInfo(configSection.Language.Feature) : 
                    CultureInfo.GetCultureInfo(configSection.Language.Tool);
            }

            if (configSection.UnitTestProvider != null)
            {
                config.SetUnitTestDefaultsByName(configSection.UnitTestProvider.Name);

                if (!string.IsNullOrEmpty(configSection.UnitTestProvider.RuntimeProvider))
                    config.RuntimeUnitTestProviderType = GetTypeConfig(configSection.UnitTestProvider.RuntimeProvider);

                //TODO: config.CheckUnitTestConfig();
            }

            if (configSection.Runtime != null)
            {
                config.DetectAmbiguousMatches = configSection.Runtime.DetectAmbiguousMatches;
                config.StopAtFirstError = configSection.Runtime.StopAtFirstError;
                config.MissingOrPendingStepsOutcome = configSection.Runtime.MissingOrPendingStepsOutcome;
            }

            if (configSection.Trace != null)
            {
                if (!string.IsNullOrEmpty(configSection.Trace.Listener))
                    config.TraceListenerType = GetTypeConfig(configSection.Trace.Listener);

                config.TraceSuccessfulSteps = configSection.Trace.TraceSuccessfulSteps;
                config.TraceTimings = configSection.Trace.TraceTimings;
                config.MinTracedDuration = configSection.Trace.MinTracedDuration;
            }

            return config;
        }

        private static Type GetTypeConfig(string typeName)
        {
            try
            {
                return Type.GetType(typeName, true);
            }
            catch (Exception ex)
            {
                throw new ConfigurationErrorsException(
                    string.Format("Invalid type reference '{0}': {1}",
                        typeName, ex.Message), ex);
            }
        }

        private void SetUnitTestDefaultsByName(string name)
        {
            switch (name.ToLowerInvariant())
            {
                case "nunit":
                    RuntimeUnitTestProviderType = typeof(NUnitRuntimeProvider);
                    break;
                case "mstest":
                    RuntimeUnitTestProviderType = typeof(MsTestRuntimeProvider);
                    break;
                default:
                    RuntimeUnitTestProviderType = null;
                    break;
            }

        }
    }
}