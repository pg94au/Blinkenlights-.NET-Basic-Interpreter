using Blinkenlights.Basic.App.Expressions;

namespace Blinkenlights.Basic.App.Equations
{
    public class LessThanOrEqualEquation : SimpleEquation
    {
        public LessThanOrEqualEquation(IExpression left, IExpression right) : base(left, right)
        {
        }

        protected override bool Solve()
        {
            return LeftValue <= RightValue;
        }
    }
}
