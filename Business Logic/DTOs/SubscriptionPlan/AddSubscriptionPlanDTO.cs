using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs.SubscriptionPlan
{
    public class AddSubscriptionPlanDTO
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string ArabicName { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        [Range(1, 1000)]
        public int DurationInDays { get; set; }
    }
}
