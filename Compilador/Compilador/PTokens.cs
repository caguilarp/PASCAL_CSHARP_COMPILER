using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador
{
    class PTokens
    {
        private static int tokType;

        public static readonly int PIDENTIFIER = ++tokType;
        public static readonly int PSTRING = ++tokType;
        public static readonly int AND = ++tokType;
        public static readonly int ARRAY = ++tokType;
       public static readonly int BEGIN = ++tokType;
        public static readonly int CONST = ++tokType;
        public static readonly int DIV = ++tokType;
        public static readonly int ELSE = ++tokType;
        public static readonly int END = ++tokType;
      public static readonly int FOR = ++tokType;
        public static readonly int FUNCTION = ++tokType;
        public static readonly int IF = ++tokType;
        public static readonly int IN = ++tokType;
       public static readonly int LABEL = ++tokType;
        public static readonly int MOD = ++tokType;
        public static readonly int OR = ++tokType;
       public static readonly int PROGRAM = ++tokType;
        public static readonly int THEN = ++tokType;
        public static readonly int VAR = ++tokType;
        public static readonly int WHILE = ++tokType;
        public static readonly int BECOMES = ++tokType;
        public static readonly int PLUS = ++tokType;
        public static readonly int MINUS = ++tokType;
        public static readonly int TIMES = ++tokType;
        public static readonly int DIVIDE = ++tokType;
        public static readonly int INTDIV = ++tokType;
        public static readonly int COMMENT = ++tokType;
        public static readonly int EQUALS = ++tokType;
        public static readonly int NOTEQUALS = ++tokType;
        public static readonly int LESSTHAN = ++tokType;
        public static readonly int GREATERTHAN = ++tokType;
        public static readonly int LESSEQ = ++tokType;
        public static readonly int GREATEREQ = ++tokType;
        public static readonly int DOTDOT = ++tokType;
        public static readonly int OPENPAREN = ++tokType;
        public static readonly int CLOSEPAREN = ++tokType;
        public static readonly int DOT = ++tokType;
        public static readonly int COMMA = ++tokType;
        public static readonly int SEMICOLON = ++tokType;
        public static readonly int COLON = ++tokType;
        public static readonly int OPENBRACKET = ++tokType;
        public static readonly int CLOSEBRACKET = ++tokType;

      // Identificadores
        public static readonly Token TBOOLEAN = new Identifier("BOOLEAN");
        public static readonly Token TCHAR = new Identifier("CHAR");
        public static readonly Token TINTEGER = new Identifier("INTEGER");
        public static readonly Token TREAL = new Identifier("REAL");
        public static readonly Token TSTRING = new Identifier("STRING");
        public static readonly Token TFALSE = new Identifier("FALSE");
        public static readonly Token TTRUE = new Identifier("TRUE");

        //Palabras Clave
        public static readonly Token TAND = new Keyword("AND", AND);
        public static readonly Token TARRAY = new Keyword("ARRAY", ARRAY);
        public static readonly Token TBEGIN = new Keyword("BEGIN", BEGIN);
        public static readonly Token TCONST = new Keyword("CONST", CONST);
        public static readonly Token TELSE = new Keyword("ELSE", ELSE);
        public static readonly Token TEND = new Keyword("END", END);
        public static readonly Token TFOR = new Keyword("FOR", FOR);
       public static readonly Token TIF = new Keyword("IF", IF);
       public static readonly Token TLABEL = new Keyword("LABEL", LABEL);
        public static readonly Token TMOD = new Keyword("MOD", MOD);
        public static readonly Token TOR = new Keyword("OR", OR);
       public static readonly Token TPROGRAM = new Keyword("PROGRAM", PROGRAM);
        public static readonly Token TTHEN = new Keyword("THEN", THEN);
       public static readonly Token TVAR = new Keyword("VAR", VAR);
        public static readonly Token TWHILE = new Keyword("WHILE", WHILE);

        //Aymbolos
        public static readonly Token TBECOMES = new Operator(":=", BECOMES);
        public static readonly Token TPLUS = new Operator("+", PLUS);
        public static readonly Token TMINUS = new Operator("-", MINUS);
        public static readonly Token TTIMES = new Operator("*", TIMES);
        public static readonly Token TDIVIDE = new Operator("/", DIVIDE);
        public static readonly Token TINTDIV = new Operator("DIV", INTDIV);
        public static readonly Token TCOMMENT = new Operator("COMMENT", COMMENT);
        public static readonly Token TEQUALS = new Operator("=", EQUALS);
        public static readonly Token TNOTEQUALS = new Operator("<>", NOTEQUALS);
        public static readonly Token TLESSTHAN = new Operator("<", LESSTHAN);
        public static readonly Token TGREATERTHAN = new Operator(">", GREATERTHAN);
        public static readonly Token TLESSEQ = new Operator("<=", LESSEQ);
        public static readonly Token TGREATEREQ = new Operator(">=", GREATEREQ);
        public static readonly Token TDOTDOT = new Operator("..", DOTDOT);
        public static readonly Token TOPENPAREN = new Operator("(", OPENPAREN);
        public static readonly Token TCLOSEPAREN = new Operator(")", CLOSEPAREN);
        public static readonly Token TDOT = new Operator(".", DOT);
        public static readonly Token TCOMMA = new Operator(",", COMMA);
        public static readonly Token TSEMICOLON = new Operator(";", SEMICOLON);
        public static readonly Token TCOLON = new Operator(":", COLON);
        public static readonly Token TOPENBRACKET = new Operator("[", OPENBRACKET);
        public static readonly Token TCLOSEBRACKET = new Operator("]", CLOSEBRACKET);

        static PTokens()
        {
            tokType = Token.FIRSTID;
        }
    }
}
