using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Context;

namespace BusinessLogic.Repository
{
    public class CraftsmanSubscriptionRepository :
        GeneralRepository<CraftsmanSubscription> ,IGeneralRepository<CraftsmanSubscription>
    {
        public CraftsmanSubscriptionRepository(Context context) : base(context) { } 
    }
}
