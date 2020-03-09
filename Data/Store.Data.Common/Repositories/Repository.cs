using Microsoft.EntityFrameworkCore;
using Store.Models;
using Store.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Common.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    { 
        public DbContext Context { get; set; }
        public DbSet<T> DbSet { get; set; }

        public Repository(DbContext context)
        {
            this.Context = context ?? throw new ArgumentException("An instance of context is null");

            this.DbSet = this.Context.Set<T>();
        }

      
        public void Add(T entity)
        {
            if (entity!=null)
            {
                try
                {
                    DbSet.Add(entity);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
           
        }

        public IQueryable<T> All(Func<T, bool> func = null)
        {
            if (func==null)
            {
                return DbSet;
            }
            return DbSet.Where(func).AsQueryable();

        }

        public IQueryable<T> AllAsNoTracking()
        {

            return DbSet.AsNoTracking();

        }

        public void Delete(T entity)
        {
            if (entity != null)
            {
                try
                {
                    DbSet.Remove(entity);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public void DetachAll()
        {
            foreach (var dbEntityEntry in this.Context.ChangeTracker.Entries().ToList())
            {
                if (dbEntityEntry.Entity != null)
                {
                    dbEntityEntry.State = EntityState.Detached;
                }
            }
        }

        public void Dispose()
        {
            this.Context.Dispose();
        }

        public Task<int> SaveChangesAsync()
        {
            return Context.SaveChangesAsync(); 
        }

        public void Update(T entity)
        {
            if (entity != null)
            {
                try
                {
                    DbSet.Update(entity);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
