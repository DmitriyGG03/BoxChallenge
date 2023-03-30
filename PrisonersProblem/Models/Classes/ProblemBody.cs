using System.Diagnostics;
using System.Net.Mime;

namespace PrisonersProblem.Models;

public class ProblemBody : IProblemBody
{
    public List<int> Drawers { get; set; }

    public ProblemBody()
    {
        Drawers = new List<int>(0);

        FillTheDrawers();
    }

    private void FillTheDrawers()
    {
        Stopwatch tw = new Stopwatch();
        if (Debugger.IsAttached) tw.Start();

        Random rnd = new Random();

        for (int i = 0; i < 100; i++)
        {
            int genNumber = rnd.Next(0, 100);
            if (!Drawers.Contains(genNumber)) Drawers.Add(genNumber);
            else i--;
        }

        if (Debugger.IsAttached)
        {
            tw.Stop();
            using (StreamWriter streamWriter = new StreamWriter("DBGStatistic.txt", true))
            {
                streamWriter.WriteAsync($"{tw.Elapsed.Nanoseconds} ");
            }
        }

        if (Debugger.IsAttached) PrintTable();
        // MixNumberInList();
        // if (Debugger.IsAttached) PrintTable();
    }

    private void PrintTable()
    {
        for (int i = 0, j = 0; i + j < 100; j++)
        {
            if (j == 10)
            {
                Console.Write("\n");
                j = -1;
                i += 10;
            }
            else
            {
                Console.Write(string.Format("{0:D1}\t", Drawers[i + j]));
            }
        }

        Console.Write("\n");
    }

    private void MixNumberInList()
    {
        Random random = new Random();
        for (int i = Drawers.Count - 1; i >= 1; i--)
        {
            int j = random.Next(i + 1);

            // Swap Boxes[j] & Boxes[i]
            var temp = Drawers[j];
            Drawers[j] = Drawers[i];
            Drawers[i] = temp;
        }
    }
}