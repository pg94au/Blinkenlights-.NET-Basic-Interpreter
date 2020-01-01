using System.Collections.Generic;
using System.IO;
using Antlr4.Runtime;
using Blinkenlights.Basic.App.Statements;
using Blinkenlights.Basic.App.Visitors;
using Blinkenlights.Basic.Gen;

namespace Blinkenlights.Basic.App
{
    public class StatementParser
    {
        public SortedDictionary<int, IStatement> Parse(Stream inputStream)
        {
            var input = new AntlrInputStream(inputStream);
            var lexer = new BasicLexer(input);
            var tokens = new CommonTokenStream(lexer);
            var parser = new BasicParser(tokens);
            var tree = parser.program();

            var visitor = new ProgramVisitor();
            visitor.Visit(tree);

            var statements = visitor.Statements;

            return statements;
        }
    }
}
