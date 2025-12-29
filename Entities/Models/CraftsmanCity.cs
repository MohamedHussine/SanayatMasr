using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models

{
    public class CraftsmanCity : BaseModel
    {
        public int CraftsmanId { get; set; }
        public Craftsman? Craftsman { get; set; }

        public int CityId { get; set; }
        public City? City { get; set; }

        public bool IsPrimary { get; set; }
    }

}
