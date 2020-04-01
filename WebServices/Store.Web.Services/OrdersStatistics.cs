using Microsoft.EntityFrameworkCore;
using Store.Data;
using Store.Data.Common.Repositories;
using Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Store.Web.Services
{
    public class OrdersStatistics
    {
        private IStoreContextData storeContextData;

        public OrdersStatistics(IStoreContextData context)
        {
            storeContextData = context;
        }
        public int GetNotFinishedOrdersCountBySeller(string id)
        {
            using (storeContextData)
            {
                var count = storeContextData.SaleOrders.GetDbSet().Where(z => z.InternetOrdered == true && z.Finished == false).Include(x => x.Employee.User).Where(x => x.Employee.UserId == id).Count();
                return count;
            }
      
        }
        public List<SaleOrder> GetNotFinishedOrdersBySeller(string id)
        {
            using (storeContextData)
            {
                var res = storeContextData.SaleOrders.GetDbSet().Where(z => z.InternetOrdered == true && z.Finished == false).Include(x => x.Employee.User).Where(x => x.Employee.UserId == id).ToList();
                return res;
            }

        }
    }
}
