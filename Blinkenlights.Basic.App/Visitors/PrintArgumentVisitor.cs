using System;
using System.Collections.Generic;
using Blinkenlights.Basic.App.Statements;
using Blinkenlights.Basic.Gen;

namespace Blinkenlights.Basic.App.Visitors
{
    public class PrintArgumentVisitor : BasicBaseVisitor<String>
    {
        public List<PrintArgument> Arguments { get; } = new List<PrintArgument>();

        public override string VisitPrintQuotedString(BasicParser.PrintQuotedStringContext context)
        {
            var quotedString = context.QUOTED_STRING().GetText();
            quotedString = quotedString.Substring(1, quotedString.Length - 2);
            var printArgument = PrintArgument.FromText(quotedString);

            Arguments.Add(printArgument);

            return base.VisitPrintQuotedString(context);
        }

        public override string VisitPrintExpression(BasicParser.PrintExpressionContext context)
        {
            var expressionVisitor = new ExpressionVisitor();
            var expression = expressionVisitor.Visit(context.expression());
            var printArgument = PrintArgument.FromExpression(expression);

            Arguments.Add(printArgument);

            return base.VisitPrintExpression(context);
        }

        public override string VisitArgSeparator(BasicParser.ArgSeparatorContext context)
        {
            string separator = null;
            switch (context.GetText())
            {
                case ",":
                    separator = " ";
                    break;
                case ";":
                    separator = "";
                    break;
            }

            var printArgument = PrintArgument.FromText(separator);

            Arguments.Add(printArgument);

            return base.VisitArgSeparator(context);
        }
    }
}
