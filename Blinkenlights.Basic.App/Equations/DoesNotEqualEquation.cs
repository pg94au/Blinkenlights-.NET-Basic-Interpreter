using Blinkenlights.Basic.App.Expressions;

namespace Blinkenlights.Basic.App.Equations
{
    public class DoesNotEqualEquation : SimpleEquation
    {
        public DoesNotEqualEquation(IExpression left, IExpression right) : base(left, right)
        {
        }

        protected override bool Solve()
        {
            return LeftValue != RightValue;
        }
    }
}
