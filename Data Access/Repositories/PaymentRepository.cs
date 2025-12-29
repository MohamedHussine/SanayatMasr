using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Data;
using DataAccess.Interfaces;
using Entities.Models;

namespace DataAccess.Repositories
{
    public class PaymentRepository :GeneralRepository<Payment>,IGeneralRepository<Payment>
    {
        public PaymentRepository(Context context) : base(context) { }
    }
}
