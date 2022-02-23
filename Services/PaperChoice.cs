namespace RockPaperScissors.Services;

internal class PaperChoice : ISelect
{
    public ISelect.Choice Select()
    {
        return ISelect.Choice.Paper;
    }
}