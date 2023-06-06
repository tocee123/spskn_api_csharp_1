using FluentAssertions;

namespace ConsoleApplication.Tests
{
    public class WordScrabbleTests
    {
        [Theory]
        [InlineData(null, null)]
        [InlineData("","")]
        [InlineData("Géza szép az ég", "azéG pézs za gé")]
        public void ReverseOnlyLetters_WhenSentenceIsGiven_ReturnsExpected(string input, string expected)
        {
            WordScrabble.ReverseOnlyLetters(input).Should().Be(expected);
        }

        [Theory]
        [InlineData(null, null)]
        [InlineData("", "")]
        [InlineData("Géza szép az ég", "ég az szép Géza")]
        public void ReverseOnlyWords_WhenSentenceIsGiven_ReturnsExpected(string input, string expected)
        {
            WordScrabble.ReverseOnlyWords(input).Should().Be(expected);
        }

        [Theory]
        [InlineData(null, null)]
        [InlineData("", "")]
        [InlineData("Géza szép az ég", "gé za pézs azéG")]
        public void ReverseWordsAndLetters_WhenSentenceIsGiven_ReturnsExpected(string input, string expected)
        {
            WordScrabble.ReverseWordsAndLetters(input).Should().Be(expected);
        }
    }
}