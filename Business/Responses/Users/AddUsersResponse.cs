namespace Business.Responses.Users;

public class AddUsersResponse
{ 
    public int Password { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Email{ get; set; }

    public AddUsersResponse(int password, string lastname, string firstname , string email)
    {
        Password = password;
        
        LastName = lastname; 
        FirstName = firstname; 
        Email = email; 


    }
}
