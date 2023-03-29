using System.Diagnostics;
using System.Net.Mime;

namespace PrisonersProblem.Models;

public class ProblemBody : IProblemBody
{
    public List<int> Boxes { get; set; }

    public ProblemBody()
    {
        Boxes = new List<int>();
        for (int i = 0; i < 100; i++)
        {
            Boxes.Add(i);
        }

        MixNumberInList();
        if (Debugger.IsAttached) PrintTable();
       
        
        //TODO: Random filling boxes
    }
    
    private void PrintTable()
    {
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                int index = (i - 1) * 10 + j - 1;
                Console.Write(string.Format("{0:D1}\t", Boxes[index]));
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    private void MixNumberInList()
    {
        Random random = new Random();
        for (int i = Boxes.Count - 1; i >= 1; i--)
        {
            int j = random.Next(i + 1);
            
            // Swap Boxes[j] & Boxes[i]
            var temp = Boxes[j];
            Boxes[j] = Boxes[i];
            Boxes[i] = temp;
        }
    }
}