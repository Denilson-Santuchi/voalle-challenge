using Xunit;
using FluentAssertions;

namespace DiamondConsole.Test;

public class TestHelpers
{
    [Theory(DisplayName = "Verify if the slice the alphabet")]
    [InlineData('B', "AB")]
    [InlineData('E', "ABCDE")]
    [InlineData('Z', "ABCDEFGHIJKLMNOPQRSTUVWXYZ")]
    public void TestAlphabetSlice(char letter, string expected)
    {
        var result = Alphabet.Slice(letter);

        result.Should().Be(expected);
    }

    [Theory(DisplayName = "Verify if the invert the alphabet")]
    [InlineData("AB", "BA")]
    [InlineData("ABCDE", "EDCBA")]
    [InlineData("ABCDEFGHIJKLMNOPQRSTUVWXYZ", "ZYXWVUTSRQPONMLKJIHGFEDCBA")]
    public void TestAlphabetReverse(string alpha, string expected)
    {
        var result = Alphabet.Reverse(alpha);

        result.Should().Be(expected);
    }
}
