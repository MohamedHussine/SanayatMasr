using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModel
{
    public class UpdateCraftsmanAllViewModel
    {
        public string Bio { get; set; }
        public int ExperienceYears { get; set; }
        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }
        public int ProfessionId { get; set; }
        public ICollection<int> CityIds { get; set; }
        public ICollection<int> SkillIds { get; set; }
        public ICollection<string> GalleryImageUrls { get; set; }
    }
}
