using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;

namespace Business.BusinessRules;

public class IndividualCustomerBusinessRules
{
    private readonly IIndividualCustomerDal _IndividualCustomerDal;

    public IndividualCustomerBusinessRules(IIndividualCustomerDal IndividualCustomerDal)
    {
        _IndividualCustomerDal = IndividualCustomerDal;
    }

    public void CheckIfIndividualCustomerNameNotExists(string IndividualCustomerName)
    {
        bool isExists = _IndividualCustomerDal.GetList().Any(b => b.FirstName == IndividualCustomerName);
        if (isExists)
        {
            throw new BusinessException("IndividualCustomeralready exists.");
        }
    }
}
