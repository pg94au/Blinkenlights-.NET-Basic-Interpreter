namespace Blinkenlights.Basic.App
{
    public class ForState
    {
        public string VariableName { get; }
        public int Limit { get; }
        public int StartingLineNumber { get; }

        public ForState(string variableName, int limit, int startingLineNumber)
        {
            VariableName = variableName;
            Limit = limit;
            StartingLineNumber = startingLineNumber;
        }
    }
}
