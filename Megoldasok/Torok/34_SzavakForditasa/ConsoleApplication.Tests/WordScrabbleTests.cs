using FluentAssertions;

namespace ConsoleApplication.Tests
{
    public class WordScrabbleTests
    {
        [Theory]
        [InlineData("Géza szép az ég", "azéG pézs za gé")]
        public void ReverseOnlyWords_WhenSentenceIsGiven_ReturnsExpected(string input, string expected)
        {
            WordScrabble.ReverseOnlyLetters(input).Should().Be(expected);
        }

        [Theory]
        [InlineData("Géza szép az ég", "ég az szép Géza")]
        public void Test1ReverseOnlyWords_WhenSentenceIsGiven_ReturnsExpected(string input, string expected)
        {
            WordScrabble.ReverseOnlyLetters(input).Should().Be(expected);
        }
    }
}