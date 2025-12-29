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
    public class ProfessionRepository:GeneralRepository<Profession>,IGeneralRepository<Profession>
    {
        public ProfessionRepository(Context context):   base(context) { }
    }
}
