namespace Blinkenlights.Basic.App.Statements
{
    public class InputStatement : IStatement
    {
        public string VariableName { get; }

        public InputStatement(string variableName)
        {
            VariableName = variableName;
        }

        public void Execute(Interpreter interpreter)
        {
            interpreter.OutputWriter.Write("? ");
            var input = interpreter.InputReader.ReadLine();
            var value = int.Parse(input);
            interpreter.WriteVariable(VariableName, value);
            interpreter.AdvanceLine();
        }
    }
}
