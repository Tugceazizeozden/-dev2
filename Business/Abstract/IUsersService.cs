using Business.Requests.Users;
using Business.Responses.Users;

namespace Business.Abstract;

public interface IUsersService
{
    public AddUsersResponse Add(AddUsersRequest request);

    public GetUsersListResponse GetList(GetUsersListRequest request);
}
