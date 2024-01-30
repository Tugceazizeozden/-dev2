using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;

namespace Business.BusinessRules;

public class CorporateCustomerBusinessRules
{
    private readonly ICorporateCustomerDal _CorporateCustomerDal;

    public CorporateCustomerBusinessRules(ICorporateCustomerDal CorporateCustomerDal)
    {
        _CorporateCustomerDal = CorporateCustomerDal;
    }

    public void CheckIfCorporateCustomerNameNotExists(string CorporateCustomerName)
    {
        bool isExists = _CorporateCustomerDal.GetList().Any(b => b.CompanyName == CorporateCustomerName);
        if (isExists)
        {
            throw new BusinessException("CorporateCustomer already exists.");
        }
    }
}
