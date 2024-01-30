using Core.Entities;

namespace Entities.Concrete;

public class Users : Entity<int>
{
    public int Password{ get; set; }
    public string LastName { get; set; }
    


    public string FirstName { get; set; }
    
    public string Email { get; set; }

}
