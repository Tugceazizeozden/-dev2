using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses
{
    public class AddModelResponse

    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public int BrandId { get; set; } 

        public int FuelId { get; set;}
        public int TransmissionId { get; set;}
        public decimal DailyPrice { get; set;}

        public DateTime CreatedAt { get; set; }

        public AddModelResponse( int ıd , DateTime createdat, string name=null,  int brandId=0, int fuelId=0, int  transmissionId=0,decimal  dailyPrice=0 )
        {
            Id = ıd;
            Name = name;
            BrandId = brandId;
            FuelId = fuelId;    
            TransmissionId = transmissionId;    
            DailyPrice = dailyPrice;    
            CreatedAt = createdat;  

        }
        public AddModelResponse()
        {
                
        }



    }
}
