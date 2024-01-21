using Core.Entities;

namespace Entities.Concrete;

public class Model : Entity<int>
{
    public int BrandId { get; set; }
    public string Name { get; set; }
    

    public Brand? Brand { get; set; } = null;

    public int FuelId { get; set; }
    
    public int TransmissionId { get; set; }
    public decimal DailyPrice{ get; set; }
}
