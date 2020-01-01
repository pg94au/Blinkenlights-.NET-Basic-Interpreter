namespace Blinkenlights.Basic.App.Expressions
{
    public class VariableExpression : IExpression
    {
        public string VariableName { get; }

        public VariableExpression(string variableName)
        {
            VariableName = variableName;
        }

        public int Calculate(Interpreter interpreter)
        {
            return interpreter.ReadVariable(VariableName);
        }
    }
}
