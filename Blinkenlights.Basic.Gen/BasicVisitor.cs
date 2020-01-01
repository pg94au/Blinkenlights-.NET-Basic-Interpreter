//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from ../antlr/Basic.g4 by ANTLR 4.7.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Blinkenlights.Basic.Gen {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="BasicParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.2")]
[System.CLSCompliant(false)]
public interface IBasicVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="BasicParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProgram([NotNull] BasicParser.ProgramContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="BasicParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLine([NotNull] BasicParser.LineContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="BasicParser.lineNum"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLineNum([NotNull] BasicParser.LineNumContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="BasicParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatement([NotNull] BasicParser.StatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="BasicParser.endStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEndStatement([NotNull] BasicParser.EndStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="BasicParser.forStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForStatement([NotNull] BasicParser.ForStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="BasicParser.gosubStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGosubStatement([NotNull] BasicParser.GosubStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="BasicParser.gotoStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGotoStatement([NotNull] BasicParser.GotoStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="BasicParser.ifStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfStatement([NotNull] BasicParser.IfStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="BasicParser.inputStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInputStatement([NotNull] BasicParser.InputStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="BasicParser.letStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLetStatement([NotNull] BasicParser.LetStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="BasicParser.nextStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNextStatement([NotNull] BasicParser.NextStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="BasicParser.printStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrintStatement([NotNull] BasicParser.PrintStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="BasicParser.returnStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReturnStatement([NotNull] BasicParser.ReturnStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>printQuotedString</c>
	/// labeled alternative in <see cref="BasicParser.arg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrintQuotedString([NotNull] BasicParser.PrintQuotedStringContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>printExpression</c>
	/// labeled alternative in <see cref="BasicParser.arg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrintExpression([NotNull] BasicParser.PrintExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>printVariable</c>
	/// labeled alternative in <see cref="BasicParser.arg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrintVariable([NotNull] BasicParser.PrintVariableContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="BasicParser.argSeparator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArgSeparator([NotNull] BasicParser.ArgSeparatorContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>division</c>
	/// labeled alternative in <see cref="BasicParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDivision([NotNull] BasicParser.DivisionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>parentheses</c>
	/// labeled alternative in <see cref="BasicParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParentheses([NotNull] BasicParser.ParenthesesContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>variable</c>
	/// labeled alternative in <see cref="BasicParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariable([NotNull] BasicParser.VariableContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>subtraction</c>
	/// labeled alternative in <see cref="BasicParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSubtraction([NotNull] BasicParser.SubtractionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>multiplication</c>
	/// labeled alternative in <see cref="BasicParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultiplication([NotNull] BasicParser.MultiplicationContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>value</c>
	/// labeled alternative in <see cref="BasicParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitValue([NotNull] BasicParser.ValueContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>addition</c>
	/// labeled alternative in <see cref="BasicParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAddition([NotNull] BasicParser.AdditionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>equals</c>
	/// labeled alternative in <see cref="BasicParser.equation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEquals([NotNull] BasicParser.EqualsContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>doesNotEqual</c>
	/// labeled alternative in <see cref="BasicParser.equation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDoesNotEqual([NotNull] BasicParser.DoesNotEqualContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>greaterThan</c>
	/// labeled alternative in <see cref="BasicParser.equation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGreaterThan([NotNull] BasicParser.GreaterThanContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>lessThan</c>
	/// labeled alternative in <see cref="BasicParser.equation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLessThan([NotNull] BasicParser.LessThanContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>greaterThanOrEqual</c>
	/// labeled alternative in <see cref="BasicParser.equation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGreaterThanOrEqual([NotNull] BasicParser.GreaterThanOrEqualContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>lessThanOrEqual</c>
	/// labeled alternative in <see cref="BasicParser.equation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLessThanOrEqual([NotNull] BasicParser.LessThanOrEqualContext context);
}
} // namespace Blinkenlights.Basic.Gen