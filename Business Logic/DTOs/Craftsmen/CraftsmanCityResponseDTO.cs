using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs.Craftsmen
{
    public class CraftsmanCityResponseDTO 
    {
        public int CityId { get; set; }
        public string CityName { get; set; } = null!;
        public bool IsPrimary { get; set; }
    }

}
