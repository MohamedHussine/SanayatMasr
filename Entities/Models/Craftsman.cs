using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models

{
    public class Craftsman : BaseModel
    {
        public int UserId { get; set; }
        public User? User { get; set; }

        public int ProfessionId { get; set; }
        public Profession? Profession { get; set; }

        public string Bio { get; set; }
        public int ExperienceYears { get; set; }

        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }

        public bool IsVerified { get; set; }
        public DateTime? VerificationDate { get; set; }

        public ICollection<CraftsmanCity>? WorkedCities { get; set; }
        public ICollection<CraftsmanSkill>? Skills { get; set; }
        public ICollection<Gallery>? GalleryImages { get; set; }
        public ICollection<Review>? Reviews { get; set; }
        public ICollection<CraftsmanSubscription>? Subscriptions { get; set; }
    }

}
