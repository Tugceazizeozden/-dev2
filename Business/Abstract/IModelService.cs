using Business.Requests;
using Business.Responses;

namespace Business.Abstract;

public interface IModelService
{
    public AddModelResponse Add(AddModelRequest request);

    public GetModelListResponse GetList(GetModelListRequest request);

    public GetModelByIdResponse GetById(GetModelByIdRequest request);
    public UpdateModelResponse Update(UpdateModelRequest request);
    public DeleteModelResponse Delete(DeleteModelRequest request);


}
