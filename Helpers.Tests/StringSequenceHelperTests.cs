using NUnit.Framework;
using StringHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Helpers.Tests
{
    public class StringSequenceHelperTests
    {
        [Test]
        public void FindMaxSequenceForEveryWord_StringIsNull_ThrowsArgumentNullException()
        {
            // Arrange
            string incomingString = null;

            // Assertion 
            Assert.Throws<ArgumentNullException>(() => StringSequenceHelper.FindMaxSequenceForEveryWord(incomingString));
        }

        [NUnit.Framework.Theory]
        [InlineData("Carramba doom EeefeeTttstt")]
        public void FindMaxSequenceForEveryWord_StrinIsNotNull_ReturnsListOfSequenceData(string incomingString)
        {
            // Arrange
            //var sequenceData = new SequenceData { Character = "r", Count = 2};
            var expectedResult = new List<SequenceData> { new SequenceData("r", 2), new SequenceData("o", 2), new SequenceData("e", 2) };
            var incomingString = "Carramba doom EeefeeTttstt";

            // Act
            var actualResult = StringSequenceHelper.FindMaxSequenceForEveryWord(incomingString);

            

            // Assertion
            Assert.True(Enumerable.SequenceEqual(expectedResult, actualResult));
        }
    }
}