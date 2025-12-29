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
    public class CraftsmanRepository : GeneralRepository<Craftsman>,IGeneralRepository<Craftsman>
    {
        public CraftsmanRepository(Context context) : base(context)
        {

        }
    }
}
