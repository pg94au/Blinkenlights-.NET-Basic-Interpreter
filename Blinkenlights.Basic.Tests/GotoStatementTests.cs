using NUnit.Framework;

namespace Blinkenlights.Basic.Tests
{
    [TestFixture]
    public class GotoStatementTests
    {
        [Test]
        public void CanJumpToAnotherLine()
        {
            var interpreter = @"
                10 LET X=250
                20 GOTO 40
                30 LET X=500
                40 END
            ".Execute();

            Assert.That(interpreter.ReadVariable("X"), Is.EqualTo(250));
        }

        [Test]
        public void JumpingToNonExistentLineStopsExecutionAndPrintsAnError()
        {
            var interpreter = @"
                10 LET X = 1
                20 GOTO 50
                30 LET X = 123
                40 END
            ".ExecuteWithError(out var errorOutput);

            Assert.That(interpreter.ReadVariable("X"), Is.EqualTo(1));
            Assert.That(errorOutput.Length, Is.GreaterThan(0));
        }
    }
}
