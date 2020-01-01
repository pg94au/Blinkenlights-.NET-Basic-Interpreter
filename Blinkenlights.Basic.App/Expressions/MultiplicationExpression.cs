namespace Blinkenlights.Basic.App.Expressions
{
    public class MultiplicationExpression : IExpression
    {
        public IExpression Left { get; }
        public IExpression Right { get; }

        public MultiplicationExpression(IExpression left, IExpression right)
        {
            Left = left;
            Right = right;
        }

        public int Calculate(Interpreter interpreter)
        {
            return Left.Calculate(interpreter) * Right.Calculate(interpreter);
        }
    }
}
