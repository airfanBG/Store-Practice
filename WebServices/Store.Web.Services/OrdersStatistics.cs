using Microsoft.EntityFrameworkCore;
using Store.Data;
using Store.Data.Common.Repositories;
using System;
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
        public int GetNotFinishedOrdersBySeller(string id)
        {
            using (storeContextData)
            {
                var count = storeContextData.SaleOrders.GetDbSet().Where(z => z.InternetOrdered == true && z.Finished == false).Include(x => x.Employee.User).Where(x => x.Employee.UserId == id).Count();
                return count;
            }
      
        }
    }
}
