namespace PrisonersProblem.Models;

public class TheBestSolving : IPrisonersProblemSolving
{
    public ProblemBody ProblemBody { get; init; }

    public TheBestSolving() : base()
    {
        ProblemBody = new ProblemBody();
    }

    /// <summary>
    /// Simulates the search for his number by each prisoner
    /// </summary>
    /// <param name="prisonerNumber"></param>
    /// <returns>The success of individual number lookups for specific inmates</returns>
    public bool GetSearchSuccessValue(int prisonerNumber)
    {
        int searchNumber = prisonerNumber;
        int numberInBox = default;
        
        for (int i = 0; i < 50; i++)
        {
            numberInBox = ProblemBody.Boxes[searchNumber];
            
            if (numberInBox.Equals(searchNumber)) return true;
            searchNumber = numberInBox;
        }

        return false;
    }
}