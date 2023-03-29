namespace PrisonersProblem.Models;

public interface IStatisticСollector
{
    public IPrisonersProblemSolving ProblemSolution { get; set; }
    public ProblemStatistic Statistic { get; set; }

    public string CollectStatistic(int testNumber);
}