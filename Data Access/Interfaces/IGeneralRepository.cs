using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;

namespace BusinessLogic.Interface
{
    public interface IGeneralRepository<T> where T : BaseModel
    {
        public IQueryable<T> GetAll();
        public Task<T> GetByID(int id);
        public Task<T> GetByIDWithTracking(int id);
        public Task Add(T entity);
        public Task<bool> IsExist(int id);


        public Task Update(T entity);
        public Task Delete(int id);
        public void UpdateInclude(T entity, params string[] modifiedParams);

    }
}
