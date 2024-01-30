namespace Business.Requests.Users;

public class AddUsersRequest
{ 
    public string LastName { get; set; }
    public int Passoword { get; set; }
    public string FirstName { get; set; }
    public string Email { get; set; }   




    public AddUsersRequest(int password, string firstName, string email, string lastname)
    {
        Passoword = password;
        FirstName = firstName;
        Email = email;  
        LastName = lastname;
    }
}
