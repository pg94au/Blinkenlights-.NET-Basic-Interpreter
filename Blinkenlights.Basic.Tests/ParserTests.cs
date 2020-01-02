using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Blinkenlights.Basic.Tests
{
    [TestFixture]
    public class ParserTests
    {
        [Test]
        public void AllIntegersFromZeroUpToButNotIncludingMaxAreValidLineNumbers()
        {
            var interpreter = $@"
                0 LET A = 123
                10 LET B = 234
                {int.MaxValue-1} LET C = 345
            ".Execute();

            Assert.That(interpreter.ReadVariable("A"), Is.EqualTo(123));
            Assert.That(interpreter.ReadVariable("B"), Is.EqualTo(234));
            Assert.That(interpreter.ReadVariable("C"), Is.EqualTo(345));
        }

        [Test]
        public void UnknownStatementsFailWhileParsing()
        {
            var interpreter = @"
                10 LET X = 123
                20 BLAH
            ".ExecuteWithError(out var error);

            StringAssert.Contains("BLAH", error);
        }
    }
}
