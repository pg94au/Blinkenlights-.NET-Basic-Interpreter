namespace Blinkenlights.Basic.App.Statements
{
    public interface IStatement
    {
        void Execute(Interpreter interpreter);
    }
}