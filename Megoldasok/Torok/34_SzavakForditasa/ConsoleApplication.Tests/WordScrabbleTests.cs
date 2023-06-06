using FluentAssertions;

namespace ConsoleApplication.Tests
{
    public class WordScrabbleTests
    {
        [Theory]
        [InlineData(null, null)]
        [InlineData("","")]
        [InlineData("G�za sz�p az �g", "az�G p�zs za g�")]
        public void ReverseOnlyLetters_WhenSentenceIsGiven_ReturnsExpected(string input, string expected)
        {
            WordScrabble.ReverseOnlyLetters(input).Should().Be(expected);
        }

        [Theory]
        [InlineData(null, null)]
        [InlineData("", "")]
        [InlineData("G�za sz�p az �g", "�g az sz�p G�za")]
        public void ReverseOnlyWords_WhenSentenceIsGiven_ReturnsExpected(string input, string expected)
        {
            WordScrabble.ReverseOnlyWords(input).Should().Be(expected);
        }

        [Theory]
        [InlineData(null, null)]
        [InlineData("", "")]
        [InlineData("G�za sz�p az �g", "g� za p�zs az�G")]
        public void ReverseWordsAndLetters_WhenSentenceIsGiven_ReturnsExpected(string input, string expected)
        {
            WordScrabble.ReverseWordsAndLetters(input).Should().Be(expected);
        }
    }
}