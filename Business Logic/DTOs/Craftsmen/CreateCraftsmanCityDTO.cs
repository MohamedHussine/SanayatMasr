using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs.Craftsmen
{
  
    public class CreateCraftsmanCityDTO
    {
        [Required(ErrorMessage = "CityId is required")]
        public int CityId { get; set; }
    }

}
