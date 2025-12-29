using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Data;
using DataAccess.Interfaces;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DataAccess.Repositories
{
    public class GeneralRepository<T> :IGeneralRepository<T> where T : BaseModel
    {
        Context _context;
        DbSet<T> _dbset;
        public GeneralRepository(Context appDbContext)
        {
            _context = appDbContext;
            _dbset = _context.Set<T>();

        }

        public IQueryable<T> GetAll()
        {
            var res = _dbset.Where(x => !x.IsDeleted);
            return res;
        }
        public async Task<T> GetByID(int id)
        {
            var res = await _dbset.Where(c => c.Id == id && !c.IsDeleted).FirstOrDefaultAsync();
            return res;
        }
        public async Task<T> GetByIDWithTracking(int id)
        {
            var res = await _dbset.AsTracking().Where(c => c.Id == id).FirstOrDefaultAsync();
            return res;
        }
        public async Task Add(T entity)
        {
            _dbset.Add(entity);
            await _context.SaveChangesAsync();
        }
        public async Task Update(T entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
        public async Task Delete(int id)
        {
            var res = await GetByIDWithTracking(id);
            res.IsDeleted = true;

            await _context.SaveChangesAsync();
        }
        public void UpdateInclude(T entity, params string[] modifiedParams)
        {
            if (!_dbset.Any(x => x.Id == entity.Id))
            { return; }

            var local = _dbset.Local.FirstOrDefault(x => x.Id == entity.Id);
            EntityEntry entityEntry;

            if (local == null)
            {
                entityEntry = _context.Entry(entity);
            }
            else
            {
                entityEntry = _context.ChangeTracker.Entries<T>().FirstOrDefault(x => x.Entity.Id == entity.Id);
            }

            foreach (var prop in entityEntry.Properties)
            {
                if (modifiedParams.Contains(prop.Metadata.Name))
                {
                    prop.CurrentValue = entity.GetType().GetProperty(prop.Metadata.Name).GetValue(entity);
                    prop.IsModified = true;
                }
            }
            _context.SaveChanges();
        }

        public Task<bool> IsExist(int id)
        {
            return _dbset.AnyAsync(c => c.Id == id);
        }
    }

}

