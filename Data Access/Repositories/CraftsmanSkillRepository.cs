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
    public class CraftsmanSkillRepository :GeneralRepository<CraftsmanSkill>,IGeneralRepository<CraftsmanSkill>
    {
        public CraftsmanSkillRepository(Context context) : base(context) { }
    }
}
