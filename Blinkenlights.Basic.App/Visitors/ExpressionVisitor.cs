using Blinkenlights.Basic.App.Expressions;
using Blinkenlights.Basic.Gen;

namespace Blinkenlights.Basic.App.Visitors
{
    public class ExpressionVisitor : BasicBaseVisitor<IExpression>
    {
        public override IExpression VisitValue(BasicParser.ValueContext context)
        {
            return new NumberExpression(int.Parse(context.INT().ToString()));
        }

        public override IExpression VisitAddition(BasicParser.AdditionContext context)
        {
            var left = Visit(context.expression(0));
            var right = Visit(context.expression(1));

            return new AdditionExpression(left, right);
        }

        public override IExpression VisitSubtraction(BasicParser.SubtractionContext context)
        {
            var left = Visit(context.expression(0));
            var right = Visit(context.expression(1));

            return new SubtractionExpression(left, right);
        }

        public override IExpression VisitMultiplication(BasicParser.MultiplicationContext context)
        {
            var left = Visit(context.expression(0));
            var right = Visit(context.expression(1));

            return new MultiplicationExpression(left, right);
        }

        public override IExpression VisitDivision(BasicParser.DivisionContext context)
        {
            var left = Visit(context.expression(0));
            var right = Visit(context.expression(1));

            return new DivisionExpression(left, right);
        }

        public override IExpression VisitParentheses(BasicParser.ParenthesesContext context)
        {
            var parentheses = Visit(context.expression());

            return parentheses;
        }

        public override IExpression VisitVariable(BasicParser.VariableContext context)
        {
            return new VariableExpression(context.VARNAME().GetText());
        }
    }
}
