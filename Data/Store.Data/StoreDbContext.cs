
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Store.Models;
using Store.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Store.Data
{
    public class StoreDbContext:IdentityDbContext<User>
    {
        protected IConfigurationRoot configuration;
        public StoreDbContext()
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<EmployeeCustomers> EmployeeCustomers { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SaleOrder> SaleOrders { get; set; }

   
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //ако искате да добавите някаква дифолтна стойност на конкретно пропърти. Същото е, ако добавите и стойност на самото пропърти (виж Telephone в User)
            //modelBuilder.Entity<User>().Property(x => x.Telephone).HasDefaultValue("000-000-000");

            //seed
           // Debugger.Launch();
            var user1 = new User() { Id = Guid.NewGuid().ToString(), Email = "user1@ba.bg", NormalizedEmail = "user1@ba.bg".ToUpper(), CreatedAt = DateTime.Now, Telephone = "222-222-222" };
            var user2 = new User() { Id = Guid.NewGuid().ToString(), Email = "user2@ba.bg", NormalizedEmail = "user2@ba.bg".ToUpper(),  CreatedAt = DateTime.Now, Telephone = "443-111-222" };
            var user3 = new User() { Id = Guid.NewGuid().ToString(), Email = "user3@ba.bg", NormalizedEmail = "user3@ba.bg".ToUpper(),  CreatedAt = DateTime.Now, Telephone = "443-122-222" };
            var user4 = new User() { Id = Guid.NewGuid().ToString(), Email = "user4@ba.bg", NormalizedEmail = "user4@ba.bg".ToUpper(),  CreatedAt = DateTime.Now, Telephone = "443-431-222" };
            var user5 = new User() { Id = Guid.NewGuid().ToString(), Email = "user5@ba.bg", NormalizedEmail = "user5@ba.bg".ToUpper(),  CreatedAt = DateTime.Now, Telephone = "443-111-857" };
            var user6 = new User() { Id = Guid.NewGuid().ToString(), Email = "user6@ba.bg", NormalizedEmail = "user6@ba.bg".ToUpper(), CreatedAt = DateTime.Now, Telephone = "443-111-347" };
            var user7 = new User() { Id = Guid.NewGuid().ToString(), Email = "user7@ba.bg", NormalizedEmail = "user7@ba.bg".ToUpper(), CreatedAt = DateTime.Now, Telephone = "443-111-987" };
            var user8 = new User() { Id = Guid.NewGuid().ToString(), Email = "user8@ba.bg", NormalizedEmail = "user8@ba.bg".ToUpper(), CreatedAt = DateTime.Now, Telephone = "443-111-654" };
            var user9 = new User() { Id = Guid.NewGuid().ToString(), Email = "user9@ba.bg", NormalizedEmail = "user9@ba.bg".ToUpper(),  CreatedAt = DateTime.Now, Telephone = "443-111-556" };
            var user10 = new User() { Id = Guid.NewGuid().ToString(), Email = "user10@ba.bg", NormalizedEmail = "user10@ba.bg".ToUpper(), CreatedAt = DateTime.Now, Telephone = "443-111-478" };
            PasswordHasher<User> passwordHasher = new PasswordHasher<User>();
            user1.PasswordHash = passwordHasher.HashPassword(user1, "Your-PW1");
            user2.PasswordHash = passwordHasher.HashPassword(user2, "Your-PW1");
            user3.PasswordHash = passwordHasher.HashPassword(user3, "Your-PW1");
            user4.PasswordHash = passwordHasher.HashPassword(user4, "Your-PW1");
            user5.PasswordHash = passwordHasher.HashPassword(user5, "Your-PW1");
            user6.PasswordHash = passwordHasher.HashPassword(user6, "Your-PW1");
            user7.PasswordHash = passwordHasher.HashPassword(user7, "Your-PW1");
            user8.PasswordHash = passwordHasher.HashPassword(user8, "Your-PW1");
            user9.PasswordHash = passwordHasher.HashPassword(user9, "Your-PW1");
            user10.PasswordHash = passwordHasher.HashPassword(user10, "Your-PW1");

            var department1 = new Department() { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, DepartmentName = "Sales" };
            var department2 = new Department() { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, DepartmentName = "CEO" };
            var department3 = new Department() { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, DepartmentName = "Warehouse" };
            var employee1 = new Employee() { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now};
            var employee2 = new Employee() { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now };
            var employee3 = new Employee() { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now };
            var employee4 = new Employee() { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now };
            var employee5 = new Employee() { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now };
            var employee6 = new Employee() { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now };

            var customer1 = new Customer() { Id = Guid.NewGuid().ToString().ToString(), CreatedAt = DateTime.Now, AccountNumber = "123213" };
            var customer2 = new Customer() { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, AccountNumber = "134519" };
            var customer3 = new Customer() { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, AccountNumber = "914311" };
            var customer4 = new Customer() { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, AccountNumber = "618299" };
            var customer5 = new Customer() { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, AccountNumber = "091234" };

            var product1 = new Product() { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, Description = "product1", ProductName = "Product1", ProductPrice = 10 };
            var product2 = new Product() { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, Description = "product2", ProductName = "Product2", ProductPrice = 5 };
            var product3 = new Product() { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, Description = "product3", ProductName = "Product3", ProductPrice = 1 };
            var product4 = new Product() { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, Description = "product4", ProductName = "Product4", ProductPrice = 45 };
            var product5 = new Product() { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, Description = "product5", ProductName = "Product5", ProductPrice = 11 };
            var product6 = new Product() { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, Description = "product6", ProductName = "Product6", ProductPrice = 19 };
            var product7 = new Product() { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, Description = "product7", ProductName = "Product7", ProductPrice = 2 };
            var product8 = new Product() { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, Description = "product8", ProductName = "Product8", ProductPrice = 22 };
            var product9 = new Product() { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, Description = "product9", ProductName = "Product9", ProductPrice = 13 };
            var product10 = new Product() { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, Description = "product10", ProductName = "Product10", ProductPrice = 100 };

         
            modelBuilder.Entity<User>().HasData(user1,user2, user3,user4,user5,user6,user7, user8, user9, user10);
            modelBuilder.Entity<Department>().HasData(department1, department2,department3);

            employee1.UserId = user1.Id;
         
            employee1.DepartmentId = department1.Id.ToString();
            employee2.UserId = user2.Id;
            employee2.DepartmentId = department1.Id.ToString();
            employee3.UserId = user3.Id;
            employee3.DepartmentId = department2.Id.ToString();
            employee4.UserId = user4.Id;
            employee4.DepartmentId = department3.Id.ToString();
            employee5.UserId = user5.Id;
            employee3.DepartmentId = department3.Id.ToString();
            employee6.UserId = user6.Id;
            employee6.DepartmentId = department1.Id.ToString();

            modelBuilder.Entity<Employee>().HasData(employee1, employee2,employee3,employee4,employee5,employee6);

            customer1.UserId = user7.Id;
            customer2.UserId = user8.Id;
            customer3.UserId = user9.Id;
            customer4.UserId = user10.Id;
            customer5.UserId = user1.Id;

            modelBuilder.Entity<Customer>().HasData(customer1, customer2,customer3,customer4,customer5);
            modelBuilder.Entity<Product>().HasData(product1,product2,product3, product4,product5,product6,product7,product8,product9,product10);

            var empCustomers1 = new EmployeeCustomers() { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, CustomerId = customer1.Id.ToString(), EmployeeId = employee1.Id.ToString() };
            var empCustomers2 = new EmployeeCustomers() { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, CustomerId = customer2.Id.ToString(), EmployeeId = employee1.Id.ToString() };
            var empCustomers3 = new EmployeeCustomers() { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, CustomerId = customer1.Id.ToString(), EmployeeId = employee2.Id.ToString() };
            var empCustomers4 = new EmployeeCustomers() { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, CustomerId = customer2.Id.ToString(), EmployeeId = employee2.Id.ToString() };
            var empCustomers5 = new EmployeeCustomers() { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, CustomerId = customer3.Id.ToString(), EmployeeId = employee2.Id.ToString() };
            var empCustomers6 = new EmployeeCustomers() { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, CustomerId = customer5.Id.ToString(), EmployeeId = employee1.Id.ToString() };
            var empCustomers7 = new EmployeeCustomers() { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, CustomerId = customer4.Id.ToString(), EmployeeId = employee6.Id.ToString() };

            modelBuilder.Entity<EmployeeCustomers>().HasData(empCustomers1, empCustomers2, empCustomers3, empCustomers4, empCustomers5, empCustomers6, empCustomers7);

            var saleOrder1 = new SaleOrder() { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, CustomerId = customer1.Id.ToString(), DateOfSale = new DateTime(2020, 01, 10), ProductId = product1.Id.ToString(), Quantity = 10, EmployeeId = employee1.Id, InternetOrdered = true,Finished=false };
            var saleOrder2 = new SaleOrder() { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, CustomerId = customer2.Id.ToString(), DateOfSale = new DateTime(2020, 01, 10), ProductId = product2.Id.ToString(), Quantity = 1, EmployeeId = employee1.Id, InternetOrdered = true, Finished = false };
            var saleOrder3 = new SaleOrder() { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, CustomerId = customer2.Id.ToString(), DateOfSale = new DateTime(2020, 01, 10), ProductId = product5.Id.ToString(), Quantity = 8, EmployeeId = employee2.Id, InternetOrdered = true, Finished = true };
            var saleOrder4 = new SaleOrder() { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, CustomerId = customer3.Id.ToString(), DateOfSale = new DateTime(2020, 01, 10), ProductId = product9.Id.ToString(), Quantity = 100, EmployeeId = employee2.Id, InternetOrdered = false, Finished = true };
            var saleOrder5 = new SaleOrder() { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, CustomerId = customer4.Id.ToString(), DateOfSale = new DateTime(2020, 01, 10), ProductId = product10.Id.ToString(), Quantity = 7, EmployeeId = employee1.Id, InternetOrdered = false, Finished = true };
            var saleOrder6 = new SaleOrder() { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, CustomerId = customer4.Id.ToString(), DateOfSale = new DateTime(2020, 01, 10), ProductId = product3.Id.ToString(), Quantity = 15, EmployeeId = employee6.Id, InternetOrdered = true, Finished = false };
            var saleOrder7 = new SaleOrder() { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, CustomerId = customer5.Id.ToString(), DateOfSale = new DateTime(2020, 01, 10), ProductId = product8.Id.ToString(), Quantity = 100, EmployeeId = employee1.Id, InternetOrdered = true, Finished = false };
            var saleOrder8 = new SaleOrder() { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, CustomerId = customer1.Id.ToString(), DateOfSale = new DateTime(2020, 01, 10), ProductId = product1.Id.ToString(), Quantity = 4, EmployeeId = employee2.Id, InternetOrdered = true, Finished = true };
            var saleOrder9 = new SaleOrder() { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, CustomerId = customer2.Id.ToString(), DateOfSale = new DateTime(2020, 01, 10), ProductId = product7.Id.ToString(), Quantity = 8, EmployeeId = employee2.Id, InternetOrdered = true, Finished = true };
            var saleOrder10 = new SaleOrder() { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, CustomerId = customer2.Id.ToString(), DateOfSale = new DateTime(2020, 01, 10), ProductId = product1.Id.ToString(), Quantity = 2, EmployeeId = employee2.Id, InternetOrdered = false, Finished = false };
            var saleOrder11 = new SaleOrder() { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, CustomerId = customer5.Id.ToString(), DateOfSale = new DateTime(2020, 01, 10), ProductId = product2.Id.ToString(), Quantity = 10, EmployeeId = employee6.Id, InternetOrdered = true, Finished = false };
            var saleOrder12 = new SaleOrder() { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, CustomerId = customer5.Id.ToString(), DateOfSale = new DateTime(2020, 01, 10), ProductId = product2.Id.ToString(), Quantity = 10, EmployeeId = employee1.Id, InternetOrdered = true, Finished = false };
            var saleOrder13 = new SaleOrder() { Id = Guid.NewGuid().ToString(), CreatedAt = DateTime.Now, CustomerId = customer1.Id.ToString(), DateOfSale = new DateTime(2020, 01, 10), ProductId = product9.Id.ToString(), Quantity = 19, EmployeeId = employee2.Id, InternetOrdered = true, Finished = false };

            modelBuilder.Entity<SaleOrder>().HasData(saleOrder1, saleOrder2, saleOrder3, saleOrder4, saleOrder5, saleOrder6, saleOrder7, saleOrder8, saleOrder9, saleOrder10, saleOrder11, saleOrder12, saleOrder13);

            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if you don't have json config file must add it in your project
            configuration = new ConfigurationBuilder().SetBasePath(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).AddJsonFile("appconfig.json").Build();
            optionsBuilder.UseSqlServer(this.configuration.GetConnectionString("DefaultConnection"));
        }

        //Кодът по-долу го използвам за улеснение при промяна или добавяне на нов обект, като вземам от ChangeTracker-а всички ентитита, от някакъв тип, в случая от интерфейса IAuditInfo и според това каква операция се извършва върху тях променям или добавям датата. Така се избягва отново преизползването на код и добавянето на дати в случая при всяко създаване или модифициране на клас. Това е advance подход, но не е излишно да го знаете.
        public override int SaveChanges()
        {
            return SaveChanges(true);
        }
        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            this.ApplyEntityChanges();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }
        private void ApplyEntityChanges()
        {
            var entries = this.ChangeTracker.Entries().Where(x => (x.Entity is IAuditInfo) && (x.State == EntityState.Added || x.State == EntityState.Modified || x.State == EntityState.Deleted)).ToList();
            foreach (var entry in entries)
            {
                var addedEntityType =(IAuditInfo)entry.Entity;
                if (entry.State == EntityState.Added)
                {
                  
                    addedEntityType.CreatedAt = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.State = EntityState.Modified;
                    addedEntityType.ModifiedAt = DateTime.Now;
                }
                if (entry.State == EntityState.Deleted)
                {
                    entry.State = EntityState.Unchanged;
                    addedEntityType.DeletedAt = DateTime.Now;
                }
            }
        }
    }
}
