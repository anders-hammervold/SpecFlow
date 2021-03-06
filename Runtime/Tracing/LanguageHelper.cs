﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace TechTalk.SpecFlow.Tracing
{
    internal static class LanguageHelper
    {
        class KeywordTranslation : Dictionary<StepDefinitionKeyword, string>
        {
            public CultureInfo DefaultSpecificCulture { get; set; }
        }

        private static readonly Dictionary<CultureInfo, KeywordTranslation> translationCache = new Dictionary<CultureInfo, KeywordTranslation>();

        public static string GetKeyword(CultureInfo language, BindingType bindingType)
        {
            return GetKeyword(language, bindingType.ToStepDefinitionKeyword());
        }

        public static string GetKeyword(CultureInfo language, StepDefinitionKeyword keyword)
        {
            KeywordTranslation translation = GetTranslation(language);
            return translation[keyword];
        }

        private static KeywordTranslation GetTranslation(CultureInfo language)
        {
            KeywordTranslation translation;
            if (!translationCache.TryGetValue(language, out translation))
            {
                translation = LoadTranslation(language);
            }
            return translation;
        }

        static public CultureInfo GetSpecificCultureInfo(CultureInfo language)
        {
            //HACK: we need to have a better solution
            if (!language.IsNeutralCulture)
                return language;

            KeywordTranslation translation = GetTranslation(language);
            return translation.DefaultSpecificCulture;
        }


        private static KeywordTranslation LoadTranslation(CultureInfo language)
        {
            var docStream = typeof(LanguageHelper).Assembly.GetManifestResourceStream("TechTalk.SpecFlow.Languages.xml");
            if (docStream == null)
                throw new InvalidOperationException("Language resource not found.");

            XDocument languageDoc;
            using (var reader = new StreamReader(docStream))
            {
                languageDoc = XDocument.Load(reader);
            }

            XElement langElm = GetBestFitLanguageElement(languageDoc, language);

            KeywordTranslation result = new KeywordTranslation();

            result.DefaultSpecificCulture = language.IsNeutralCulture ?
                new CultureInfo(langElm.Attribute(XName.Get("defaultSpecificCulture", "")).Value) :
                language;

            foreach (StepDefinitionKeyword keyword in Enum.GetValues(typeof(StepDefinitionKeyword)))
            {
                XElement keywordElm = langElm.Element(keyword.ToString());
                Debug.Assert(keywordElm != null);
                result[keyword] = keywordElm.Value;
            }

            return result;
        }

        private static XElement GetBestFitLanguageElement(XDocument languageDoc, CultureInfo language)
        {
            var langElm = GetLanguageElement(languageDoc, language);
            if (langElm == null)
            {
                CultureInfo calculatedLanguage = language;

                while (calculatedLanguage.Parent != calculatedLanguage)
                {
                    calculatedLanguage = calculatedLanguage.Parent;

                    langElm = GetLanguageElement(languageDoc, calculatedLanguage);
                    if (langElm != null)
                        break;
                }

                if (langElm == null)
                    throw new SpecFlowException(string.Format("The specified feature file language ('{0}') is not supported.", language));
            }
            return langElm;
        }

        private static XElement GetLanguageElement(XDocument languageDoc, CultureInfo language)
        {
            Debug.Assert(languageDoc.Root != null);
            return languageDoc.Root.Elements("Language").SingleOrDefault(l => l.Attribute("code").Value == language.Name);
        }
    }
}
