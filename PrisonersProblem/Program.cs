using PrisonersProblem.Models;

StatisticСollector statisticСollector = new StatisticСollector(new TheBestSolving());

string result = statisticСollector.CollectStatistic(100);

Console.WriteLine(result);