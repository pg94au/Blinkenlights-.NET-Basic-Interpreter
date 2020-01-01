using Blinkenlights.Basic.App.Expressions;

namespace Blinkenlights.Basic.App.Statements
{
    public class PrintArgument
    {
        public string Text { get; }
        public IExpression Expression { get; }

        private PrintArgument(string text, IExpression expression)
        {
            Text = text;
            Expression = expression;
        }

        public static PrintArgument FromText(string text)
        {
            return new PrintArgument(text, null);
        }

        public static PrintArgument FromExpression(IExpression expression)
        {
            return new PrintArgument(null, expression);
        }

        public string ToString(Interpreter interpreter)
        {
            if (Text != null)
            {
                return Text;
            }
            
            return Expression.Calculate(interpreter).ToString();
        }
    }
}
