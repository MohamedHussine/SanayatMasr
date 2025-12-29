using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Payment : BaseModel
    {
        public int SubscriptionId { get; set; }
        public CraftsmanSubscription? Subscription { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        public string Currency { get; set; }
        public string PaymentMethod { get; set; }
        public string ProviderReference { get; set; }
        public string Status { get; set; }
    }

}
