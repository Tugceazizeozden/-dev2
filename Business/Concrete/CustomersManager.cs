using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Requests.Customers;
using Business.Responses.Customers;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class CustomersManager : ICustomersService
{
    private readonly ICustomersDal _CustomersDal;
    private readonly CustomersBusinessRules _CustomersBusinessRules;
    private readonly IMapper _mapper;

    public CustomersManager(ICustomersDal CustomersDal, CustomersBusinessRules CustomersBusinessRules, IMapper mapper)
    {
        _CustomersDal = CustomersDal;
        _CustomersBusinessRules = CustomersBusinessRules;
        _mapper = mapper;
    }

    public AddCustomersResponse Add(AddCustomersRequest request)
    {
        
        Customers CustomersToAdd = _mapper.Map<Customers>(request); 

        _CustomersDal.Add(CustomersToAdd);

        AddCustomersResponse response = _mapper.Map<AddCustomersResponse>(CustomersToAdd);
        return response;
    }

    public GetCustomersListResponse GetList(GetCustomersListRequest request)
    {

        IList<Customers> CustomersList = _CustomersDal.GetList();
    


        GetCustomersListResponse response = _mapper.Map<GetCustomersListResponse>(CustomersList); 
        return response;
    }
}
