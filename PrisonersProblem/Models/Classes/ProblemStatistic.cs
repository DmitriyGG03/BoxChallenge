namespace PrisonersProblem.Models;

public class ChallengeStatistic
{
    public int WinNumber { get; set; }
    public int LoseNumber { get; set; }
    public int TotalNumber { get => WinNumber + LoseNumber; }
    public int WinsPercentage { get => WinNumber / TotalNumber * 100; }

    public string GetString()
    {
        return $"Перемоги: {WinNumber};\nПоразки: {LoseNumber};\n" +
               $"Всього випробувань: {TotalNumber};\nВідсоток перемог: {WinsPercentage}.\n";
    }
}