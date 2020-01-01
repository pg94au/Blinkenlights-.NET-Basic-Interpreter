namespace Blinkenlights.Basic.App.Expressions
{
    public class AdditionExpression : IExpression
    {
        public IExpression Left { get; }
        public IExpression Right { get; }

        public AdditionExpression(IExpression left, IExpression right)
        {
            Left = left;
            Right = right;
        }

        public int Calculate(Interpreter interpreter)
        {
            return Left.Calculate(interpreter) + Right.Calculate(interpreter);
        }
    }
}
