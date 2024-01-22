using Business.Requests;
using Business.Responses;

namespace Business.Abstract;

public interface ICarService
{
    public AddCarResponse Add(AddCarRequest request);

    public GetCarListResponse GetList(GetCarListRequest request);
}
