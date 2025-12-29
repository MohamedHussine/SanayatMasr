using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Context;
using Entities.Models;

namespace BusinessLogic.Repository
{
    public class ReviewRepository:GeneralRepository<Review>,IGeneralRepository<Review>
    {
        public ReviewRepository(Context context) : base(context) { }
    }
}
