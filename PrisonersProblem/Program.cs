using PrisonersProblem.Models;


StatisticСollector statisticСollector = new StatisticСollector(new TheBestSolving());

string result = statisticСollector.CollectStatistic(1000000);

Console.WriteLine(result);

Console.ReadKey();