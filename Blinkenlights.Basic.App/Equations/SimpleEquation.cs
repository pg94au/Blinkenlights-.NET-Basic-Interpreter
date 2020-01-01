using Blinkenlights.Basic.App.Expressions;

namespace Blinkenlights.Basic.App.Equations
{
    public abstract class SimpleEquation : IEquation
    {
        public IExpression Left { get; }
        public IExpression Right { get; }

        protected int LeftValue;
        protected int RightValue;

        protected SimpleEquation(IExpression left, IExpression right)
        {
            Left = left;
            Right = right;
        }

        public bool Solve(Interpreter interpreter)
        {
            LeftValue = Left.Calculate(interpreter);
            RightValue = Right.Calculate(interpreter);

            return Solve();
        }

        protected abstract bool Solve();
    }
}
