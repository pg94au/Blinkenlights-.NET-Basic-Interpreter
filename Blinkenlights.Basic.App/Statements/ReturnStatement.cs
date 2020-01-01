using System;

namespace Blinkenlights.Basic.App.Statements
{
    public class ReturnStatement : IStatement
    {
        public void Execute(Interpreter interpreter)
        {
            try
            {
                interpreter.PopLineNumber();
                interpreter.AdvanceLine();
            }
            catch (InvalidOperationException)
            {
                interpreter.ErrorWriter.WriteLine($"! Call stack empty");
                interpreter.Stop();
            }
        }
    }
}
