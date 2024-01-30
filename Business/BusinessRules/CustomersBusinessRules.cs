using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;

namespace Business.BusinessRules;

public class CustomersBusinessRules
{
    private readonly ICustomersDal _CustomersDal;

    public CustomersBusinessRules(ICustomersDal CustomersDal)
    {
        _CustomersDal = CustomersDal;
    }

    public void CheckIfCustomersNameNotExists(string CustomersName)
    {
        bool isExists = _CustomersDal.GetList().Any(b => b.UserId == CustomersName);
        if (isExists)
        {
            throw new BusinessException("Customers already exists.");
        }
    }
}
