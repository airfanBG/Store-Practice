using Microsoft.EntityFrameworkCore;
using Store.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Data.Common.Repositories
{
    //Unit of work class
    public class StoreContextData : IStoreContextData
    {
        public DbContext Context { get; }
     
        private readonly Dictionary<Type, object> repositories;

        public StoreContextData(DbContext context)
        {
            Context =context;
           
            repositories = new Dictionary<Type, object>();
        }
        public StoreContextData()
        {
            Context = new StoreDbContext();

            repositories = new Dictionary<Type, object>();
        }

        public IRepository<Product> Products
        {
            get
            {
                return this.GetRepository<Product>();
            }
        }
        public IRepository<SaleOrder> SaleOrders
        {
            get
            {
                return this.GetRepository<SaleOrder>();
            }
        }
        public IRepository<Employee> Employees
        {
            get
            {
                return this.GetRepository<Employee>();
            }
        }
        public IRepository<User> Users
        {
            get
            {
                return this.GetRepository<User>();
            }
        }
        public void Dispose()
        {
            this.Dispose(true);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.Context != null)
                {
                    this.Context.Dispose();
                }
            }
        }

        public int SaveChanges()
        {
            return Context.SaveChanges();
        }
        private IRepository<T> GetRepository<T>() where T : class
        {
            if (!this.repositories.ContainsKey(typeof(T)))
            {
                var type = typeof(Repository<T>);

                this.repositories.Add(typeof(T), Activator.CreateInstance(type, this.Context));
            }

            return (IRepository<T>)this.repositories[typeof(T)];
        }
    }
}
