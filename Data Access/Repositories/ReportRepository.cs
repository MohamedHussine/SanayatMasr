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
    public class ReportRepository:GeneralRepository<Report>,IGeneralRepository<Report>
    {
        public ReportRepository(Context context): base(context) { }
    }
}
