using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Requests.IndividualCustomer;
using Business.Requests.IndividualCustomer;
using Business.Responses.IndividualCustomer;
using Business.Responses.Users;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class IndividualCustomerManager : IIndividualCustomerService
{
    private readonly IIndividualCustomerDal _IndividualCustomerDal;
    private readonly IndividualCustomerBusinessRules _IndividualCustomerBusinessRules;
    private readonly IMapper _mapper;

    public IndividualCustomerManager(IIndividualCustomerDal IndividualCustomerDal, IndividualCustomerBusinessRules IndividualCustomerBusinessRules, IMapper mapper)
    {
        _IndividualCustomerDal = IndividualCustomerDal;
        _IndividualCustomerBusinessRules = IndividualCustomerBusinessRules;
        _mapper = mapper;
    }

    public AddIndividualCustomerResponse Add(AddIndividualCustomerRequest request)
    {

        IndividualCustomer IndividualCustomerToAdd = _mapper.Map<IndividualCustomer>(request);

        _IndividualCustomerDal.Add(IndividualCustomerToAdd);

        AddIndividualCustomerResponse response = _mapper.Map<AddIndividualCustomerResponse>(IndividualCustomerToAdd);
        return response;
    }

    public GetIndividualCustomerListResponse GetList(GetIndividualCustomerListRequest request)
    {

        IList<IndividualCustomer> IndividualCustomerList = _IndividualCustomerDal.GetList();



        GetIndividualCustomerListResponse response = _mapper.Map<GetIndividualCustomerListResponse>(IndividualCustomerList); 
        return response;
    }
}
