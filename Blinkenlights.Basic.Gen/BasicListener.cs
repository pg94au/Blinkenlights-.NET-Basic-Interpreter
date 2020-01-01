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
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="BasicParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.2")]
[System.CLSCompliant(false)]
public interface IBasicListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="BasicParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProgram([NotNull] BasicParser.ProgramContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BasicParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProgram([NotNull] BasicParser.ProgramContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="BasicParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLine([NotNull] BasicParser.LineContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BasicParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLine([NotNull] BasicParser.LineContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="BasicParser.lineNum"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLineNum([NotNull] BasicParser.LineNumContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BasicParser.lineNum"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLineNum([NotNull] BasicParser.LineNumContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="BasicParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] BasicParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BasicParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] BasicParser.StatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="BasicParser.endStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEndStatement([NotNull] BasicParser.EndStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BasicParser.endStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEndStatement([NotNull] BasicParser.EndStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="BasicParser.forStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForStatement([NotNull] BasicParser.ForStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BasicParser.forStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForStatement([NotNull] BasicParser.ForStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="BasicParser.gosubStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGosubStatement([NotNull] BasicParser.GosubStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BasicParser.gosubStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGosubStatement([NotNull] BasicParser.GosubStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="BasicParser.gotoStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGotoStatement([NotNull] BasicParser.GotoStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BasicParser.gotoStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGotoStatement([NotNull] BasicParser.GotoStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="BasicParser.ifStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfStatement([NotNull] BasicParser.IfStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BasicParser.ifStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfStatement([NotNull] BasicParser.IfStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="BasicParser.inputStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInputStatement([NotNull] BasicParser.InputStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BasicParser.inputStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInputStatement([NotNull] BasicParser.InputStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="BasicParser.letStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLetStatement([NotNull] BasicParser.LetStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BasicParser.letStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLetStatement([NotNull] BasicParser.LetStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="BasicParser.nextStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNextStatement([NotNull] BasicParser.NextStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BasicParser.nextStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNextStatement([NotNull] BasicParser.NextStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="BasicParser.printStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrintStatement([NotNull] BasicParser.PrintStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BasicParser.printStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrintStatement([NotNull] BasicParser.PrintStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="BasicParser.returnStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReturnStatement([NotNull] BasicParser.ReturnStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BasicParser.returnStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReturnStatement([NotNull] BasicParser.ReturnStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>printQuotedString</c>
	/// labeled alternative in <see cref="BasicParser.arg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrintQuotedString([NotNull] BasicParser.PrintQuotedStringContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>printQuotedString</c>
	/// labeled alternative in <see cref="BasicParser.arg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrintQuotedString([NotNull] BasicParser.PrintQuotedStringContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>printExpression</c>
	/// labeled alternative in <see cref="BasicParser.arg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrintExpression([NotNull] BasicParser.PrintExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>printExpression</c>
	/// labeled alternative in <see cref="BasicParser.arg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrintExpression([NotNull] BasicParser.PrintExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>printVariable</c>
	/// labeled alternative in <see cref="BasicParser.arg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrintVariable([NotNull] BasicParser.PrintVariableContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>printVariable</c>
	/// labeled alternative in <see cref="BasicParser.arg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrintVariable([NotNull] BasicParser.PrintVariableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="BasicParser.argSeparator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArgSeparator([NotNull] BasicParser.ArgSeparatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BasicParser.argSeparator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArgSeparator([NotNull] BasicParser.ArgSeparatorContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>division</c>
	/// labeled alternative in <see cref="BasicParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDivision([NotNull] BasicParser.DivisionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>division</c>
	/// labeled alternative in <see cref="BasicParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDivision([NotNull] BasicParser.DivisionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>parentheses</c>
	/// labeled alternative in <see cref="BasicParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParentheses([NotNull] BasicParser.ParenthesesContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>parentheses</c>
	/// labeled alternative in <see cref="BasicParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParentheses([NotNull] BasicParser.ParenthesesContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>variable</c>
	/// labeled alternative in <see cref="BasicParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariable([NotNull] BasicParser.VariableContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>variable</c>
	/// labeled alternative in <see cref="BasicParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariable([NotNull] BasicParser.VariableContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>subtraction</c>
	/// labeled alternative in <see cref="BasicParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSubtraction([NotNull] BasicParser.SubtractionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>subtraction</c>
	/// labeled alternative in <see cref="BasicParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSubtraction([NotNull] BasicParser.SubtractionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>multiplication</c>
	/// labeled alternative in <see cref="BasicParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiplication([NotNull] BasicParser.MultiplicationContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>multiplication</c>
	/// labeled alternative in <see cref="BasicParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiplication([NotNull] BasicParser.MultiplicationContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>value</c>
	/// labeled alternative in <see cref="BasicParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterValue([NotNull] BasicParser.ValueContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>value</c>
	/// labeled alternative in <see cref="BasicParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitValue([NotNull] BasicParser.ValueContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>addition</c>
	/// labeled alternative in <see cref="BasicParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAddition([NotNull] BasicParser.AdditionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>addition</c>
	/// labeled alternative in <see cref="BasicParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAddition([NotNull] BasicParser.AdditionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>equals</c>
	/// labeled alternative in <see cref="BasicParser.equation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEquals([NotNull] BasicParser.EqualsContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>equals</c>
	/// labeled alternative in <see cref="BasicParser.equation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEquals([NotNull] BasicParser.EqualsContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>doesNotEqual</c>
	/// labeled alternative in <see cref="BasicParser.equation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDoesNotEqual([NotNull] BasicParser.DoesNotEqualContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>doesNotEqual</c>
	/// labeled alternative in <see cref="BasicParser.equation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDoesNotEqual([NotNull] BasicParser.DoesNotEqualContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>greaterThan</c>
	/// labeled alternative in <see cref="BasicParser.equation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGreaterThan([NotNull] BasicParser.GreaterThanContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>greaterThan</c>
	/// labeled alternative in <see cref="BasicParser.equation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGreaterThan([NotNull] BasicParser.GreaterThanContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>lessThan</c>
	/// labeled alternative in <see cref="BasicParser.equation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLessThan([NotNull] BasicParser.LessThanContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>lessThan</c>
	/// labeled alternative in <see cref="BasicParser.equation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLessThan([NotNull] BasicParser.LessThanContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>greaterThanOrEqual</c>
	/// labeled alternative in <see cref="BasicParser.equation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGreaterThanOrEqual([NotNull] BasicParser.GreaterThanOrEqualContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>greaterThanOrEqual</c>
	/// labeled alternative in <see cref="BasicParser.equation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGreaterThanOrEqual([NotNull] BasicParser.GreaterThanOrEqualContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>lessThanOrEqual</c>
	/// labeled alternative in <see cref="BasicParser.equation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLessThanOrEqual([NotNull] BasicParser.LessThanOrEqualContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>lessThanOrEqual</c>
	/// labeled alternative in <see cref="BasicParser.equation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLessThanOrEqual([NotNull] BasicParser.LessThanOrEqualContext context);
}
} // namespace Blinkenlights.Basic.Gen
