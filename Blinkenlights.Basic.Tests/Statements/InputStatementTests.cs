using System;
using System.IO;
using NUnit.Framework;

namespace Blinkenlights.Basic.Tests.Statements
{
    [TestFixture]
    public class InputStatementTests
    {
        [Test]
        public void CanInputAValueFromInputStreamAndStoreInAVariable()
        {
            var inputReader = new StringReader("123");

            var interpreter = @"
                10 INPUT X
            ".ExecuteWithInputReader(inputReader);

            Assert.That(interpreter.ReadVariable("X"), Is.EqualTo(123));
        }

        [Test]
        public void CanCallInputMoreThanOnce()
        {
            var inputReader = new StringReader($"123{Environment.NewLine}234");

            var interpreter = @"
                10 INPUT X
                20 INPUT Y
            ".ExecuteWithInputReader(inputReader);

            Assert.That(interpreter.ReadVariable("X"), Is.EqualTo(123));
            Assert.That(interpreter.ReadVariable("Y"), Is.EqualTo(234));
        }
    }
}
