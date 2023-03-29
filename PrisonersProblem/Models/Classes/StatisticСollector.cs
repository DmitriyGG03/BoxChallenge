namespace PrisonersProblem.Models;

public class StatisticСollector : IStatisticСollector<IPrisonersProblemSolving>
{
    public IPrisonersProblemSolving Problem { get; set; }
    public ProblemStatistic Statistic { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="solving">Solving the problem that will be tested</param>
    /// <param name="statistic"></param>
    public StatisticСollector(IPrisonersProblemSolving solving, IProblemStatistic statistic)
    {
        
    }
    
}