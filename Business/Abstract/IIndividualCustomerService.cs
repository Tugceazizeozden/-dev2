using Business.Requests.IndividualCustomer;
using Business.Responses.Users;

namespace Business.Abstract;

public interface IIndividualCustomerService
{
    public AddIndividualCustomerResponse Add(AddIndividualCustomerRequest request);

    public GetIndividualCustomerListResponse GetList(GetIndividualCustomerListRequest request);
}
