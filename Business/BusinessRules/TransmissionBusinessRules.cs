using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;

namespace Business.BusinessRules;

public class TransmissionBusinessRules
{
    private readonly ITransmissionDal _TransmissionDal;

    public TransmissionBusinessRules(ITransmissionDal TransmissionDal)
    {
        _TransmissionDal = TransmissionDal;
    }

    public void CheckIfTransmissionNameNotExists(string TransmissionName)
    {
        bool isExists = _TransmissionDal.GetList().Any(b => b.Name == TransmissionName);
        if (isExists)
        {
            throw new BusinessException("Transmission already exists.");
        }
    }
}
