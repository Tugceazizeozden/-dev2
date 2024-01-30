using Business;
using Business.Abstract;
using Business.Requests.IndividualCustomer;
using Business.Responses.Users;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class IndividualCustomersController : ControllerBase
{
    private readonly IIndividualCustomerService _IndividualCustomerService; 

    public IndividualCustomersController(IIndividualCustomerService IndividualCustomerService)
    {
        _IndividualCustomerService = IndividualCustomerService;
    }

    
    

    [HttpGet]  
    public GetIndividualCustomerListResponse GetList([FromQuery] GetIndividualCustomerListRequest request) 
    {
        GetIndividualCustomerListResponse response = _IndividualCustomerService.GetList(request);
        return response;
    }

    [HttpPost]  
    public ActionResult<AddIndividualCustomerResponse> Add(AddIndividualCustomerRequest request)
    {
        try
        {
            AddIndividualCustomerResponse response = _IndividualCustomerService.Add(request);

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
