using NUnit.Framework;

namespace Blinkenlights.Basic.Tests.Statements
{
    [TestFixture]
    public class EndStatementTests
    {
        [Test]
        public void EndStopsExecutionOfARunningApplication()
        {
            var interpreter = @"
                10 LET X=0
                20 END
                30 LET X=1
            ".Execute();

            Assert.That(interpreter.Finished, Is.True);
            Assert.That(interpreter.ReadVariable("X"), Is.EqualTo(0));
        }

        [Test]
        public void EndIsImplicitAfterLastStatement()
        {
            var interpreter = @"
                10 LET X=123
            ".ExecuteWithError(out var error);

            Assert.That(interpreter.Finished, Is.True);
            Assert.That(interpreter.ReadVariable("X"), Is.EqualTo(123));
            Assert.That(error.Length, Is.Zero);
        }
    }
}
