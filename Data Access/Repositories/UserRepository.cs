using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Context;
using Entities.Models;

namespace BusinessLogic.Repository
{
    public class UserRepository:GeneralRepository<User>,IGeneralRepository<User>
    {
        public UserRepository(Context context) : base(context) { }
    }
}
