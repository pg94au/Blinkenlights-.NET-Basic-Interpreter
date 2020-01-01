namespace Blinkenlights.Basic.App.Statements
{
    public class PrintStatement : IStatement
    {
        public PrintArgument[] PrintArguments { get; }

        public PrintStatement(PrintArgument[] printArguments)
        {
            PrintArguments = printArguments;
        }

        public void Execute(Interpreter interpreter)
        {
            foreach (var printArgument in PrintArguments)
            {
                interpreter.OutputWriter.Write(printArgument.ToString(interpreter));
            }

            interpreter.OutputWriter.WriteLine();
            interpreter.AdvanceLine();
        }
    }
}
