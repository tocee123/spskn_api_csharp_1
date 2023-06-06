using FluentAssertions;

namespace ConsoleApplication.Tests
{
    public class WordScrabbleTests
    {
        [Theory]
        [InlineData("G�za sz�p az �g", "az�G p�zs za g�")]
        public void ReverseOnlyWords_WhenSentenceIsGiven_ReturnsExpected(string input, string expected)
        {
            WordScrabble.ReverseOnlyLetters(input).Should().Be(expected);
        }

        [Theory]
        [InlineData("G�za sz�p az �g", "�g az sz�p G�za")]
        public void Test1ReverseOnlyWords_WhenSentenceIsGiven_ReturnsExpected(string input, string expected)
        {
            WordScrabble.ReverseOnlyLetters(input).Should().Be(expected);
        }
    }
}