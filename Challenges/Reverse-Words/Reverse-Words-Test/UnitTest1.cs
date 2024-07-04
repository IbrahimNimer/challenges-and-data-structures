using Xunit;
using StringUtilities;
using Reverse_Words;

namespace StringUtilities.Tests
{
    public class StringHelperTests
    {
        [Fact]
        public void TestReverseWords_1()
        {
            // Arrange
            string input = "csharp is programming language";
            string expected = "language programming is csharp";

            // Act
            string actual = ReversedWord.ReverseWords(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestReverseWords_2()
        {
            // Arrange
            string input = "Reverse the words in this sentence";
            string expected = "sentence this in words the Reverse";

            // Act
            string actual = ReversedWord.ReverseWords(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestReverseWords_3()
        {
            // Arrange
            string input = "challenges and data structures";
            string expected = "structures data and challenges";

            // Act
            string actual = ReversedWord.ReverseWords(input);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
