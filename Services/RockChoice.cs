namespace RockPaperScissors.Services;

internal class RockChoice : ISelect
{
    public ISelect.Choice GetVal()
    {
        return ISelect.Choice.Rock;
    }
}
