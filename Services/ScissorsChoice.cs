namespace RockPaperScissors.Services;

internal class ScissorsChoice : ISelect
{
    public ISelect.Choice GetVal()
    {
        return ISelect.Choice.Scissors;
    }
}
