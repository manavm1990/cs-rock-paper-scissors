namespace RockPaperScissors.Services;

internal class ScissorsChoice : ISelect
{
    public ISelect.Choice Select()
    {
        return ISelect.Choice.Scissors;
    }
}