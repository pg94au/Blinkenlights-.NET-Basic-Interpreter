using NUnit.Framework;

namespace Blinkenlights.Basic.Tests
{
    [TestFixture]
    public class GosubAndReturnStatementTests
    {
        [Test]
        public void CanGoToAnotherLineAndThenReturn()
        {
            var interpreter = @"
                10 LET X=250
                20 GOSUB 40
                30 END
                40 LET X=500
                50 RETURN
            ".Execute();

            Assert.That(interpreter.ReadVariable("X"), Is.EqualTo(500));
        }

        [Test]
        public void CallingToNonExistentLineStopsExecutionAndPrintsAnError()
        {
            var interpreter = @"
                10 LET X = 1
                20 GOSUB 50
                30 LET X = 123
                40 END
            ".ExecuteWithError(out var errorOutput);

            Assert.That(interpreter.ReadVariable("X"), Is.EqualTo(1));
            Assert.That(errorOutput.Length, Is.GreaterThan(0));
        }

        [Test]
        public void ReturnWithoutGosubStopsExecutionAndPrintsAnError()
        {
            var interpreter = @"
                10 LET X = 1
                20 RETURN
                30 LET X = 123
                40 END
            ".ExecuteWithError(out var errorOutput);

            Assert.That(interpreter.ReadVariable("X"), Is.EqualTo(1));
            Assert.That(errorOutput.Length, Is.GreaterThan(0));
        }
    }
}
