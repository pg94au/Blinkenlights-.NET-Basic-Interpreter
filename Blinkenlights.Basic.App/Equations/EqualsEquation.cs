using Blinkenlights.Basic.App.Expressions;

namespace Blinkenlights.Basic.App.Equations
{
    public class EqualsEquation : SimpleEquation
    {
        public EqualsEquation(IExpression left, IExpression right) : base(left, right)
        {
        }

        protected override bool Solve()
        {
            return LeftValue == RightValue;
        }
    }
}
