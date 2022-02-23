namespace RockPaperScissors.Services;

internal class RandChoice : ISelect
{
    public ISelect.Choice Select()
    {
        return (ISelect.Choice) new Random().Next(1, 4);
    }
}