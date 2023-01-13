namespace DiamondConsole;

public class Program
{
    private char _letter;

    public static void Main()
    {
        var Program = new Program();
        Program.Game();

        var diamond = Diamond.Create(Program._letter);
        Console.Write($"\n{diamond}\n");

        Email.Message();
    }

    private void Game()
    {
        Console.WriteLine("Hello player!");
        Console.WriteLine("choose a letter to draw a diamond:");

        var choicedLetter = Console.ReadLine();

        // https://learn.microsoft.com/pt-br/dotnet/api/system.char.tryparse?view=net-7.0
        bool verifyChar = char.TryParse(choicedLetter, out char letter);
        char upperChar = letter.ToString().ToUpper().ToCharArray()[0];

        while (upperChar == 'A' || upperChar == 'B' || !verifyChar || !char.IsLetter(upperChar))
        {
            Console.WriteLine("Error, allowed only letters between c to z:");

            choicedLetter = Console.ReadLine();
            verifyChar = char.TryParse(choicedLetter, out letter);
            upperChar = letter.ToString().ToUpper().ToCharArray()[0];
        }

        _letter = char.ToUpper(letter);
    }
}
