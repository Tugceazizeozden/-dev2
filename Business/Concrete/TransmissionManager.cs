using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Requests.Transmission;
using Business.Responses.Transmission;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class TransmissionManager : ITransmissionService
{
    private readonly ITransmissionDal _TransmissionDal;
    private readonly TransmissionBusinessRules _TransmissionBusinessRules;
    private readonly IMapper _mapper;

    public TransmissionManager(ITransmissionDal TransmissionDal, TransmissionBusinessRules TransmissionBusinessRules, IMapper mapper)
    {
        _TransmissionDal = TransmissionDal;
        _TransmissionBusinessRules = TransmissionBusinessRules;
        _mapper = mapper;
    }

    public AddTransmissionResponse Add(AddTransmissionRequest request)
    {
        _TransmissionBusinessRules.CheckIfTransmissionNameNotExists(request.Name);
        
        Transmission TransmissionToAdd = _mapper.Map<Transmission>(request); 

        _TransmissionDal.Add(TransmissionToAdd);

        AddTransmissionResponse response = _mapper.Map<AddTransmissionResponse>(TransmissionToAdd);
        return response;
    }

    public GetTransmissionListResponse GetList(GetTransmissionListRequest request)
    {

        IList<Transmission> TransmissionList = _TransmissionDal.GetList();
    


        GetTransmissionListResponse response = _mapper.Map<GetTransmissionListResponse>(TransmissionList); 
        return response;
    }
}
