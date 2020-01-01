namespace Blinkenlights.Basic.App.Equations
{
    public interface IEquation
    {
        bool Solve(Interpreter interpreter);
    }
}