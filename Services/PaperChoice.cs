namespace RockPaperScissors.Services;

internal class PaperChoice : ISelect
{
    public ISelect.Choice GetVal()
    {
        return ISelect.Choice.Paper;
    }
}
