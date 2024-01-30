using Business;
using Business.Abstract;
using Business.Requests;
using Business.Requests.Customers;
using Business.Responses;
using Business.Responses.Customers;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomerssController : ControllerBase
{
    private readonly ICustomersService _CustomersService; 

    public CustomerssController(ICustomersService CustomersService)
    {
        _CustomersService = CustomersService;
    }

    
    

    [HttpGet]  
    public GetCustomersListResponse GetList([FromQuery] GetCustomersListRequest request) 
    {
        GetCustomersListResponse response = _CustomersService.GetList(request);
        return response;
    }

    [HttpPost]  
    public ActionResult<AddCustomersResponse> Add(AddCustomersRequest request)
    {
        try
        {
            AddCustomersResponse response = _CustomersService.Add(request);

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
