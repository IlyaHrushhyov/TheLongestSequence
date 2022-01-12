using FluentAssertions;
using Helpers;
using StringHelper;
using Xunit;

namespace SequenceHelperTests
{
    public class StringSequenceHelperTests
    {
        [Fact]
        public void FindMaxSequenceForEveryWord_StringIsNull_ThrowsArgumentNullException()
        {
            // Arrange
            string incomingString = null;

            // Act
            Action act = () => StringSequenceHelper.FindMaxSequenceForEveryWord(incomingString);

            // Assertion 
            act.Should().Throw<ArgumentNullException>().WithMessage($"Value cannot be null. (Parameter '{nameof(incomingString)}')");
        }

        [Fact]
        public void FindMaxSequenceForEveryWord_StrinIsNotNull_ReturnsListOfSequenceData()
        {
            // Arrange
            var expectedResult = new List<SequenceData> { new SequenceData("r", 2), new SequenceData("o", 2), new SequenceData("e", 2) };
            var incomingString = "Carramba doom EeefeeTttstt";

            // Act
            var actualResult = StringSequenceHelper.FindMaxSequenceForEveryWord(incomingString);

            // Assertion
            actualResult.Should().BeEquivalentTo(expectedResult);
        }
    }
}