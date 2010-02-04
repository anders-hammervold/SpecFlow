// $ANTLR 3.1.2 SpecFlowLangLexer_de.g 2010-02-04 21:53:39

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162
namespace  TechTalk.SpecFlow.Parser.Grammar 
{

using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;

using IDictionary	= System.Collections.IDictionary;
using Hashtable 	= System.Collections.Hashtable;

public partial class SpecFlowLangLexer_de : SpecFlowLangLexer {
    public const int NEWLINECHR = 6;
    public const int T_BACKGROUND = 9;
    public const int T_THEN = 15;
    public const int T_SCENARIO_OUTLINE = 11;
    public const int MLTEXT = 18;
    public const int WSCHAR = 4;
    public const int NONNLCHR = 7;
    public const int EOF = -1;
    public const int T_AND = 16;
    public const int T_GIVEN = 13;
    public const int AT = 20;
    public const int WORDCHAR = 24;
    public const int T_BUT = 17;
    public const int WS = 22;
    public const int NEWLINE = 23;
    public const int T_WHEN = 14;
    public const int T_FEATURE = 8;
    public const int T_EXAMPLES = 12;
    public const int NONWCHR = 5;
    public const int T_SCENARIO = 10;
    public const int COMMENT = 21;
    public const int CELLSEP = 19;

    // delegates
    // delegators

    public SpecFlowLangLexer_de() 
    {
		InitializeCyclicDFAs();
    }
    public SpecFlowLangLexer_de(ICharStream input)
		: this(input, null) {
    }
    public SpecFlowLangLexer_de(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "SpecFlowLangLexer_de.g";} 
    }

    override public IToken NextToken() 
    {
        while (true) 
    	{
            if ( input.LA(1) == (int)CharStreamConstants.EOF ) 
    		{
                return Token.EOF_TOKEN;
            }

    	    state.token = null;
    		state.channel = Token.DEFAULT_CHANNEL;
            state.tokenStartCharIndex = input.Index();
            state.tokenStartCharPositionInLine = input.CharPositionInLine;
            state.tokenStartLine = input.Line;
    	    state.text = null;
            try 
    		{
                int m = input.Mark();
                state.backtracking = 1; 
                state.failed = false;
                mTokens();
                state.backtracking = 0;
                if ( state.failed ) 
    			{
    	            input.Rewind(m);
                    input.Consume(); 
                }
                else 
    			{
    				Emit();
                    return state.token;
                }
            }
            catch (RecognitionException re) 
    		{
                // shouldn't happen in backtracking mode, but...
                ReportError(re);
                Recover(re);
            }
        }
    }

    override public void Memoize(IIntStream input, int ruleIndex, int ruleStartIndex)
    {
    	if ( state.backtracking > 1 ) 
    		base.Memoize(input, ruleIndex, ruleStartIndex);
    }

