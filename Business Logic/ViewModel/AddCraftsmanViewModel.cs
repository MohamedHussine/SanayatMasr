using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModel
{
    public class AddCraftsmanViewModel
    {
        public int Id { get; set; } 
        public int UserId { get; set; }
        public string ProfessionName { get; set; } 
        public string Bio { get; set; }
        public int ExperienceYears { get; set; }
        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }
        public bool IsVerified { get; set; }
        public List<string> Cities { get; set; } 
        public List<string> Skills { get; set; }
    }
}
