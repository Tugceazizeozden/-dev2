using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests
{
    public class AddModelRequest
    {
        public string Name { get; set; }
        public int BrandId { get; set; }
        public int FuelId { get; set; }
        public int TransmissionId { get; set; }
        public decimal DailyPrice { get; set; }

        public AddModelRequest( string name, int brandId, int fuelId ,int  transmissonId , decimal dailyPrice)
        {
            Name = name;
            BrandId = brandId; 
            FuelId = fuelId;
            TransmissionId = transmissonId;
            DailyPrice = dailyPrice;
        }












    }
}
