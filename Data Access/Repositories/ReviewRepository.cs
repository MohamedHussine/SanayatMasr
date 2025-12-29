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
    public class ReviewRepository:GeneralRepository<Review>,IGeneralRepository<Review>
    {
        public ReviewRepository(Context context) : base(context) { }
    }
}
