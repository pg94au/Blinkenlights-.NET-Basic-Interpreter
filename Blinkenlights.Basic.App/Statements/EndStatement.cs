namespace Blinkenlights.Basic.App.Statements
{
    public class EndStatement : IStatement
    {
        public void Execute(Interpreter interpreter)
        {
            interpreter.End();
        }
    }
}
