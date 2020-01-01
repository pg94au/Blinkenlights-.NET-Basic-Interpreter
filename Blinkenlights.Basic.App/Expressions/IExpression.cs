namespace Blinkenlights.Basic.App.Expressions
{
    public interface IExpression
    {
        int Calculate(Interpreter interpreter);
    }
}