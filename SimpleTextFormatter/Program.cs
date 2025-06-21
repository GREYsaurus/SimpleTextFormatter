namespace SimpleTextFormatter;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input a string to format:");
        string input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("No input provided.");
            return;
        }
        var uppercaseInput = input.ToUpper();
        var reversedInput = input.Reverse();
        var replacedInput = input.Replace(" ", "_");

        Console.WriteLine($"Your input was : {input}");
        Console.WriteLine($"Uppercase: {uppercaseInput}");
        Console.WriteLine($"Reversed: {new string(reversedInput.ToArray())}");
        Console.WriteLine($"Replaced spaces with underscores: {replacedInput}");
        Console.WriteLine("Press any key to exit...");
    }
}