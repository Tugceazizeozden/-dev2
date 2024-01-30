using Business.Abstract;
using Business.BusinessRules;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Business.DependencyResolvers;

public static class ServiceCollectionBusinessExtension
{
    public static IServiceCollection AddBusinessServices(this IServiceCollection services , IConfiguration  configuration)
    {
        services
            .AddSingleton<IBrandService, BrandManager>()
            .AddSingleton<IBrandDal, InMemoryBrandDal>()
            .AddSingleton<BrandBusinessRules>();

        services

            .AddSingleton<IModelService, ModelManager>()
            .AddSingleton<IModelDal, InMemoryModelDal>()
            .AddSingleton<ModelBusinessRules>();


        services

            .AddSingleton<ICarService, CarManager>()
            .AddSingleton<ICarDal, InMemoryCarDal>()
            .AddSingleton<CarBusinessRules>();

        services
            .AddSingleton<IFuelService, FuelManager>()
            .AddSingleton<IFuelDal, InMemoryFuelDal>()
            .AddSingleton<FuelBusinessRules>();

        services
        .AddSingleton<ITransmissionService, TransmissionManager>()
        .AddSingleton<ITransmissionDal, InMemoryTransmissionDal>()
        .AddSingleton<TransmissionBusinessRules>();

        services

        .AddScope<IIndiviualCustomerService, IndivaCusstomerManager>()





        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        services.AddDbContext<RentACarContext>(
            options => options.UseSqlServer(configuration.GetConnectionString("RentACarMSSQL22"))); 




        return services;
    }
}
