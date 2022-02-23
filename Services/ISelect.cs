namespace RockPaperScissors.Services;

public interface ISelect
{
    public enum Choice
    {
        Rock,
        Paper,
        Scissors
    }

    public Choice Select();
}