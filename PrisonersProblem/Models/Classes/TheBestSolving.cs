namespace PrisonersProblem.Models;

public class TheBestSolving : IPrisonersProblemSolving
{
    public static ProblemBody ProblemBody { get; set; }
    public TheBestSolving() : base() 
    { }

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
            numberInBox = ProblemBody.Drawers[searchNumber];
            
            if (numberInBox.Equals(prisonerNumber)) return true;
            searchNumber = numberInBox;
        }

        return false;
    }
}