namespace Business.Responses.CorporateCustomer;

public class AddCorporateCustomerResponse
{ 
    public int TaxNO{ get; set; }
    public string CompanyName{ get; set; }

    public AddCorporateCustomerResponse(int taxNo, string   companyName)
    {
        TaxNO = taxNo;
        CompanyName = companyName;  


    }
}
