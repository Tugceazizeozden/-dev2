using Business;
using Business.Abstract;
using Business.Requests;
using Business.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ModelsController : ControllerBase
{
    private readonly IModelService _ModelService; 

    public ModelsController(IModelService ModelService)
    {
        _ModelService = ModelService;
    }

    
    

    [HttpGet]  
    public GetModelListResponse GetList([FromQuery] GetModelListRequest request) 
    {
        GetModelListResponse response = _ModelService.GetList(request);
        return response;
    }

    [HttpPost]  
    public ActionResult<AddModelResponse> Add(AddModelRequest request)
    {
        try
        {
            AddModelResponse response = _ModelService.Add(request);

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
