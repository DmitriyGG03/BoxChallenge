namespace PrisonersProblem.Models;

public class StatisticСollector : IStatisticСollector
{
    public IPrisonersProblemSolving ProblemSolution { get; set; }
    public ProblemStatistic Statistic { get; set; } = new ProblemStatistic();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="solving">Solving the problem that will be tested</param>
    public StatisticСollector(IPrisonersProblemSolving solving)
    {
        ProblemSolution = solving;
    }
    
    public string CollectStatistic(int testNumber)
    {
        if (testNumber < 1) throw new ArgumentException("The number of tests must be at least 1");

        for (int i = 0; i < testNumber; i++)
        {
            if (ProblemSolution.StartChallenge()) Statistic.WinNumber++;
            else Statistic.LoseNumber++;
        }
        return Statistic.ToString();
    }
}