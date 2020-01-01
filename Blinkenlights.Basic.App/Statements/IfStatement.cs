using Blinkenlights.Basic.App.Equations;

namespace Blinkenlights.Basic.App.Statements
{
    public class IfStatement : IStatement
    {
        public IEquation Equation { get; }
        public int TargetLineNumber { get; }

        public IfStatement(IEquation equation, int targetLineNumber)
        {
            Equation = equation;
            TargetLineNumber = targetLineNumber;
        }

        public void Execute(Interpreter interpreter)
        {
            if (Equation.Solve(interpreter))
            {
                interpreter.GotoLine(TargetLineNumber);
            }
            else
            {
                interpreter.AdvanceLine();
            }
        }
    }
}
