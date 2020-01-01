using NUnit.Framework;

namespace Blinkenlights.Basic.Tests
{
    [TestFixture]
    public class IfStatementTests
    {
        [Test]
        [TestCase("123 == 123", true)]
        [TestCase("X + 50 == (50 * 3) * 2", true)]
        [TestCase("123 == 321", false)]
        [TestCase("123 != 321", true)]
        [TestCase("123 != 123", false)]
        [TestCase("321 > 123", true)]
        [TestCase("123 > 321", false)]
        [TestCase("123 < 321", true)]
        [TestCase("321 < 123", false)]
        [TestCase("321 >= 123", true)]
        [TestCase("123 >= 123", true)]
        [TestCase("123 >= 321", false)]
        [TestCase("123 <= 321", true)]
        [TestCase("123 <= 123", true)]
        [TestCase("321 <= 123", false)]
        public void BranchesAsAppropriate(string expression, bool shouldBranch)
        {
            var interpreter = $@"
                10 LET X = 250
                20 IF {expression} THEN 40
                30 LET X=500
                40 END
            ".Execute();

            Assert.That(interpreter.ReadVariable("X"), Is.EqualTo(shouldBranch ? 250 : 500));
        }
    }
}
