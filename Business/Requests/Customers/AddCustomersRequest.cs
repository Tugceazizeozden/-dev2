namespace Business.Requests.Customers;

public class AddCustomersRequest
{ 
    public string UserId { get; set; }   




    public AddCustomersRequest( string userId)
    {
        UserId=userId;  
    }
}
