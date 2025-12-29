using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Governorate : BaseModel
    {
        public string Name { get; set; } = null!;
        public string ArabicName { get; set; } = null!;

        public virtual ICollection<City>? Cities { get; set; }
    }

}
