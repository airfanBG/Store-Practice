using Microsoft.EntityFrameworkCore;
using Store.Data;
using Store.Data.Common.Repositories;
using Store.Models;
using Store.Web.Services;
using System;
using System.Data.SqlClient;
using System.Linq;

namespace Store.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //01.04.2020
            OrdersStatistics os = new OrdersStatistics(new StoreContextData());
            var res = os.GetNotFinishedOrdersBySeller("df54f312-634a-409d-9c6f-117d3993dc7a");
            //ent 01.04.2020
            //EF using 23.03.2020 https://docs.microsoft.com/en-us/ef/core/querying/
            //https://docs.microsoft.com/en-us/ef/core/querying/client-eval#client-evaluation-in-the-top-level-projection
            //using (StoreDbContext db=new StoreDbContext())
            //{
            //    var customer = db.Customers.FirstOrDefault();
            //    //При използване на AsNoTracking се прави заявка която не се следи от ChangeTracker-а. https://entityframeworkcore.com/saving-data-changetracker
            //    var res = db.SaleOrders.Where(x => x.CustomerId == customer.Id.ToString()).AsNoTracking().ToList();
            //}
            //using (StoreDbContext db = new StoreDbContext())
            //{
            //    //Query returns anonymous entities
            //    var res = db.SaleOrders.Select(x => new { Product = x.Product.ProductName, Price = x.Product.ProductPrice, Quantity = x.Quantity }).ToList();
            //}
            //using (StoreDbContext db = new StoreDbContext())
            //{
            //    //Query returns anonymous entities
            //    var res = db.SaleOrders
            //        .Select(x => new { Product = x.Product.ProductName, Price = x.Product.ProductPrice, Quantity = x.Quantity })
            //        .GroupBy(x => x.Product)
            //        .Select(x => new { ProductName = x.Key, AllQuantity = x.Sum(x => x.Quantity) })
            //        .ToList();
            //}



            //end 23.03.2020
            //start 25.03.2020
            //add new products in one request
            //using (StoreDbContext db = new StoreDbContext())
            //{
            //    var product1 = new Product() { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, Description = "product22", ProductName = "Product22", ProductPrice = 10 };
            //    var product2 = new Product() { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, Description = "product23", ProductName = "Product23", ProductPrice = 5 };
            //    var product3 = new Product() { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, Description = "product24", ProductName = "Product24", ProductPrice = 1 };

            //    db.Products.AddRange(product1, product2, product3);
            //    db.SaveChanges();
            //}
            //delete product (Soft delete)
            //using (StoreDbContext db = new StoreDbContext())
            //{
            //    var products = db.Products.Where(x => x.ProductName == "product22" || x.ProductName == "product23" || x.ProductName == "product24").ToList();

            //    if (products.Count!=0)
            //    {
            //        db.Products.RemoveRange(products);
            //        db.SaveChanges();
            //    }

            //}
            //update
            //using (StoreDbContext db = new StoreDbContext())
            //{
            //    var product = db.Products.SingleOrDefault(x=>x.ProductName== "product24");

            //    if (product!=null)
            //    {
            //        product.ProductName = "PRODUCT24";
            //        db.Products.Update(product);
            //        db.SaveChanges();
            //    }

            //}

            //using (StoreDbContext db = new StoreDbContext())
            //{
            //    var r = db.Products.Include(x => x.SalesOrders).Select(x => new
            //    {
            //        ProductName = x.ProductName,
            //        Orders = x.SalesOrders.Select(x => x.DateOfSale)
            //    }).OrderByDescending(x => x.Orders.Count()).ToList();

            //}


            //end25.03.2020
            //start 28.03.2020

            //using (StoreDbContext db = new StoreDbContext())
            //{
            //    var res = db.SaleOrders
            //        .GroupBy(x => x.Product.ProductName)
            //        .Select(x => new
            //        {
            //            ProductName = x.Key,

            //            Total = x.Sum(a => a.Quantity)
            //        }).OrderByDescending(x=>x.Total).ToList();
            //}

            //using (StoreDbContext db = new StoreDbContext())
            //{
            //    var res = db.SaleOrders
            //        .Join(db.Employees, so => so.EmployeeId, e => e.Id,
            //        (so, emp) => new
            //        {
            //            so,
            //            emp
            //        })
            //        .GroupBy(x =>
            //        new
            //        {
            //            id = x.emp.Id
            //        })
            //        .Select(a =>
            //        new
            //        {
            //            IdTest = a.Key.id,
            //            Dep = a.Sum(z => z.so.Quantity)
            //        })
            //        .ToList();

            //}


            //end 28.03.2020



            //Repository and Unit of Work

            //using (StoreContextData db = new StoreContextData(new StoreDbContext()))
            //{
            //    var res = db.Products.AllAsNoTracking().ToList();
            //}

            //Ado.net
            //string connectionString = @"Server=;Database=;Trusted_Connection=True;";
            // string queryString = "select * from users";
            //string queryStringAdd = "insert into users (id,email, telephone,password,createdat) values(@id,@email, @telephone, @password, @createdat)";
            //string deleteString = "Delete from users where id =@id";

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    SqlCommand cmd = new SqlCommand(queryString, connection);
            //    cmd.Connection.Open();
            //    var result = cmd.ExecuteReader();
            //    while (result.Read())
            //    {
            //        Console.WriteLine(result[1]);
            //    }

            //}
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    SqlCommand cmd = new SqlCommand(queryStringAdd, connection);
            //    cmd.Parameters.AddWithValue("id", Guid.NewGuid().ToString().ToString());
            //    cmd.Parameters.AddWithValue("email", "test@test.bg");
            //    cmd.Parameters.AddWithValue("telephone", "9999999");
            //    cmd.Parameters.AddWithValue("password", "test");
            //    cmd.Parameters.AddWithValue("createdat", DateTime.Now);


            //    try
            //    {
            //        cmd.Connection.Open();

            //        var res = cmd.ExecuteNonQuery();
            //        Console.WriteLine(res);
            //    }
            //    catch (Exception e)
            //    {
            //        cmd.Transaction.Rollback();
            //        throw new ArgumentException(e.Message);
            //    }
            //}
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    SqlCommand cmd = new SqlCommand(deleteString, connection);
            //    cmd.Connection.Open();
            //    cmd.Parameters.AddWithValue("id", "some id");
            //    try
            //    {
            //        var res = cmd.ExecuteNonQuery();
            //        Console.WriteLine(res);

            //    }
            //    catch (Exception e)
            //    {
            //        cmd.Transaction.Rollback();
            //        throw new Exception(e.Message);
            //    }

            //}
            //You can use OleDb only in Entity Framework 6

            //EF core LINQ
            //using (StoreDbContext db=new StoreDbContext())
            //{
            //    var res = db.Users.ToList();
            //    foreach (var user in res)
            //    {
            //        Console.WriteLine(user.Email);
            //    }
            //}
        }
    }
}
