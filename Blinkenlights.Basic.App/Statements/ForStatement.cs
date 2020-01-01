namespace Blinkenlights.Basic.App.Statements
{
    public class ForStatement : IStatement
    {
        private string _variableName;
        private int _fromValue;
        private int _toValue;

        public ForStatement(string variableName, int fromValue, int toValue)
        {
            _variableName = variableName;
            _fromValue = fromValue;
            _toValue = toValue;
        }

        public void Execute(Interpreter interpreter)
        {
            interpreter.WriteVariable(_variableName, _fromValue);
            interpreter.AdvanceLine();
            var forState = interpreter.CreateForState(_variableName, _toValue);
            interpreter.PushForLoop(forState);
        }
    }
}
