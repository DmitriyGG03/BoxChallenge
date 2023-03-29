namespace PrisonersProblem.Models;

public interface IPrisonersProblemSolving
{
    public const int PrisonersNumber = 100;
    public bool StartChallenge()
    {
        for (int i = 0; i < PrisonersNumber; i++)
        {
            if (!GetSearchSuccessValue(i + 1)) return false;
        }
        return true;
    }

    public bool GetSearchSuccessValue(int prisonerNumber);
}