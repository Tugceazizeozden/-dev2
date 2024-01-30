namespace Business.Responses.Customers;

public class AddCustomersResponse
{ 
    public string UserId{ get; set; }

    public AddCustomersResponse(string userId )
    {
        UserId = userId;

    }
}
