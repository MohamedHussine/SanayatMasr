using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Context;
using Entities.Models;

namespace BusinessLogic.Repository
{
    public class GalleryRepository :GeneralRepository<Gallery>,IGeneralRepository<Gallery>
    {
        public GalleryRepository(Context context) : base(context) { }
    }
}
