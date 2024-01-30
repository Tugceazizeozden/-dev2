namespace Business.Requests.IndividualCustomer;

public class AddIndividualCustomerRequest
{ 
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Nationalldentity { get; set; }   




    public AddIndividualCustomerRequest(, string firstName, string nationalldentity, string lastname)
    {
        FirstName = firstName;
        LastName = lastname;
        Nationalldentity = nationalldentity;

    }
}
