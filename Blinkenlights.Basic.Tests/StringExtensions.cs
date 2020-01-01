using System;
using System.IO;
using System.Text;
using Blinkenlights.Basic.App;

namespace Blinkenlights.Basic.Tests
{
    public static class StringExtensions
    {
        public static Interpreter Execute(this string statements)
        {
            var interpreter = new Interpreter(statements);
            interpreter.ExecuteProgram();

            return interpreter;
        }

        public static Interpreter ExecuteWithInputReader(this string statements, TextReader inputReader)
        {
            var interpreter = new Interpreter(statements, inputReader, new StringWriter(new StringBuilder()), new StringWriter(new StringBuilder()));
            interpreter.ExecuteProgram();

            return interpreter;
        }

        public static Interpreter ExecuteWithOutput(this string statements, out string output)
        {
            var sb = new StringBuilder();
            var outputWriter = new StringWriter(sb);

            var interpreter = new Interpreter(statements, Console.In, outputWriter, new StringWriter(new StringBuilder()));
            interpreter.ExecuteProgram();

            output = sb.ToString();

            return interpreter;
        }

        public static Interpreter ExecuteWithError(this string statements, out string error)
        {
            var sb = new StringBuilder();
            var errorWriter = new StringWriter(sb);

            var interpreter = new Interpreter(statements, Console.In, new StringWriter(new StringBuilder()), errorWriter);
            interpreter.ExecuteProgram();

            error = sb.ToString();

            return interpreter;
        }
    }
}
