using System;

namespace Blinkenlights.Basic.App.Statements
{
    public class GotoStatement : IStatement
    {
        public int TargetLineNumber { get; }

        public GotoStatement(int targetLineNumber)
        {
            TargetLineNumber = targetLineNumber;
        }

        public void Execute(Interpreter interpreter)
        {
            try
            {
                interpreter.GotoLine(TargetLineNumber);
            }
            catch (ArgumentException)
            {
                interpreter.ErrorWriter.WriteLine($"! Target line number {TargetLineNumber} does not exist");
                interpreter.Stop();
            }
        }
    }
}
