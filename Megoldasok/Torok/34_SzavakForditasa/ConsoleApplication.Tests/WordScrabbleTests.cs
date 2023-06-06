using FluentAssertions;

namespace ConsoleApplication.Tests
{
    public class WordScrabbleTests
    {
        [Theory]
        [InlineData("G�za sz�p az �g", "az�G p�zs za g�")]
        public void Test1ReverseOnlyWords_WhenSentenceIsGiven_ReturnsExpected(string input, string expected)
        {
            WordScrabble.ReverseOnlyWords(input).Should().Be(expected);
        }
    }
}