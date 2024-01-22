using AutoMapper;
using Business.Dtos.Car;
using Business.Requests;
using Business.Responses;
using Entities.Concrete;

namespace Business.Profiles.Mapping.AutoMapper;

public class CarMapperProfiles : Profile
{



    public CarMapperProfiles()
    {
        CreateMap<AddCarRequest, Car>();
        CreateMap<Car, AddCarResponse>();

        CreateMap<Car, CarListItemDto>();
        CreateMap<IList<Car>, GetCarListResponse>()
            .ForMember(
                destinationMember: dest => dest.Items,
                memberOptions: opt => opt.MapFrom(mapExpression: src => src)
            );
    }
}
