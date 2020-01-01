using Blinkenlights.Basic.App.Expressions;

namespace Blinkenlights.Basic.App.Equations
{
    public class GreaterThanOrEqualEquation : SimpleEquation
    {
        public GreaterThanOrEqualEquation(IExpression left, IExpression right) : base(left, right)
        {
        }

        protected override bool Solve()
        {
            return LeftValue >= RightValue;
        }
    }
}
