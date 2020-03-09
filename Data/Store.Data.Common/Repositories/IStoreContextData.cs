using Microsoft.EntityFrameworkCore;
using Store.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Data.Common.Repositories
{
    public interface IStoreContextData:IDisposable
    {
        DbContext Context { get; }
        public IRepository<Product> Products { get; }
      
        int SaveChanges();
    }
}
