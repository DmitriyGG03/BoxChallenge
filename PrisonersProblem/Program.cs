using System.Diagnostics;
using PrisonersProblem.Models;

if (Debugger.IsAttached) using (StreamWriter writer = new StreamWriter("DBGStatistic.txt", false)) ;

StatisticСollector statisticСollector = new StatisticСollector(new TheBestSolving());

string result = statisticСollector.CollectStatistic(1000);

Console.WriteLine(result);

if (Debugger.IsAttached) Console.WriteLine($"\nСреднее значение задержки: {statisticСollector.GetDBGStatistic()}");

Console.ReadKey();