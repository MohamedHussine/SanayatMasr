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
    public class GovernorateRepository:GeneralRepository<Governorate>,IGeneralRepository<Governorate>
    {
        public GovernorateRepository(Context context) : base(context) { }
    }
}
