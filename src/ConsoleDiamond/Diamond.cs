using System.Text;

namespace DiamondConsole;

public static class Diamond
{
    public static string Create(char character)
    {
        var myStringBuilder = new StringBuilder("");
        // https://learn.microsoft.com/pt-br/dotnet/standard/base-types/stringbuilder

        var alphabet = Alphabet.Slice(character);
        var alphaInverted = Alphabet.Reverse(alphabet)[1..^1];

        int lenght = alphabet.Length;
        myStringBuilder.Append("A".PadLeft(lenght + 1) + "\n");
        myStringBuilder.Append("B".PadLeft(lenght - 1) + "   B\n");

        var alphaSliced = alphabet[2..];
        foreach (var (c, i) in alphaSliced.Select((c, i) => (c.ToString(), i)))
        {
            var left = alphaSliced.Length - i;
            var spaces = 6; // min 4
            var middle = spaces + (2 * i);

            myStringBuilder.Append(c.PadLeft(left) + c.PadLeft(middle) + "\n");
        }

        foreach (var (c, i) in alphaInverted.Select((c, i) => (c.ToString(), i)))
        {
            var left = 2 + i;
            var spaces = 2; //min 0
            var middle = (alphaInverted.Length - i) * 2 + spaces;

            myStringBuilder.Append(c.PadLeft(left) + c.PadLeft(middle) + "\n");
        }
        myStringBuilder.Append("A".PadLeft(lenght + 1));

        return myStringBuilder.ToString();
    }
}
