using NUnit.Framework;

namespace Blinkenlights.Basic.Tests.Statements
{
    [TestFixture]
    public class LetStatementTests
    {
        [Test]
        public void CanSetLiteralNumberValueToVariable()
        {
            var interpreter = @"
                10 LET X = 123
            ".Execute();

            Assert.That(interpreter.ReadVariable("X"), Is.EqualTo(123));
        }

        [Test]
        public void CanReAssignANewValueToAVariable()
        {
            var interpreter = @"
                10 LET X = 123
                20 LET X = 234
            ".Execute();

            Assert.That(interpreter.ReadVariable("X"), Is.EqualTo(234));
        }

        [Test]
        public void CanAssignResultOfAnExpressionToAVariable()
        {
            var interpreter = @"
                10 LET X = 12 + 23
            ".Execute();

            Assert.That(interpreter.ReadVariable("X"), Is.EqualTo(35));
        }

        [Test]
        public void CanAssignOneVariableToAnother()
        {
            var interpreter = @"
                10 LET X = 123
                20 LET Y = X
            ".Execute();

            Assert.That(interpreter.ReadVariable("Y"), Is.EqualTo(123));
        }
    }
}
