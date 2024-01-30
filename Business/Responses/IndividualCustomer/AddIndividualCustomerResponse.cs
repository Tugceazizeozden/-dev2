namespace Business.Responses.Users;

public class AddIndividualCustomerResponse
{ 
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Nationalldentity{ get; set; }

    public AddIndividualCustomerResponse(, string lastname, string firstname , string nationalldentity)
    {
        
        LastName = lastname; 
        FirstName = firstname; 
        Nationalldentity = nationalldentity;


    }
}
