namespace Business.Requests.CorporateCustomer;

public class AddCorporateCustomerRequest
{ 
    public int TaxNo { get; set; }
    public string CompanyName { get; set; }   




    public AddCorporateCustomerRequest(int taxNo, string companyName)
    {
        TaxNo = taxNo;
        CompanyName = companyName;



    }
}
