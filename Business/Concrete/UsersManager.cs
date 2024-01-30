using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Requests.Users;
using Business.Responses.Users;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class UsersManager : IUsersService
{
    private readonly IUsersDal _UsersDal;
    private readonly UsersBusinessRules _UsersBusinessRules;
    private readonly IMapper _mapper;

    public UsersManager(IUsersDal UsersDal, UsersBusinessRules UsersBusinessRules, IMapper mapper)
    {
        _UsersDal = UsersDal;
        _UsersBusinessRules = UsersBusinessRules;
        _mapper = mapper;
    }

    public AddUsersResponse Add(AddUsersRequest request)
    {
        
        Users UsersToAdd = _mapper.Map<Users>(request); 

        _UsersDal.Add(UsersToAdd);

        AddUsersResponse response = _mapper.Map<AddUsersResponse>(UsersToAdd);
        return response;
    }

    public GetUsersListResponse GetList(GetUsersListRequest request)
    {

        IList<Users> UsersList = _UsersDal.GetList();
    


        GetUsersListResponse response = _mapper.Map<GetUsersListResponse>(UsersList); 
        return response;
    }
}
