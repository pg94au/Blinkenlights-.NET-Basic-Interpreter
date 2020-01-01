namespace Blinkenlights.Basic.App.Expressions
{
    public class NumberExpression : IExpression
    {
        public int Value { get; }

        public NumberExpression(int value)
        {
            Value = value;
        }

        public int Calculate(Interpreter interpreter)
        {
            return Value;
        }
    }
}
