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
            //Repository and Unit of Work

            using (StoreContextData db = new StoreContextData(new StoreDbContext()))
            {
                var res = db.Products.AllAsNoTracking().ToList();
            }
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
            //    cmd.Parameters.AddWithValue("id", Guid.NewGuid().ToString());
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
