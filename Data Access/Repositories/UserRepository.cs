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
    public class UserRepository:GeneralRepository<User>,IGeneralRepository<User>
    {
        public UserRepository(Context context) : base(context) { }
    }
}
