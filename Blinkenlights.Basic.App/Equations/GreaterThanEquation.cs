using Blinkenlights.Basic.App.Expressions;

namespace Blinkenlights.Basic.App.Equations
{
    public class GreaterThanEquation : SimpleEquation
    {
        public GreaterThanEquation(IExpression left, IExpression right) : base(left, right)
        {
        }

        protected override bool Solve()
        {
            return LeftValue > RightValue;
        }
    }
}
