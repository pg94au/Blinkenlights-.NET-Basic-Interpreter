using Blinkenlights.Basic.App.Equations;
using Blinkenlights.Basic.Gen;

namespace Blinkenlights.Basic.App.Visitors
{
    public class EquationVisitor : BasicBaseVisitor<IEquation>
    {
        public override IEquation VisitEquals(BasicParser.EqualsContext context)
        {
            var expressionVisitor = new ExpressionVisitor();
            var left = expressionVisitor.Visit(context.expression(0));
            var right = expressionVisitor.Visit(context.expression(1));
            var equation = new EqualsEquation(left, right);

            return equation;
        }

        public override IEquation VisitDoesNotEqual(BasicParser.DoesNotEqualContext context)
        {
            var expressionVisitor = new ExpressionVisitor();
            var left = expressionVisitor.Visit(context.expression(0));
            var right = expressionVisitor.Visit(context.expression(1));
            var equation = new DoesNotEqualEquation(left, right);

            return equation;
        }

        public override IEquation VisitGreaterThan(BasicParser.GreaterThanContext context)
        {
            var expressionVisitor = new ExpressionVisitor();
            var left = expressionVisitor.Visit(context.expression(0));
            var right = expressionVisitor.Visit(context.expression(1));
            var equation = new GreaterThanEquation(left, right);

            return equation;
        }

        public override IEquation VisitLessThan(BasicParser.LessThanContext context)
        {
            var expressionVisitor = new ExpressionVisitor();
            var left = expressionVisitor.Visit(context.expression(0));
            var right = expressionVisitor.Visit(context.expression(1));
            var equation = new LessThanEquation(left, right);

            return equation;
        }

        public override IEquation VisitGreaterThanOrEqual(BasicParser.GreaterThanOrEqualContext context)
        {
            var expressionVisitor = new ExpressionVisitor();
            var left = expressionVisitor.Visit(context.expression(0));
            var right = expressionVisitor.Visit(context.expression(1));
            var equation = new GreaterThanOrEqualEquation(left, right);

            return equation;
        }

        public override IEquation VisitLessThanOrEqual(BasicParser.LessThanOrEqualContext context)
        {
            var expressionVisitor = new ExpressionVisitor();
            var left = expressionVisitor.Visit(context.expression(0));
            var right = expressionVisitor.Visit(context.expression(1));
            var equation = new LessThanOrEqualEquation(left, right);

            return equation;
        }
    }
}