    override public bool AlreadyParsedRule(IIntStream input, int ruleIndex)
    {
    	if ( state.backtracking>1 ) 
    		return base.AlreadyParsedRule(input, ruleIndex);
    	return false;
    }// $ANTLR start "WSCHAR"
    public void mWSCHAR() // throws RecognitionException [2]
    {
    		try
    		{
            // SpecFlowLangLexer_de.g:12:25: ( ( ' ' | '\\t' ) )
            // SpecFlowLangLexer_de.g:12:27: ( ' ' | '\\t' )
            {
            	if ( input.LA(1) == '\t' || input.LA(1) == ' ' ) 
            	{
            	    input.Consume();
            	state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "WSCHAR"

    // $ANTLR start "NONWCHR"
    public void mNONWCHR() // throws RecognitionException [2]
    {
    		try
    		{
            // SpecFlowLangLexer_de.g:13:25: ( ( ' ' | '\\t' | '\\r' | '\\n' | '#' | '@' ) )
            // SpecFlowLangLexer_de.g:13:27: ( ' ' | '\\t' | '\\r' | '\\n' | '#' | '@' )
            {
            	if ( (input.LA(1) >= '\t' && input.LA(1) <= '\n') || input.LA(1) == '\r' || input.LA(1) == ' ' || input.LA(1) == '#' || input.LA(1) == '@' ) 
            	{
            	    input.Consume();
            	state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "NONWCHR"

    // $ANTLR start "NEWLINECHR"
    public void mNEWLINECHR() // throws RecognitionException [2]
    {
    		try
    		{
            // SpecFlowLangLexer_de.g:14:25: ( ( '\\r' | '\\n' ) )
            // SpecFlowLangLexer_de.g:14:27: ( '\\r' | '\\n' )
            {
            	if ( input.LA(1) == '\n' || input.LA(1) == '\r' ) 
            	{
            	    input.Consume();
            	state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "NEWLINECHR"

    // $ANTLR start "NONNLCHR"
    public void mNONNLCHR() // throws RecognitionException [2]
    {
    		try
    		{
            // SpecFlowLangLexer_de.g:15:25: ( ( '\\u0000' .. '\\t' ) | ( '\\u000B' .. '\\f' ) | ( '\\u000E' .. '\\uFFFF' ) )
            int alt1 = 3;
            int LA1_0 = input.LA(1);

            if ( ((LA1_0 >= '\u0000' && LA1_0 <= '\t')) )
            {
                alt1 = 1;
            }
            else if ( ((LA1_0 >= '\u000B' && LA1_0 <= '\f')) )
            {
                alt1 = 2;
            }
            else if ( ((LA1_0 >= '\u000E' && LA1_0 <= '\uFFFF')) )
            {
                alt1 = 3;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return ;}
                NoViableAltException nvae_d1s0 =
                    new NoViableAltException("", 1, 0, input);

                throw nvae_d1s0;
            }
            switch (alt1) 
            {
                case 1 :
                    // SpecFlowLangLexer_de.g:15:27: ( '\\u0000' .. '\\t' )
                    {
                    	// SpecFlowLangLexer_de.g:15:27: ( '\\u0000' .. '\\t' )
                    	// SpecFlowLangLexer_de.g:15:28: '\\u0000' .. '\\t'
                    	{
                    		MatchRange('\u0000','\t'); if (state.failed) return ;

                    	}


                    }
                    break;
                case 2 :
                    // SpecFlowLangLexer_de.g:15:44: ( '\\u000B' .. '\\f' )
                    {
                    	// SpecFlowLangLexer_de.g:15:44: ( '\\u000B' .. '\\f' )
                    	// SpecFlowLangLexer_de.g:15:45: '\\u000B' .. '\\f'
                    	{
                    		MatchRange('\u000B','\f'); if (state.failed) return ;

                    	}


                    }
                    break;
                case 3 :
                    // SpecFlowLangLexer_de.g:15:61: ( '\\u000E' .. '\\uFFFF' )
                    {
                    	// SpecFlowLangLexer_de.g:15:61: ( '\\u000E' .. '\\uFFFF' )
                    	// SpecFlowLangLexer_de.g:15:62: '\\u000E' .. '\\uFFFF'
                    	{
                    		MatchRange('\u000E','\uFFFF'); if (state.failed) return ;

                    	}


                    }
                    break;

            }
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NONNLCHR"

    // $ANTLR start "T_FEATURE"
    public void mT_FEATURE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T_FEATURE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // SpecFlowLangLexer_de.g:18:15: ( 'Funktionalit\\u00e4t:' )
            // SpecFlowLangLexer_de.g:18:17: 'Funktionalit\\u00e4t:'
            {
            	Match("Funktionalit\u00e4t:"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T_FEATURE"

    // $ANTLR start "T_BACKGROUND"
    public void mT_BACKGROUND() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T_BACKGROUND;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // SpecFlowLangLexer_de.g:19:18: ( 'Grundlage:' )
            // SpecFlowLangLexer_de.g:19:20: 'Grundlage:'
            {
            	Match("Grundlage:"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T_BACKGROUND"

    // $ANTLR start "T_SCENARIO"
    public void mT_SCENARIO() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T_SCENARIO;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // SpecFlowLangLexer_de.g:20:16: ( 'Szenario:' )
            // SpecFlowLangLexer_de.g:20:18: 'Szenario:'
            {
            	Match("Szenario:"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T_SCENARIO"

    // $ANTLR start "T_SCENARIO_OUTLINE"
    public void mT_SCENARIO_OUTLINE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T_SCENARIO_OUTLINE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // SpecFlowLangLexer_de.g:21:24: ( 'Szenariogrundriss:' )
            // SpecFlowLangLexer_de.g:21:26: 'Szenariogrundriss:'
            {
            	Match("Szenariogrundriss:"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T_SCENARIO_OUTLINE"

    // $ANTLR start "T_EXAMPLES"
    public void mT_EXAMPLES() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T_EXAMPLES;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // SpecFlowLangLexer_de.g:22:16: ( 'Beispiele:' )
            // SpecFlowLangLexer_de.g:22:18: 'Beispiele:'
            {
            	Match("Beispiele:"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T_EXAMPLES"

    // $ANTLR start "T_GIVEN"
    public void mT_GIVEN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T_GIVEN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // SpecFlowLangLexer_de.g:23:13: ( 'Gegeben sei' )
            // SpecFlowLangLexer_de.g:23:15: 'Gegeben sei'
            {
            	Match("Gegeben sei"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T_GIVEN"

    // $ANTLR start "T_WHEN"
    public void mT_WHEN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T_WHEN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // SpecFlowLangLexer_de.g:24:12: ( 'Wenn' )
            // SpecFlowLangLexer_de.g:24:14: 'Wenn'
            {
            	Match("Wenn"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T_WHEN"

    // $ANTLR start "T_THEN"
    public void mT_THEN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T_THEN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // SpecFlowLangLexer_de.g:25:12: ( 'Dann' )
            // SpecFlowLangLexer_de.g:25:14: 'Dann'
            {
            	Match("Dann"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T_THEN"

    // $ANTLR start "T_AND"
    public void mT_AND() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T_AND;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // SpecFlowLangLexer_de.g:26:11: ( 'Und' )
            // SpecFlowLangLexer_de.g:26:13: 'Und'
            {
            	Match("Und"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T_AND"

    // $ANTLR start "T_BUT"
    public void mT_BUT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T_BUT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // SpecFlowLangLexer_de.g:27:11: ( 'Aber' )
            // SpecFlowLangLexer_de.g:27:13: 'Aber'
            {
            	Match("Aber"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T_BUT"

    // $ANTLR start "MLTEXT"
    public void mMLTEXT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MLTEXT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // SpecFlowLangLexer_de.g:29:13: ( '\"\"\"' )
            // SpecFlowLangLexer_de.g:29:15: '\"\"\"'
            {
            	Match("\"\"\""); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MLTEXT"

    // $ANTLR start "CELLSEP"
    public void mCELLSEP() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CELLSEP;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // SpecFlowLangLexer_de.g:30:14: ( '|' )
            // SpecFlowLangLexer_de.g:30:16: '|'
            {
            	Match('|'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CELLSEP"

    // $ANTLR start "AT"
    public void mAT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = AT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // SpecFlowLangLexer_de.g:31:17: ( '@' )
            // SpecFlowLangLexer_de.g:31:19: '@'
            {
            	Match('@'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "AT"

    // $ANTLR start "COMMENT"
    public void mCOMMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = COMMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // SpecFlowLangLexer_de.g:32:17: ( ( WSCHAR )* '#' ( NONNLCHR )* )
            // SpecFlowLangLexer_de.g:32:19: ( WSCHAR )* '#' ( NONNLCHR )*
            {
            	// SpecFlowLangLexer_de.g:32:19: ( WSCHAR )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == '\t' || LA2_0 == ' ') )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // SpecFlowLangLexer_de.g:32:19: WSCHAR
            			    {
            			    	mWSCHAR(); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop2;
            	    }
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements

            	Match('#'); if (state.failed) return ;
            	// SpecFlowLangLexer_de.g:32:31: ( NONNLCHR )*
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( ((LA3_0 >= '\u0000' && LA3_0 <= '\t') || (LA3_0 >= '\u000B' && LA3_0 <= '\f') || (LA3_0 >= '\u000E' && LA3_0 <= '\uFFFF')) )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // SpecFlowLangLexer_de.g:32:31: NONNLCHR
            			    {
            			    	mNONNLCHR(); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop3;
            	    }
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements

            	if ( (state.backtracking == 1) )
            	{
            	   _channel = Token.HIDDEN_CHANNEL; 
            	}

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "COMMENT"

    // $ANTLR start "WS"
    public void mWS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // SpecFlowLangLexer_de.g:33:17: ( ( WSCHAR )+ )
            // SpecFlowLangLexer_de.g:33:19: ( WSCHAR )+
            {
            	// SpecFlowLangLexer_de.g:33:19: ( WSCHAR )+
            	int cnt4 = 0;
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( (LA4_0 == '\t' || LA4_0 == ' ') )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // SpecFlowLangLexer_de.g:33:19: WSCHAR
            			    {
            			    	mWSCHAR(); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    if ( cnt4 >= 1 ) goto loop4;
            			    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            		            EarlyExitException eee4 =
            		                new EarlyExitException(4, input);
            		            throw eee4;
            	    }
            	    cnt4++;
            	} while (true);

            	loop4:
            		;	// Stops C# compiler whinging that label 'loop4' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WS"

    // $ANTLR start "NEWLINE"
    public void mNEWLINE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NEWLINE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // SpecFlowLangLexer_de.g:34:17: ( '\\r\\n' | '\\n' )
            int alt5 = 2;
            int LA5_0 = input.LA(1);

            if ( (LA5_0 == '\r') )
            {
                alt5 = 1;
            }
            else if ( (LA5_0 == '\n') )
            {
                alt5 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return ;}
                NoViableAltException nvae_d5s0 =
                    new NoViableAltException("", 5, 0, input);

                throw nvae_d5s0;
            }
            switch (alt5) 
            {
                case 1 :
                    // SpecFlowLangLexer_de.g:34:19: '\\r\\n'
                    {
                    	Match("\r\n"); if (state.failed) return ;


                    }
                    break;
                case 2 :
                    // SpecFlowLangLexer_de.g:34:28: '\\n'
                    {
                    	Match('\n'); if (state.failed) return ;

                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NEWLINE"

    // $ANTLR start "WORDCHAR"
    public void mWORDCHAR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WORDCHAR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // SpecFlowLangLexer_de.g:35:17: ( ( ( '\\u0000' .. '\\b' ) | ( '\\u000B' .. '\\f' ) | ( '\\u000E' .. '\\u001F' ) | ( '!' .. '\"' ) | ( '$' .. '?' ) | ( 'A' .. '\\uFFFF' ) )+ )
            // SpecFlowLangLexer_de.g:35:19: ( ( '\\u0000' .. '\\b' ) | ( '\\u000B' .. '\\f' ) | ( '\\u000E' .. '\\u001F' ) | ( '!' .. '\"' ) | ( '$' .. '?' ) | ( 'A' .. '\\uFFFF' ) )+
            {
            	// SpecFlowLangLexer_de.g:35:19: ( ( '\\u0000' .. '\\b' ) | ( '\\u000B' .. '\\f' ) | ( '\\u000E' .. '\\u001F' ) | ( '!' .. '\"' ) | ( '$' .. '?' ) | ( 'A' .. '\\uFFFF' ) )+
            	int cnt6 = 0;
            	do 
            	{
            	    int alt6 = 7;
            	    int LA6_0 = input.LA(1);

            	    if ( ((LA6_0 >= '\u0000' && LA6_0 <= '\b')) )
            	    {
            	        alt6 = 1;
            	    }
            	    else if ( ((LA6_0 >= '\u000B' && LA6_0 <= '\f')) )
            	    {
            	        alt6 = 2;
            	    }
            	    else if ( ((LA6_0 >= '\u000E' && LA6_0 <= '\u001F')) )
            	    {
            	        alt6 = 3;
            	    }
            	    else if ( ((LA6_0 >= '!' && LA6_0 <= '\"')) )
            	    {
            	        alt6 = 4;
            	    }
            	    else if ( ((LA6_0 >= '$' && LA6_0 <= '?')) )
            	    {
            	        alt6 = 5;
            	    }
            	    else if ( ((LA6_0 >= 'A' && LA6_0 <= '\uFFFF')) )
            	    {
            	        alt6 = 6;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // SpecFlowLangLexer_de.g:35:20: ( '\\u0000' .. '\\b' )
            			    {
            			    	// SpecFlowLangLexer_de.g:35:20: ( '\\u0000' .. '\\b' )
            			    	// SpecFlowLangLexer_de.g:35:21: '\\u0000' .. '\\b'
            			    	{
            			    		MatchRange('\u0000','\b'); if (state.failed) return ;

            			    	}


            			    }
            			    break;
            			case 2 :
            			    // SpecFlowLangLexer_de.g:36:7: ( '\\u000B' .. '\\f' )
            			    {
            			    	// SpecFlowLangLexer_de.g:36:7: ( '\\u000B' .. '\\f' )
            			    	// SpecFlowLangLexer_de.g:36:8: '\\u000B' .. '\\f'
            			    	{
            			    		MatchRange('\u000B','\f'); if (state.failed) return ;

            			    	}


            			    }
            			    break;
            			case 3 :
            			    // SpecFlowLangLexer_de.g:37:7: ( '\\u000E' .. '\\u001F' )
            			    {
            			    	// SpecFlowLangLexer_de.g:37:7: ( '\\u000E' .. '\\u001F' )
            			    	// SpecFlowLangLexer_de.g:37:8: '\\u000E' .. '\\u001F'
            			    	{
            			    		MatchRange('\u000E','\u001F'); if (state.failed) return ;

            			    	}


            			    }
            			    break;
            			case 4 :
            			    // SpecFlowLangLexer_de.g:38:7: ( '!' .. '\"' )
            			    {
            			    	// SpecFlowLangLexer_de.g:38:7: ( '!' .. '\"' )
            			    	// SpecFlowLangLexer_de.g:38:8: '!' .. '\"'
            			    	{
            			    		MatchRange('!','\"'); if (state.failed) return ;

            			    	}


            			    }
            			    break;
            			case 5 :
            			    // SpecFlowLangLexer_de.g:39:7: ( '$' .. '?' )
            			    {
            			    	// SpecFlowLangLexer_de.g:39:7: ( '$' .. '?' )
            			    	// SpecFlowLangLexer_de.g:39:8: '$' .. '?'
            			    	{
            			    		MatchRange('$','?'); if (state.failed) return ;

            			    	}


            			    }
            			    break;
            			case 6 :
            			    // SpecFlowLangLexer_de.g:40:7: ( 'A' .. '\\uFFFF' )
            			    {
            			    	// SpecFlowLangLexer_de.g:40:7: ( 'A' .. '\\uFFFF' )
            			    	// SpecFlowLangLexer_de.g:40:8: 'A' .. '\\uFFFF'
            			    	{
            			    		MatchRange('A','\uFFFF'); if (state.failed) return ;

            			    	}


            			    }
            			    break;

            			default:
            			    if ( cnt6 >= 1 ) goto loop6;
            			    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            		            EarlyExitException eee6 =
            		                new EarlyExitException(6, input);
            		            throw eee6;
            	    }
            	    cnt6++;
            	} while (true);

            	loop6:
            		;	// Stops C# compiler whinging that label 'loop6' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WORDCHAR"

    override public void mTokens() // throws RecognitionException 
    {
        // SpecFlowLangLexer_de.g:1:39: ( T_FEATURE | T_BACKGROUND | T_SCENARIO | T_SCENARIO_OUTLINE | T_EXAMPLES | T_GIVEN | T_WHEN | T_THEN | T_AND | T_BUT | MLTEXT | CELLSEP | AT | COMMENT | WS | NEWLINE | WORDCHAR )
        int alt7 = 17;
        alt7 = dfa7.Predict(input);
        switch (alt7) 
        {
            case 1 :
                // SpecFlowLangLexer_de.g:1:41: T_FEATURE
                {
                	mT_FEATURE(); if (state.failed) return ;

                }
                break;
            case 2 :
                // SpecFlowLangLexer_de.g:1:51: T_BACKGROUND
                {
                	mT_BACKGROUND(); if (state.failed) return ;

                }
                break;
            case 3 :
                // SpecFlowLangLexer_de.g:1:64: T_SCENARIO
                {
                	mT_SCENARIO(); if (state.failed) return ;

                }
                break;
            case 4 :
                // SpecFlowLangLexer_de.g:1:75: T_SCENARIO_OUTLINE
                {
                	mT_SCENARIO_OUTLINE(); if (state.failed) return ;

                }
                break;
            case 5 :
                // SpecFlowLangLexer_de.g:1:94: T_EXAMPLES
                {
                	mT_EXAMPLES(); if (state.failed) return ;

                }
                break;
            case 6 :
                // SpecFlowLangLexer_de.g:1:105: T_GIVEN
                {
                	mT_GIVEN(); if (state.failed) return ;

                }
                break;
            case 7 :
                // SpecFlowLangLexer_de.g:1:113: T_WHEN
                {
                	mT_WHEN(); if (state.failed) return ;

                }
                break;
            case 8 :
                // SpecFlowLangLexer_de.g:1:120: T_THEN
                {
                	mT_THEN(); if (state.failed) return ;

                }
                break;
            case 9 :
                // SpecFlowLangLexer_de.g:1:127: T_AND
                {
                	mT_AND(); if (state.failed) return ;

                }
                break;
            case 10 :
                // SpecFlowLangLexer_de.g:1:133: T_BUT
                {
                	mT_BUT(); if (state.failed) return ;

                }
                break;
            case 11 :
                // SpecFlowLangLexer_de.g:1:139: MLTEXT
                {
                	mMLTEXT(); if (state.failed) return ;

                }
                break;
            case 12 :
                // SpecFlowLangLexer_de.g:1:146: CELLSEP
                {
                	mCELLSEP(); if (state.failed) return ;

                }
                break;
            case 13 :
                // SpecFlowLangLexer_de.g:1:154: AT
                {
                	mAT(); if (state.failed) return ;

                }
                break;
            case 14 :
                // SpecFlowLangLexer_de.g:1:157: COMMENT
                {
                	mCOMMENT(); if (state.failed) return ;

                }
                break;
            case 15 :
                // SpecFlowLangLexer_de.g:1:165: WS
                {
                	mWS(); if (state.failed) return ;

                }
                break;
            case 16 :
                // SpecFlowLangLexer_de.g:1:168: NEWLINE
                {
                	mNEWLINE(); if (state.failed) return ;

                }
                break;
            case 17 :
                // SpecFlowLangLexer_de.g:1:176: WORDCHAR
                {
                	mWORDCHAR(); if (state.failed) return ;

                }
                break;

        }

    }

    // $ANTLR start "synpred1_SpecFlowLangLexer_de"
    public void synpred1_SpecFlowLangLexer_de_fragment() {
        // SpecFlowLangLexer_de.g:1:41: ( T_FEATURE )
        // SpecFlowLangLexer_de.g:1:41: T_FEATURE
        {
        	mT_FEATURE(); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred1_SpecFlowLangLexer_de"

    // $ANTLR start "synpred2_SpecFlowLangLexer_de"
    public void synpred2_SpecFlowLangLexer_de_fragment() {
        // SpecFlowLangLexer_de.g:1:51: ( T_BACKGROUND )
        // SpecFlowLangLexer_de.g:1:51: T_BACKGROUND
        {
        	mT_BACKGROUND(); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred2_SpecFlowLangLexer_de"

    // $ANTLR start "synpred3_SpecFlowLangLexer_de"
    public void synpred3_SpecFlowLangLexer_de_fragment() {
        // SpecFlowLangLexer_de.g:1:64: ( T_SCENARIO )
        // SpecFlowLangLexer_de.g:1:64: T_SCENARIO
        {
        	mT_SCENARIO(); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred3_SpecFlowLangLexer_de"

    // $ANTLR start "synpred4_SpecFlowLangLexer_de"
    public void synpred4_SpecFlowLangLexer_de_fragment() {
        // SpecFlowLangLexer_de.g:1:75: ( T_SCENARIO_OUTLINE )
        // SpecFlowLangLexer_de.g:1:75: T_SCENARIO_OUTLINE
        {
        	mT_SCENARIO_OUTLINE(); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred4_SpecFlowLangLexer_de"

    // $ANTLR start "synpred5_SpecFlowLangLexer_de"
    public void synpred5_SpecFlowLangLexer_de_fragment() {
        // SpecFlowLangLexer_de.g:1:94: ( T_EXAMPLES )
        // SpecFlowLangLexer_de.g:1:94: T_EXAMPLES
        {
        	mT_EXAMPLES(); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred5_SpecFlowLangLexer_de"

    // $ANTLR start "synpred6_SpecFlowLangLexer_de"
    public void synpred6_SpecFlowLangLexer_de_fragment() {
        // SpecFlowLangLexer_de.g:1:105: ( T_GIVEN )
        // SpecFlowLangLexer_de.g:1:105: T_GIVEN
        {
        	mT_GIVEN(); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred6_SpecFlowLangLexer_de"

    // $ANTLR start "synpred7_SpecFlowLangLexer_de"
    public void synpred7_SpecFlowLangLexer_de_fragment() {
        // SpecFlowLangLexer_de.g:1:113: ( T_WHEN )
        // SpecFlowLangLexer_de.g:1:113: T_WHEN
        {
        	mT_WHEN(); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred7_SpecFlowLangLexer_de"

    // $ANTLR start "synpred8_SpecFlowLangLexer_de"
    public void synpred8_SpecFlowLangLexer_de_fragment() {
        // SpecFlowLangLexer_de.g:1:120: ( T_THEN )
        // SpecFlowLangLexer_de.g:1:120: T_THEN
        {
        	mT_THEN(); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred8_SpecFlowLangLexer_de"

    // $ANTLR start "synpred9_SpecFlowLangLexer_de"
    public void synpred9_SpecFlowLangLexer_de_fragment() {
        // SpecFlowLangLexer_de.g:1:127: ( T_AND )
        // SpecFlowLangLexer_de.g:1:127: T_AND
        {
        	mT_AND(); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred9_SpecFlowLangLexer_de"

    // $ANTLR start "synpred10_SpecFlowLangLexer_de"
    public void synpred10_SpecFlowLangLexer_de_fragment() {
        // SpecFlowLangLexer_de.g:1:133: ( T_BUT )
        // SpecFlowLangLexer_de.g:1:133: T_BUT
        {
        	mT_BUT(); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred10_SpecFlowLangLexer_de"

    // $ANTLR start "synpred11_SpecFlowLangLexer_de"
    public void synpred11_SpecFlowLangLexer_de_fragment() {
        // SpecFlowLangLexer_de.g:1:139: ( MLTEXT )
        // SpecFlowLangLexer_de.g:1:139: MLTEXT
        {
        	mMLTEXT(); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred11_SpecFlowLangLexer_de"

    // $ANTLR start "synpred12_SpecFlowLangLexer_de"
    public void synpred12_SpecFlowLangLexer_de_fragment() {
        // SpecFlowLangLexer_de.g:1:146: ( CELLSEP )
        // SpecFlowLangLexer_de.g:1:146: CELLSEP
        {
        	mCELLSEP(); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred12_SpecFlowLangLexer_de"

    // $ANTLR start "synpred14_SpecFlowLangLexer_de"
    public void synpred14_SpecFlowLangLexer_de_fragment() {
        // SpecFlowLangLexer_de.g:1:157: ( COMMENT )
        // SpecFlowLangLexer_de.g:1:157: COMMENT
        {
        	mCOMMENT(); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred14_SpecFlowLangLexer_de"

    // $ANTLR start "synpred15_SpecFlowLangLexer_de"
    public void synpred15_SpecFlowLangLexer_de_fragment() {
        // SpecFlowLangLexer_de.g:1:165: ( WS )
        // SpecFlowLangLexer_de.g:1:165: WS
        {
        	mWS(); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred15_SpecFlowLangLexer_de"

   	public bool synpred10_SpecFlowLangLexer_de() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred10_SpecFlowLangLexer_de_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred6_SpecFlowLangLexer_de() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred6_SpecFlowLangLexer_de_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred14_SpecFlowLangLexer_de() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred14_SpecFlowLangLexer_de_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred4_SpecFlowLangLexer_de() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred4_SpecFlowLangLexer_de_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred12_SpecFlowLangLexer_de() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred12_SpecFlowLangLexer_de_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred9_SpecFlowLangLexer_de() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred9_SpecFlowLangLexer_de_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred3_SpecFlowLangLexer_de() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred3_SpecFlowLangLexer_de_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred11_SpecFlowLangLexer_de() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred11_SpecFlowLangLexer_de_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred1_SpecFlowLangLexer_de() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred1_SpecFlowLangLexer_de_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred2_SpecFlowLangLexer_de() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred2_SpecFlowLangLexer_de_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred15_SpecFlowLangLexer_de() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred15_SpecFlowLangLexer_de_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred7_SpecFlowLangLexer_de() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred7_SpecFlowLangLexer_de_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred5_SpecFlowLangLexer_de() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred5_SpecFlowLangLexer_de_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred8_SpecFlowLangLexer_de() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred8_SpecFlowLangLexer_de_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}


    protected DFA7 dfa7;
	private void InitializeCyclicDFAs()
	{
	    this.dfa7 = new DFA7(this);
	    this.dfa7.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA7_SpecialStateTransition);
	}

    const string DFA7_eotS =
        "\x1e\uffff";
    const string DFA7_eofS =
        "\x1e\uffff";
    const string DFA7_minS =
        "\x01\x00\x01\uffff\x01\x00\x03\uffff\x01\x00\x03\uffff\x01\x00"+
        "\x02\uffff\x01\x00\x01\uffff\x01\x00\x01\uffff\x01\x00\x01\uffff"+
        "\x01\x00\x01\uffff\x01\x00\x01\uffff\x01\x00\x01\uffff\x01\x00\x02"+
        "\uffff\x01\x00\x01\uffff";
    const string DFA7_maxS =
        "\x01\uffff\x01\uffff\x01\x00\x03\uffff\x01\x00\x03\uffff\x01\x00"+
        "\x02\uffff\x01\x00\x01\uffff\x01\x00\x01\uffff\x01\x00\x01\uffff"+
        "\x01\x00\x01\uffff\x01\x00\x01\uffff\x01\x00\x01\uffff\x01\x00\x02"+
        "\uffff\x01\x00\x01\uffff";
    const string DFA7_acceptS =
        "\x01\uffff\x01\x10\x01\uffff\x01\x01\x01\x11\x01\x0e\x01\uffff"+
        "\x01\x09\x01\x0d\x01\x11\x01\uffff\x01\x02\x01\x06\x01\uffff\x01"+
        "\x0c\x01\uffff\x01\x0f\x01\uffff\x01\x07\x01\uffff\x01\x05\x01\uffff"+
        "\x01\x08\x01\uffff\x01\x0a\x01\uffff\x01\x03\x01\x04\x01\uffff\x01"+
        "\x0b";
    const string DFA7_specialS =
        "\x01\x00\x01\uffff\x01\x01\x03\uffff\x01\x02\x03\uffff\x01\x03"+
        "\x02\uffff\x01\x04\x01\uffff\x01\x05\x01\uffff\x01\x06\x01\uffff"+
        "\x01\x07\x01\uffff\x01\x08\x01\uffff\x01\x09\x01\uffff\x01\x0a\x02"+
        "\uffff\x01\x0b\x01\uffff}>";
    static readonly string[] DFA7_transitionS = {
            "\x09\x09\x01\x0f\x01\x01\x02\x09\x01\x01\x12\x09\x01\x0f\x01"+
            "\x09\x01\x1c\x01\x05\x1c\x09\x01\x08\x01\x17\x01\x13\x01\x09"+
            "\x01\x15\x01\x09\x01\x02\x01\x0a\x0b\x09\x01\x19\x01\x09\x01"+
            "\x06\x01\x09\x01\x11\x24\x09\x01\x0d\uff83\x09",
            "",
            "\x01\uffff",
            "",
            "",
            "",
            "\x01\uffff",
            "",
            "",
            "",
            "\x01\uffff",
            "",
            "",
            "\x01\uffff",
            "",
            "\x01\uffff",
            "",
            "\x01\uffff",
            "",
            "\x01\uffff",
            "",
            "\x01\uffff",
            "",
            "\x01\uffff",
            "",
            "\x01\uffff",
            "",
            "",
            "\x01\uffff",
            ""
    };

    static readonly short[] DFA7_eot = DFA.UnpackEncodedString(DFA7_eotS);
    static readonly short[] DFA7_eof = DFA.UnpackEncodedString(DFA7_eofS);
    static readonly char[] DFA7_min = DFA.UnpackEncodedStringToUnsignedChars(DFA7_minS);
    static readonly char[] DFA7_max = DFA.UnpackEncodedStringToUnsignedChars(DFA7_maxS);
    static readonly short[] DFA7_accept = DFA.UnpackEncodedString(DFA7_acceptS);
    static readonly short[] DFA7_special = DFA.UnpackEncodedString(DFA7_specialS);
    static readonly short[][] DFA7_transition = DFA.UnpackEncodedStringArray(DFA7_transitionS);

    protected class DFA7 : DFA
    {
        public DFA7(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 7;
            this.eot = DFA7_eot;
            this.eof = DFA7_eof;
            this.min = DFA7_min;
            this.max = DFA7_max;
            this.accept = DFA7_accept;
            this.special = DFA7_special;
            this.transition = DFA7_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens options {k=1; backtrack=true; } : ( T_FEATURE | T_BACKGROUND | T_SCENARIO | T_SCENARIO_OUTLINE | T_EXAMPLES | T_GIVEN | T_WHEN | T_THEN | T_AND | T_BUT | MLTEXT | CELLSEP | AT | COMMENT | WS | NEWLINE | WORDCHAR );"; }
        }

    }


    protected internal int DFA7_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            IIntStream input = _input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA7_0 = input.LA(1);

                   	s = -1;
                   	if ( (LA7_0 == '\n' || LA7_0 == '\r') ) { s = 1; }

                   	else if ( (LA7_0 == 'F') ) { s = 2; }

                   	else if ( (LA7_0 == '#') ) { s = 5; }

                   	else if ( (LA7_0 == 'U') ) { s = 6; }

                   	else if ( (LA7_0 == '@') ) { s = 8; }

                   	else if ( ((LA7_0 >= '\u0000' && LA7_0 <= '\b') || (LA7_0 >= '\u000B' && LA7_0 <= '\f') || (LA7_0 >= '\u000E' && LA7_0 <= '\u001F') || LA7_0 == '!' || (LA7_0 >= '$' && LA7_0 <= '?') || LA7_0 == 'C' || LA7_0 == 'E' || (LA7_0 >= 'H' && LA7_0 <= 'R') || LA7_0 == 'T' || LA7_0 == 'V' || (LA7_0 >= 'X' && LA7_0 <= '{') || (LA7_0 >= '}' && LA7_0 <= '\uFFFF')) ) { s = 9; }

                   	else if ( (LA7_0 == 'G') ) { s = 10; }

                   	else if ( (LA7_0 == '|') ) { s = 13; }

                   	else if ( (LA7_0 == '\t' || LA7_0 == ' ') ) { s = 15; }

                   	else if ( (LA7_0 == 'W') ) { s = 17; }

                   	else if ( (LA7_0 == 'B') ) { s = 19; }

                   	else if ( (LA7_0 == 'D') ) { s = 21; }

                   	else if ( (LA7_0 == 'A') ) { s = 23; }

                   	else if ( (LA7_0 == 'S') ) { s = 25; }

                   	else if ( (LA7_0 == '\"') ) { s = 28; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA7_2 = input.LA(1);

                   	 
                   	int index7_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_SpecFlowLangLexer_de()) ) { s = 3; }

                   	else if ( (true) ) { s = 4; }

                   	 
                   	input.Seek(index7_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA7_6 = input.LA(1);

                   	 
                   	int index7_6 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred9_SpecFlowLangLexer_de()) ) { s = 7; }

                   	else if ( (true) ) { s = 4; }

                   	 
                   	input.Seek(index7_6);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA7_10 = input.LA(1);

                   	 
                   	int index7_10 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred2_SpecFlowLangLexer_de()) ) { s = 11; }

                   	else if ( (synpred6_SpecFlowLangLexer_de()) ) { s = 12; }

                   	else if ( (true) ) { s = 9; }

                   	 
                   	input.Seek(index7_10);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA7_13 = input.LA(1);

                   	 
                   	int index7_13 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred12_SpecFlowLangLexer_de()) ) { s = 14; }

                   	else if ( (true) ) { s = 9; }

                   	 
                   	input.Seek(index7_13);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA7_15 = input.LA(1);

                   	 
                   	int index7_15 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred14_SpecFlowLangLexer_de()) ) { s = 5; }

                   	else if ( (synpred15_SpecFlowLangLexer_de()) ) { s = 16; }

                   	 
                   	input.Seek(index7_15);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA7_17 = input.LA(1);

                   	 
                   	int index7_17 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred7_SpecFlowLangLexer_de()) ) { s = 18; }

                   	else if ( (true) ) { s = 9; }

                   	 
                   	input.Seek(index7_17);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 7 : 
                   	int LA7_19 = input.LA(1);

                   	 
                   	int index7_19 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred5_SpecFlowLangLexer_de()) ) { s = 20; }

                   	else if ( (true) ) { s = 9; }

                   	 
                   	input.Seek(index7_19);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 8 : 
                   	int LA7_21 = input.LA(1);

                   	 
                   	int index7_21 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred8_SpecFlowLangLexer_de()) ) { s = 22; }

                   	else if ( (true) ) { s = 9; }

                   	 
                   	input.Seek(index7_21);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 9 : 
                   	int LA7_23 = input.LA(1);

                   	 
                   	int index7_23 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred10_SpecFlowLangLexer_de()) ) { s = 24; }

                   	else if ( (true) ) { s = 9; }

                   	 
                   	input.Seek(index7_23);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 10 : 
                   	int LA7_25 = input.LA(1);

                   	 
                   	int index7_25 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred3_SpecFlowLangLexer_de()) ) { s = 26; }

                   	else if ( (synpred4_SpecFlowLangLexer_de()) ) { s = 27; }

                   	else if ( (true) ) { s = 9; }

                   	 
                   	input.Seek(index7_25);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 11 : 
                   	int LA7_28 = input.LA(1);

                   	 
                   	int index7_28 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred11_SpecFlowLangLexer_de()) ) { s = 29; }

                   	else if ( (true) ) { s = 9; }

                   	 
                   	input.Seek(index7_28);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae7 =
            new NoViableAltException(dfa.Description, 7, _s, input);
        dfa.Error(nvae7);
        throw nvae7;
    }
 
    
}
}