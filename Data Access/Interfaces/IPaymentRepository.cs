using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;

namespace DataAccess.Interfaces
{
    public interface IPaymentRepository :IGeneralRepository<Payment>
    {
    }
}
