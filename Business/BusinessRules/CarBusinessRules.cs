using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;

namespace Business.BusinessRules;

public class CarBusinessRules
{
    private readonly ICarDal _CarDal;

    public CarBusinessRules(ICarDal CarDal)
    {
        _CarDal = CarDal;
    }

    
    
       
        }
   

