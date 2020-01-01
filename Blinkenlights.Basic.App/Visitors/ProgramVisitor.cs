using System.Collections.Generic;
using Blinkenlights.Basic.App.Statements;
using Blinkenlights.Basic.Gen;

namespace Blinkenlights.Basic.App.Visitors
{
    public class ProgramVisitor : BasicBaseVisitor<string>
    {
        public SortedDictionary<int, IStatement> Statements { get; } = new SortedDictionary<int, IStatement>();
        private int _currentLineNumber;

        public override string VisitLineNum(BasicParser.LineNumContext context)
        {
            _currentLineNumber = int.Parse(context.INT().ToString());

            return base.VisitLineNum(context);
        }

        public override string VisitEndStatement(BasicParser.EndStatementContext context)
        {
            var endStatement = new EndStatement();
            Statements[_currentLineNumber] = endStatement;

            return base.VisitEndStatement(context);
        }

        public override string VisitForStatement(BasicParser.ForStatementContext context)
        {
            var variableName = context.VARNAME().ToString();
            var fromValue = int.Parse(context.INT(0).ToString());
            var toValue = int.Parse(context.INT(1).ToString());

            var forStatement = new ForStatement(variableName, fromValue, toValue);
            Statements[_currentLineNumber] = forStatement;

            return base.VisitForStatement(context);
        }

        public override string VisitGosubStatement(BasicParser.GosubStatementContext context)
        {
            var targetLineNumber = int.Parse(context.INT().ToString());
            var gosubStatement = new GosubStatement(targetLineNumber);
            Statements[_currentLineNumber] = gosubStatement;

            return base.VisitGosubStatement(context);
        }

        public override string VisitGotoStatement(BasicParser.GotoStatementContext context)
        {
            var targetLineNumber = int.Parse(context.INT().ToString());
            var gotoStatement = new GotoStatement(targetLineNumber);
            Statements[_currentLineNumber] = gotoStatement;

            return base.VisitGotoStatement(context);
        }

        public override string VisitIfStatement(BasicParser.IfStatementContext context)
        {
            var equationVisitor = new EquationVisitor();
            var equation = equationVisitor.Visit(context.equation());
            var targetLineNumber = int.Parse(context.INT().ToString());
            var ifStatement = new IfStatement(equation, targetLineNumber);
            Statements[_currentLineNumber] = ifStatement;

            return base.VisitIfStatement(context);
        }

        public override string VisitInputStatement(BasicParser.InputStatementContext context)
        {
            var variableName = context.VARNAME().ToString();
            var inputStatement = new InputStatement(variableName);
            Statements[_currentLineNumber] = inputStatement;

            return base.VisitInputStatement(context);
        }

        public override string VisitLetStatement(BasicParser.LetStatementContext context)
        {
            var variableName = context.VARNAME().ToString();
            var expressionVisitor = new ExpressionVisitor();
            var expression = expressionVisitor.Visit(context.expression());
            var letStatement = new LetStatement(variableName, expression);
            Statements[_currentLineNumber] = letStatement;

            return base.VisitLetStatement(context);
        }

        public override string VisitNextStatement(BasicParser.NextStatementContext context)
        {
            var variableName = context.VARNAME().ToString();
            var nextStatement = new NextStatement(variableName);
            Statements[_currentLineNumber] = nextStatement;

            return base.VisitNextStatement(context);
        }

        public override string VisitPrintStatement(BasicParser.PrintStatementContext context)
        {
            var printArgumentVisitor = new PrintArgumentVisitor();
            printArgumentVisitor.Visit(context);
            var args = printArgumentVisitor.Arguments;
            var printStatement = new PrintStatement(args.ToArray());
            Statements[_currentLineNumber] = printStatement;

            return base.VisitPrintStatement(context);
        }

        public override string VisitReturnStatement(BasicParser.ReturnStatementContext context)
        {
            var returnStatement = new ReturnStatement();
            Statements[_currentLineNumber] = returnStatement;

            return base.VisitReturnStatement(context);
        }
    }
}
 