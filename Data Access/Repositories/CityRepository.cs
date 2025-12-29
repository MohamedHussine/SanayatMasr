using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Interface;
using DataAccess.Context;
using Entities.Models;

namespace BusinessLogic.Repository
{
    public class CityRepository : GeneralRepository<City>, IGeneralRepository<City>,ICityRepository
    {

        public CityRepository(Context context) : base(context)
        {
            {

            }

        }
    }
}
