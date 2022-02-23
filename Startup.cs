using RockPaperScissors.Services;

namespace RockPaperScissors;

internal class Startup
{
    private readonly ISelect.Choice _p1;
    private readonly ISelect.Choice _p2;

    internal Startup(ISelect.Choice p1, ISelect.Choice p2)
    {
        _p1 = p1;
        _p2 = p2;
    }

    internal void Run()
    {
        Console.WriteLine($"Player 1: {_p1} vs Player 2: {_p2}");

        if (_p1 == _p2)
        {
            Console.WriteLine("It's a tie 🪢!");
        }
        else
        {
            switch (_p1)
            {
                case ISelect.Choice.Rock when _p2.Equals(ISelect.Choice.Scissors):
                case ISelect.Choice.Paper when _p2.Equals(ISelect.Choice.Rock):
                case ISelect.Choice.Scissors when _p2.Equals(ISelect.Choice.Paper):
                    Console.WriteLine("Player 1 wins 🏆!");
                    break;
                default:
                    Console.WriteLine("Player 2 wins 🏆!");
                    break;
            }
        }
    }
}
