﻿using NUnit.Framework;

namespace Blinkenlights.Basic.Tests
{
    [TestFixture]
    public class ForAndNextStatementTests
    {
        [Test]
        public void CanConstructLoopThatRepeatsStatements()
        {
            var interpreter = @"
                10 LET X=0
                20 FOR I = 0 TO 5
                30 LET X = I
                40 NEXT I
                50 END
            ".Execute();

            Assert.That(interpreter.ReadVariable("X"), Is.EqualTo(5));
        }

        [Test]
        public void ALoopWillAlwaysExecuteAtLeastOnce()
        {
            var interpreter = @"
                10 LET X=0
                20 FOR I = 5 TO 5
                30 LET X = I
                40 NEXT I
                50 END
            ".Execute();

            Assert.That(interpreter.ReadVariable("X"), Is.EqualTo(5));
        }

        [Test]
        public void MismatchedNextStatementStopsExecutionAndPrintsError()
        {
            var interpreter = @"
                10 LET X = 1
                20 FOR Y = 1 TO 5
                30 LET X = X + 1
                40 NEXT Z
                50 LET X = 123
                60 END
            ".ExecuteWithError(out var errorOutput);

            Assert.That(interpreter.ReadVariable("X"), Is.EqualTo(2));
            Assert.That(errorOutput.Length, Is.GreaterThan(0));
        }
    }
}
