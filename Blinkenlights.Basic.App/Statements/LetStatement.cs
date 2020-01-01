using Blinkenlights.Basic.App.Expressions;

namespace Blinkenlights.Basic.App.Statements
{
    public class LetStatement : IStatement
    {
        public string VariableName { get; }
        public IExpression Expression { get; }

        public LetStatement(string variableName, IExpression expression)
        {
            VariableName = variableName;
            Expression = expression;
        }

        public void Execute(Interpreter interpreter)
        {
            var result = Expression.Calculate(interpreter);
            interpreter.WriteVariable(VariableName, result);
            interpreter.AdvanceLine();
        }
    }
}
