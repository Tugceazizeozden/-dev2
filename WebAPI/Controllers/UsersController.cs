using Business;
using Business.Abstract;
using Business.Concrete;
using Business.Requests.Users;
using Business.Responses.Users;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserssController : ControllerBase
{
    private readonly IUsersService _UsersService; 

    public UserssController(IUsersService UsersService)
    {
        _UsersService = UsersService;
    }

    
    

    [HttpGet]  
    public GetUsersListResponse GetList([FromQuery] GetUsersListRequest request) 
    {
        GetUsersListResponse response = _UsersService.GetList(request);
        return response;
    }

    [HttpPost]  
    public ActionResult<AddUsersResponse> Add(AddUsersRequest request)
    {
        try
        {
            AddUsersResponse response = _UsersService.Add(request);

            return CreatedAtAction(nameof(GetList), response); 
        }
        catch (Core.CrossCuttingConcerns.Exceptions.BusinessException exception)
        {
            return BadRequest(
                new Core.CrossCuttingConcerns.Exceptions.BusinessProblemDetails()
                {
                    Title = "Business Exception",
                    Status = StatusCodes.Status400BadRequest,
                    Detail = exception.Message,
                    Instance = HttpContext.Request.Path
                }
            );
        }
    }
}
