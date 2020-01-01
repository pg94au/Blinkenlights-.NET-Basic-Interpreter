namespace Blinkenlights.Basic.App.Statements
{
    public class NextStatement : IStatement
    {
        public string VariableName { get; }

        public NextStatement(string variableName)
        {
            VariableName = variableName;
        }

        public void Execute(Interpreter interpreter)
        {
            var forState = interpreter.PopForLoop();
            if (VariableName != forState.VariableName)
            {
                interpreter.ErrorWriter.WriteLine($"! FOR and NEXT variable name mismatch.  Expected {forState.VariableName}, got {VariableName}");
                interpreter.Stop();
                return;
            }

            var loopValue = interpreter.ReadVariable(VariableName);
            loopValue++;
            interpreter.WriteVariable(VariableName, loopValue);

            if (loopValue <= forState.Limit)
            {
                interpreter.PushForLoop(forState);
                interpreter.GotoLine(forState.StartingLineNumber);
            }
            else
            {
                interpreter.AdvanceLine();
            }
        }
    }
}
