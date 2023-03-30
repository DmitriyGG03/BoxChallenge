namespace PrisonersProblem.Models;

public class ProblemStatistic : IProblemStatistic
{
    public int WinNumber { get; set; } = 0;
    public int LoseNumber { get; set; } = 0;
    public int TotalNumber { get => WinNumber + LoseNumber; }
    public double WinsPercentage { get => (double)WinNumber / (double)TotalNumber * 100.0; }

    public new string ToString()
    {
        return $"Перемоги: {WinNumber} - {WinsPercentage}%;" +
               $"\nПоразки: {LoseNumber} - {100 - WinsPercentage}%;\n" +
               $"Всього випробувань: {TotalNumber}.";
    }
}