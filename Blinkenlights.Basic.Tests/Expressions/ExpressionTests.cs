using System;
using System.Collections.Generic;
using System.Text;
using Blinkenlights.Basic.Tests.Statements;
using NUnit.Framework;

namespace Blinkenlights.Basic.Tests.Expressions
{
    [TestFixture]
    public class ExpressionTests
    {
        [Test]
        [TestCase("1 + 2", 3)]
        [TestCase("3 - 1", 2)]
        [TestCase("2 * 3", 6)]
        [TestCase("6 / 2", 3)]
        [TestCase("3 * 1 + 2", 5)]
        [TestCase("3 * (1 + 2)", 9)]
        [TestCase("1 + 2 * 3", 7)]
        [TestCase("(1 + 2) * 3", 9)]
        public void ExpressionsEvaluateAsExpected(string expression, int expectedResult)
        {
            var interpreter = $@"
                10 LET X = {expression}
            ".Execute();

            Assert.That(interpreter.ReadVariable("X"), Is.EqualTo(expectedResult));
        }
    }
}
