using Business;
using Business.Abstract;
using Business.Concrete;
using Business.Requests.Transmission;
using Business.Responses.Transmission;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TransmissionsController : ControllerBase
{
    private readonly ITransmissionService _TransmissionService; 

    public TransmissionsController(ITransmissionService TransmissionService)
    {
        _TransmissionService = TransmissionService;
    }

    
    

    [HttpGet]  
    public GetTransmissionListResponse GetList([FromQuery] GetTransmissionListRequest request) 
    {
        GetTransmissionListResponse response = _TransmissionService.GetList(request);
        return response;
    }

    [HttpPost]  
    public ActionResult<AddTransmissionResponse> Add(AddTransmissionRequest request)
    {
        try
        {
            AddTransmissionResponse response = _TransmissionService.Add(request);

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
