using Business.Requests.Customers;
using Business.Responses.Customers;

namespace Business.Abstract;

public interface ICustomersService
{
    public AddCustomersResponse Add(AddCustomersRequest request);

    public GetCustomersListResponse GetList(GetCustomersListRequest request);
}
