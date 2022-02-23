namespace RockPaperScissors.Services;

internal class RockChoice : ISelect
{
    public ISelect.Choice Select()
    {
        return ISelect.Choice.Rock;
    }
}