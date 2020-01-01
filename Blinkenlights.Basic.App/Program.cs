using System;
using System.IO;

namespace Blinkenlights.Basic.App
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Usage BasicInterpreterApp <programFile>");
                return;
            }

            var program = File.ReadAllText(args[0]);

            var interpreter = new Interpreter(program);
            interpreter.ExecuteProgram();
        }
    }
}
