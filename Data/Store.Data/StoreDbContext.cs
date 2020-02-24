using Microsoft.EntityFrameworkCore;
using Store.Models;
using Store.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Store.Data
{
    public class StoreDbContext:DbContext
    {
        public StoreDbContext()
        {

        }
        public DbSet<User> Users { get; set; }
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
            modelBuilder.Entity<User>().HasData(new User() { Id = Guid.NewGuid(), Email = "test@ba.bg", Password = "very very hashed", CreatedAt = DateTime.Now, Telephone = "222-222-222" });

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=;Database=;Trusted_Connection=True;");

        }

        //Кодът по-долу го използвам за улеснение при промяна или добавяне на нов обект, като вземам от ChangeTracker-а всички ентитита, от някакъв тип, в случая от интерфейса IAuditInfo и според това каква операция се извършва върху тях променям или добавям датата. Така се избягва отново преизползването на код и добавянето на дати в случая при всяко създаване или модифициране на клас. Това е advance подход, но не е излишно да го знаете.
        public override int SaveChanges()
        {

            return base.SaveChanges(true);

        }
        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            this.ApplyEntityChanges();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }
        private void ApplyEntityChanges()
        {
            var entities = this.ChangeTracker.Entries().Where(x => (x.Entity is IAuditInfo) && (x.State == EntityState.Added || x.State == EntityState.Modified || x.State == EntityState.Deleted));
            foreach (var entity in entities)
            {
                var addedEntityType = entity as IAuditInfo;
                if (entity.State == EntityState.Added || entity.State == default)
                {

                    addedEntityType.CreatedAt = DateTime.Now;
                }

                if (entity.State == EntityState.Modified)
                {

                    addedEntityType.ModifiedAt = DateTime.Now;
                }
                if (entity.State == EntityState.Deleted)
                {

                    addedEntityType.DeletedAt = DateTime.Now;
                }
            }
        }
    }
}
