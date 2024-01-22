using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests
{
    public class AddCarRequest
    {
        public int ColorId { get; set; }
        public int ModelId { get; set; }
        public bool CarState{ get; set; }
        public int Kilometer { get; set; }
        public DateTime ModelYear  { get; set; }
        public string Plate { get; set; }

        public AddCarRequest( int  colorId, int modelId, bool carState,int  kilometer , DateTime  modelYear , string plate)
        {
            ColorId = colorId;
            ModelId = modelId;  
            CarState = carState;    
            Kilometer = kilometer;  
            ModelYear = modelYear;  
            Plate = plate;  






        }












    }
}
