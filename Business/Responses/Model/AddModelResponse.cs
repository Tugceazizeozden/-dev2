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

        public AddModelResponse( int ıd ,  string name,  int brandId, int fuelId, int  transmissionId,decimal  dailyPrice, DateTime createdAt)
        {
            Id = ıd;
            Name = name;
            BrandId = brandId;
            FuelId = fuelId;    
            TransmissionId = transmissionId;    
            DailyPrice = dailyPrice;    
            CreatedAt = createdAt;  

        }
        public AddModelResponse()
        {
                
        }



    }
}
