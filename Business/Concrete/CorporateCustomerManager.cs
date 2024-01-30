using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Requests.CorporateCustomer;
using Business.Responses.CorporateCustomer;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class CorporateCustomerManager : CorporateCustomer
{
    private readonly ICorporateCustomerDal _CorporateCustomerDal;
    private readonly CorporateCustomerBusinessRules _CorporateCustomerBusinessRules;
    private readonly IMapper _mapper;

    public CorporateCustomerManager(ICorporateCustomerDal CorporateCustomerDal, CorporateCustomerBusinessRules CorporateCustomerBusinessRules, IMapper mapper)
    {
        _CorporateCustomerDal = CorporateCustomerDal;
        _CorporateCustomerBusinessRules = CorporateCustomerBusinessRules;
        _mapper = mapper;
    }

    public AddCorporateCustomerResponse Add(AddCorporateCustomerRequest request)
    {
        
        CorporateCustomer CorporateCustomerToAdd = _mapper.Map<CorporateCustomer>(request); 

        _CorporateCustomerDal.Add(CorporateCustomerToAdd);

        AddCorporateCustomerResponse response = _mapper.Map<AddCorporateCustomerResponse>(CorporateCustomerToAdd);
        return response;
    }

    public GetCorporateCustomerListResponse GetList(GetCorporateCustomerListRequest request)
    {

        IList<CorporateCustomer> CorporateCustomerList = _CorporateCustomerDal.GetList();
    


        GetCorporateCustomerListResponse response = _mapper.Map<GetCorporateCustomerListResponse>(CorporateCustomerList); 
        return response;
    }
}
