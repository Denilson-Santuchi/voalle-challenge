namespace DiamondConsole;

public static class Alphabet
{
    private static readonly string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-8.0/ranges
    public static string Slice(char letter)
    {
        var index = alphabet.IndexOf(letter);
        var slicedAlpha = alphabet[..(index + 1)];

        return slicedAlpha;
    }

    public static string Reverse(string alphabet)
    {
        char[] slicedAlpha = alphabet.ToCharArray();
        Array.Reverse(slicedAlpha);
        return new string(slicedAlpha);
    }
}
