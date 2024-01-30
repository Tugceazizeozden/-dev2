using Business;
using Business.Abstract;
using Business.Concrete;
using Business.Requests.CorporateCustomer;
using Business.Responses.CorporateCustomer;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CorporateCustomersController : ControllerBase
{
    private readonly ICorporateCustomerService _CorporateCustomerService; 

    public CorporateCustomersController(ICorporateCustomerService CorporateCustomerService)
    {
        _CorporateCustomerService = CorporateCustomerService;
    }

    
    

    [HttpGet]  
    public GetCorporateCustomerListResponse GetList([FromQuery] GetCorporateCustomerListRequest request) 
    {
        GetCorporateCustomerListResponse response = _CorporateCustomerService.GetList(request);
        return response;
    }

    [HttpPost]  
    public ActionResult<AddCorporateCustomerResponse> Add(AddCorporateCustomerRequest request)
    {
        try
        {
            AddCorporateCustomerResponse response = _CorporateCustomerService.Add(request);

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
