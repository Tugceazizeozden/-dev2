using Core.Entities;

namespace Entities.Concrete;

public class IndividualCustomer : Entity<int>
{
    public string LastName { get; set; }
    


    public string FirstName { get; set; }
    
    public string Nationalldentity { get; set; }

}
