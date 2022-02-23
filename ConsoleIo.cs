using RockPaperScissors.Services;

namespace RockPaperScissors;

internal class ConsoleIo
{
    internal static ISelect Select(string playerNumber)
    {
        Console.Clear();
        Console.WriteLine($"Player {playerNumber}: Choose your destiny (1-5)! 🤜🏾");
        Console.WriteLine(@"1. Random Picker
2. Console Picker
3. Always Rock
4. Always Paper
5. Always Scissors
");

        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out var value))
            {
                switch (value)
                {
                    case 1:
                        return new RandChoice();
                    case 2:
                        return new ConsoleChoice();
                    case 3:
                        return new RockChoice();
                    case 4:
                        return new PaperChoice();
                    case 5:
                        return new ScissorsChoice();
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Choice must be a number from 1-5❗");
            }
        }
    }
}
