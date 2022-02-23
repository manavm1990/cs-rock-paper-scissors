namespace RockPaperScissors;

internal static class Program
{
    private static void Main(string[] args)
    {
        var p1Choice = ConsoleIo.Select("1").GetVal();
        var p2Choice = ConsoleIo.Select("2").GetVal();

        var game = new Startup(p1Choice, p2Choice);
        game.Run();
    }
}
