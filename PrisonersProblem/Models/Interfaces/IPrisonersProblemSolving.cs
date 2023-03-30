namespace PrisonersProblem.Models;

public interface IPrisonersProblemSolving
{
    public const int PrisonersNumber = 100;

    public bool StartChallenge()
    {
        TheBestSolving.ProblemBody = new ProblemBody();
        
        for (int i = 0; i < PrisonersNumber; i++)
        {
            //Each of 100 inmates coming in the room
            if (!GetSearchSuccessValue(i)) return false;
        }
        return true;
    }

    public bool GetSearchSuccessValue(int prisonerNumber);
}