namespace BoxChallenge.Models;

public interface IChallengeStatistic
{
    public int WinNumber { get; set; }
    public int LoseNumber { get; set; }
    public int TotalNumber { get => WinNumber + LoseNumber; }
    public int WinsPercentage { get => WinNumber / TotalNumber * 100; }
}