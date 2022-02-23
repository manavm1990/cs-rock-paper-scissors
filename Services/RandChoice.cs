namespace RockPaperScissors.Services;

internal class RandChoice : ISelect
{
    public ISelect.Choice GetVal()
    {
        return (ISelect.Choice)new Random().Next(0, 3);
    }
}
