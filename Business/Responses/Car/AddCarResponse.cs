using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses
{
    public class AddCarResponse

    {
        public int Id { get; set; } 
        public int ColorId { get; set; }

        public int ModelId{ get; set; } 

        public bool CarState { get; set;}
        public int Kilometer { get; set;}
        public DateTime ModelYear { get; set;}
        public string Plate { get; set; }

        public DateTime CreatedAt { get; set; }

        public AddCarResponse( int ıd , DateTime createdat, int colorId,  int modelId, bool carState, int  kiloMeter,DateTime  modelYear, string plate)
        {
            Id = ıd;
            ColorId = colorId;  
            ModelId = modelId;  
            CarState = carState;    
            Kilometer = kiloMeter;  
            ModelYear = modelYear;  
            Plate = plate;  

            CreatedAt = createdat;  

        }
        public AddCarResponse()
        {
                
        }



    }
}
