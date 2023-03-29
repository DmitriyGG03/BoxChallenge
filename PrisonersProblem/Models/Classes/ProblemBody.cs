namespace PrisonersProblem.Models;

public class ProblemBody : IProblemBody
{
    public List<int> Boxes { get; set; }

    public ProblemBody()
    {
        Boxes = new List<int>();
        for (int i = 100; i > 0; i--)
        {
            Boxes.Append(i);
        }
        
        //TODO: Random filling boxes
    }
}