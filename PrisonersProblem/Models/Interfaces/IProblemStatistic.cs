namespace PrisonersProblem.Models;

public interface IProblemStatistic
{
    public int WinNumber { get; set; }
    public int LoseNumber { get; set; }
    public int TotalNumber { get => WinNumber + LoseNumber; }
    public double WinsPercentage { get => WinNumber / TotalNumber * 100; }

    public string ToString();
}