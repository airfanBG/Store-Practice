using Microsoft.EntityFrameworkCore;
using Store.Data;
using Store.Data.Common.Repositories;
using System;
using System.Data.SqlClient;
using System.Linq;

namespace Store.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {

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
            using (StoreDbContext db = new StoreDbContext())
            {
                //Query returns anonymous entities
                var res = db.SaleOrders
                    .Select(x => new { Product = x.Product.ProductName, Price = x.Product.ProductPrice, Quantity = x.Quantity })               
                    .GroupBy(x=>x.Product)
                    .Select(x=>new {ProductName=x.Key,AllQuantity=x.Sum(x=>x.Quantity) })
                    .ToList();
            }



            //end 23.03.2020

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
