using Blinkenlights.Basic.App.Expressions;

namespace Blinkenlights.Basic.App.Equations
{
    public class LessThanEquation : SimpleEquation
    {
        public LessThanEquation(IExpression left, IExpression right) : base(left, right)
        {
        }

        protected override bool Solve()
        {
            return LeftValue < RightValue;
        }
    }
}
