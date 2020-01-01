using System;

namespace Blinkenlights.Basic.App.Statements
{
    public class GosubStatement : IStatement
    {
        public int TargetLineNumber { get; }

        public GosubStatement(int targetLineNumber)
        {
            TargetLineNumber = targetLineNumber;
        }

        public void Execute(Interpreter interpreter)
        {
            try
            {
                interpreter.PushLineNumber();
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
