namespace RockPaperScissors.Services;

internal class ConsoleChoice : ISelect
{
    public ISelect.Choice GetVal()
    {
        Console.Clear();
        Console.WriteLine("Enter 1 for Rock, 2 for Paper, 3 for Scissors.");

        while (true)
        {
            Console.Write("Enter Choice: ");

            if (int.TryParse(Console.ReadLine(), out var choice))
            {
                if (choice is >= 1 and <= 3) return (ISelect.Choice)choice;
                Console.WriteLine("Invalid entry, 1, 2 or 3");
            }
            else
            {
                Console.WriteLine("That is not a number.");
            }
        }
    }
}
