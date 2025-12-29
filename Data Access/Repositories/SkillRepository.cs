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
    public class SkillRepository:GeneralRepository<Skill>,IGeneralRepository<Skill>
    {
        public SkillRepository(Context context) : base(context) { }
    }
}
