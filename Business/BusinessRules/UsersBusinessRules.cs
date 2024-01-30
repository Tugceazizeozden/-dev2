using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;

namespace Business.BusinessRules;

public class UsersBusinessRules
{
    private readonly IUsersDal _UsersDal;

    public UsersBusinessRules(IUsersDal UsersDal)
    {
        _UsersDal = UsersDal;
    }

    public void CheckIfUsersNameNotExists(string UsersName)
    {
        bool isExists = _UsersDal.GetList().Any(b => b.FirstName == UsersName);
        if (isExists)
        {
            throw new BusinessException("Users already exists.");
        }
    }
}
