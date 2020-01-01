using NUnit.Framework;

namespace Blinkenlights.Basic.Tests
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

            Assert.That(interpreter.ReadVariable("X"), Is.EqualTo(0));
        }
    }
}
