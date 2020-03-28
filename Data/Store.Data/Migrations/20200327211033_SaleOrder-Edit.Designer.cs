﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Store.Data;

namespace Store.Data.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    [Migration("20200327211033_SaleOrder-Edit")]
    partial class SaleOrderEdit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Store.Models.Customer", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = "02fd5335-d604-42a5-8cea-bb26ed79444a",
                            AccountNumber = "123213",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 615, DateTimeKind.Local).AddTicks(9413),
                            UserId = "55ea4504-a20e-44d4-b6df-c86fc4c507b0"
                        },
                        new
                        {
                            Id = "608d9c82-c639-43d6-9597-faa9b6269c93",
                            AccountNumber = "134519",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 616, DateTimeKind.Local).AddTicks(64),
                            UserId = "e0035439-7f6d-4a9d-9ac2-e9af5aefe653"
                        },
                        new
                        {
                            Id = "a3bc76f5-b95a-4630-b48d-ac70cab7b245",
                            AccountNumber = "914311",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 616, DateTimeKind.Local).AddTicks(95),
                            UserId = "eba70ec3-0770-4eac-94ea-c9b67254c00b"
                        },
                        new
                        {
                            Id = "9465fa28-7508-4560-a1c6-a94ed0687941",
                            AccountNumber = "618299",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 616, DateTimeKind.Local).AddTicks(103),
                            UserId = "efb64ac7-a813-4b7b-b9e2-02fb6d665ee0"
                        },
                        new
                        {
                            Id = "f66a78ed-4434-45e2-a06a-5bc2c51421a8",
                            AccountNumber = "091234",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 616, DateTimeKind.Local).AddTicks(111),
                            UserId = "24f377fb-9236-4a49-9b3e-3e7eb84e7aa5"
                        });
                });

            modelBuilder.Entity("Store.Models.Department", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnName("Department_Name")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = "0eb8f59a-fe9c-4ff6-9a48-8f6ba992e515",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 615, DateTimeKind.Local).AddTicks(2129),
                            DepartmentName = "Sales"
                        },
                        new
                        {
                            Id = "c1eb11db-508a-4d73-8c06-d76695a79cae",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 615, DateTimeKind.Local).AddTicks(3373),
                            DepartmentName = "CEO"
                        },
                        new
                        {
                            Id = "895be692-5dd1-473c-8676-c15ae25a588b",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 615, DateTimeKind.Local).AddTicks(3435),
                            DepartmentName = "Warehouse"
                        });
                });

            modelBuilder.Entity("Store.Models.Employee", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DepartmentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EmployeeNumber")
                        .HasColumnName("Employee_Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = "896a489c-3078-4fb8-820b-9b3ab7e958e9",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 615, DateTimeKind.Local).AddTicks(4308),
                            DepartmentId = "0eb8f59a-fe9c-4ff6-9a48-8f6ba992e515",
                            UserId = "24f377fb-9236-4a49-9b3e-3e7eb84e7aa5"
                        },
                        new
                        {
                            Id = "522f0d25-920d-4391-b0be-111c725780f9",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 615, DateTimeKind.Local).AddTicks(4370),
                            DepartmentId = "0eb8f59a-fe9c-4ff6-9a48-8f6ba992e515",
                            UserId = "bfa6df45-1a6b-4946-876f-6d61560ba6c3"
                        },
                        new
                        {
                            Id = "e0291f81-7a11-46b4-ba6b-c02f9abf759d",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 615, DateTimeKind.Local).AddTicks(4387),
                            DepartmentId = "895be692-5dd1-473c-8676-c15ae25a588b",
                            UserId = "ed1450e4-2ccb-4a65-bd1d-001bcacce92d"
                        },
                        new
                        {
                            Id = "1f2cfaf9-23a1-4edc-ac9d-2f3706400daa",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 615, DateTimeKind.Local).AddTicks(4403),
                            DepartmentId = "895be692-5dd1-473c-8676-c15ae25a588b",
                            UserId = "7eef0335-c667-4204-af51-cb3a9e18d51f"
                        },
                        new
                        {
                            Id = "81deec43-4a71-4394-aed2-882bc5902244",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 615, DateTimeKind.Local).AddTicks(4416),
                            UserId = "b4b271f5-7bfb-4fd4-ab96-1ce6e2e9136e"
                        },
                        new
                        {
                            Id = "a7e01446-e088-4ec6-8252-df3d949914ea",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 615, DateTimeKind.Local).AddTicks(4428),
                            DepartmentId = "0eb8f59a-fe9c-4ff6-9a48-8f6ba992e515",
                            UserId = "1534cf5f-30db-4ff1-8f7d-0d34f654dabf"
                        });
                });

            modelBuilder.Entity("Store.Models.EmployeeCustomers", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeCustomers");

                    b.HasData(
                        new
                        {
                            Id = "32b9bd42-d851-401d-bac8-33533dc87ec1",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 619, DateTimeKind.Local).AddTicks(3405),
                            CustomerId = "02fd5335-d604-42a5-8cea-bb26ed79444a",
                            EmployeeId = "896a489c-3078-4fb8-820b-9b3ab7e958e9"
                        },
                        new
                        {
                            Id = "a203ee57-622a-475c-a8c1-5fa36127e4a2",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 619, DateTimeKind.Local).AddTicks(5786),
                            CustomerId = "608d9c82-c639-43d6-9597-faa9b6269c93",
                            EmployeeId = "896a489c-3078-4fb8-820b-9b3ab7e958e9"
                        },
                        new
                        {
                            Id = "a8715ad7-dde3-4255-8742-58d1693f8f72",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 619, DateTimeKind.Local).AddTicks(5873),
                            CustomerId = "02fd5335-d604-42a5-8cea-bb26ed79444a",
                            EmployeeId = "522f0d25-920d-4391-b0be-111c725780f9"
                        },
                        new
                        {
                            Id = "e06a9bc9-4162-437d-bb3e-5b21b6dbb9b8",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 619, DateTimeKind.Local).AddTicks(5883),
                            CustomerId = "608d9c82-c639-43d6-9597-faa9b6269c93",
                            EmployeeId = "522f0d25-920d-4391-b0be-111c725780f9"
                        },
                        new
                        {
                            Id = "55c88fe9-ae66-4cbf-bbf7-2d53cddd8a77",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 619, DateTimeKind.Local).AddTicks(5890),
                            CustomerId = "a3bc76f5-b95a-4630-b48d-ac70cab7b245",
                            EmployeeId = "522f0d25-920d-4391-b0be-111c725780f9"
                        },
                        new
                        {
                            Id = "d9f0fff0-4933-41ee-842e-fdd39e19a960",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 619, DateTimeKind.Local).AddTicks(5898),
                            CustomerId = "f66a78ed-4434-45e2-a06a-5bc2c51421a8",
                            EmployeeId = "896a489c-3078-4fb8-820b-9b3ab7e958e9"
                        },
                        new
                        {
                            Id = "8b80de2b-94af-48bb-a77c-266677d2f8dc",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 619, DateTimeKind.Local).AddTicks(5906),
                            CustomerId = "9465fa28-7508-4560-a1c6-a94ed0687941",
                            EmployeeId = "a7e01446-e088-4ec6-8252-df3d949914ea"
                        });
                });

            modelBuilder.Entity("Store.Models.Photo", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhotoDir")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ProductId1")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId1");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("Store.Models.Product", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("CurrentQuantity")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = "4860e880-e01a-4fac-8e6d-4ba5f6f4e582",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 616, DateTimeKind.Local).AddTicks(3099),
                            CurrentQuantity = 0,
                            Description = "product1",
                            ProductName = "Product1",
                            ProductPrice = 10m
                        },
                        new
                        {
                            Id = "43e970b0-0d0e-463a-92e1-c999588a3eba",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 616, DateTimeKind.Local).AddTicks(5518),
                            CurrentQuantity = 0,
                            Description = "product2",
                            ProductName = "Product2",
                            ProductPrice = 5m
                        },
                        new
                        {
                            Id = "663178ff-c40f-4f4d-98c0-59c9d2a842b5",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 616, DateTimeKind.Local).AddTicks(5580),
                            CurrentQuantity = 0,
                            Description = "product3",
                            ProductName = "Product3",
                            ProductPrice = 1m
                        },
                        new
                        {
                            Id = "492986b9-c84b-402d-b089-a13674a52230",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 616, DateTimeKind.Local).AddTicks(5656),
                            CurrentQuantity = 0,
                            Description = "product4",
                            ProductName = "Product4",
                            ProductPrice = 45m
                        },
                        new
                        {
                            Id = "dde4efe2-c0b5-4f58-b591-d5742761630c",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 616, DateTimeKind.Local).AddTicks(5664),
                            CurrentQuantity = 0,
                            Description = "product5",
                            ProductName = "Product5",
                            ProductPrice = 11m
                        },
                        new
                        {
                            Id = "496bc70e-400b-4c77-993b-0055d746117a",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 616, DateTimeKind.Local).AddTicks(5672),
                            CurrentQuantity = 0,
                            Description = "product6",
                            ProductName = "Product6",
                            ProductPrice = 19m
                        },
                        new
                        {
                            Id = "7b6376ab-24f4-4e1a-a6a0-fa6f107a6cdc",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 616, DateTimeKind.Local).AddTicks(5680),
                            CurrentQuantity = 0,
                            Description = "product7",
                            ProductName = "Product7",
                            ProductPrice = 2m
                        },
                        new
                        {
                            Id = "a23f8fcb-da5d-41ae-b005-e417fb69c80a",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 616, DateTimeKind.Local).AddTicks(5687),
                            CurrentQuantity = 0,
                            Description = "product8",
                            ProductName = "Product8",
                            ProductPrice = 22m
                        },
                        new
                        {
                            Id = "92b54840-f5b2-421a-bf9f-2ceb0504a015",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 616, DateTimeKind.Local).AddTicks(5695),
                            CurrentQuantity = 0,
                            Description = "product9",
                            ProductName = "Product9",
                            ProductPrice = 13m
                        },
                        new
                        {
                            Id = "7bdf0cac-7f5e-4290-9ad2-90a4edeb75d1",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 616, DateTimeKind.Local).AddTicks(5703),
                            CurrentQuantity = 0,
                            Description = "product10",
                            ProductName = "Product10",
                            ProductPrice = 100m
                        });
                });

            modelBuilder.Entity("Store.Models.SaleOrder", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateOfSale")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("ProductId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.ToTable("SaleOrders");

                    b.HasData(
                        new
                        {
                            Id = "08237c78-557c-4e0a-be1e-09ce243e64d3",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 619, DateTimeKind.Local).AddTicks(7154),
                            CustomerId = "02fd5335-d604-42a5-8cea-bb26ed79444a",
                            DateOfSale = new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = "896a489c-3078-4fb8-820b-9b3ab7e958e9",
                            ProductId = "4860e880-e01a-4fac-8e6d-4ba5f6f4e582",
                            Quantity = 10
                        },
                        new
                        {
                            Id = "be215960-2971-405c-919a-6362fe6a8bbb",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 620, DateTimeKind.Local).AddTicks(447),
                            CustomerId = "608d9c82-c639-43d6-9597-faa9b6269c93",
                            DateOfSale = new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = "896a489c-3078-4fb8-820b-9b3ab7e958e9",
                            ProductId = "43e970b0-0d0e-463a-92e1-c999588a3eba",
                            Quantity = 1
                        },
                        new
                        {
                            Id = "4ebd6f82-47da-4248-b50b-512d5050de3c",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 620, DateTimeKind.Local).AddTicks(523),
                            CustomerId = "608d9c82-c639-43d6-9597-faa9b6269c93",
                            DateOfSale = new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = "522f0d25-920d-4391-b0be-111c725780f9",
                            ProductId = "dde4efe2-c0b5-4f58-b591-d5742761630c",
                            Quantity = 8
                        },
                        new
                        {
                            Id = "2cfadd10-917a-42bc-a4de-83b9b51138b4",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 620, DateTimeKind.Local).AddTicks(534),
                            CustomerId = "a3bc76f5-b95a-4630-b48d-ac70cab7b245",
                            DateOfSale = new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = "522f0d25-920d-4391-b0be-111c725780f9",
                            ProductId = "92b54840-f5b2-421a-bf9f-2ceb0504a015",
                            Quantity = 100
                        },
                        new
                        {
                            Id = "c9fb0730-bec2-4b28-ba8f-0fe2ee2b16cd",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 620, DateTimeKind.Local).AddTicks(543),
                            CustomerId = "9465fa28-7508-4560-a1c6-a94ed0687941",
                            DateOfSale = new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = "896a489c-3078-4fb8-820b-9b3ab7e958e9",
                            ProductId = "7bdf0cac-7f5e-4290-9ad2-90a4edeb75d1",
                            Quantity = 7
                        },
                        new
                        {
                            Id = "5416fe0b-08c4-45f2-9c2b-c16de6bf2c02",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 620, DateTimeKind.Local).AddTicks(624),
                            CustomerId = "9465fa28-7508-4560-a1c6-a94ed0687941",
                            DateOfSale = new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = "a7e01446-e088-4ec6-8252-df3d949914ea",
                            ProductId = "663178ff-c40f-4f4d-98c0-59c9d2a842b5",
                            Quantity = 15
                        },
                        new
                        {
                            Id = "e044cb70-fc35-42ed-9c02-32b3bcaf7d25",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 620, DateTimeKind.Local).AddTicks(633),
                            CustomerId = "f66a78ed-4434-45e2-a06a-5bc2c51421a8",
                            DateOfSale = new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = "896a489c-3078-4fb8-820b-9b3ab7e958e9",
                            ProductId = "a23f8fcb-da5d-41ae-b005-e417fb69c80a",
                            Quantity = 100
                        },
                        new
                        {
                            Id = "c6713a1a-2add-436f-9fb2-85a8e2b04884",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 620, DateTimeKind.Local).AddTicks(641),
                            CustomerId = "02fd5335-d604-42a5-8cea-bb26ed79444a",
                            DateOfSale = new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = "522f0d25-920d-4391-b0be-111c725780f9",
                            ProductId = "4860e880-e01a-4fac-8e6d-4ba5f6f4e582",
                            Quantity = 4
                        },
                        new
                        {
                            Id = "18c56674-68e4-4524-81a6-6b4b677b2305",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 620, DateTimeKind.Local).AddTicks(649),
                            CustomerId = "608d9c82-c639-43d6-9597-faa9b6269c93",
                            DateOfSale = new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = "522f0d25-920d-4391-b0be-111c725780f9",
                            ProductId = "7b6376ab-24f4-4e1a-a6a0-fa6f107a6cdc",
                            Quantity = 8
                        },
                        new
                        {
                            Id = "34e033f1-c9ad-4682-941a-e7e25b2531cb",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 620, DateTimeKind.Local).AddTicks(661),
                            CustomerId = "608d9c82-c639-43d6-9597-faa9b6269c93",
                            DateOfSale = new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = "522f0d25-920d-4391-b0be-111c725780f9",
                            ProductId = "4860e880-e01a-4fac-8e6d-4ba5f6f4e582",
                            Quantity = 2
                        },
                        new
                        {
                            Id = "144293c8-b846-4b34-aa9e-3463c98ed33a",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 620, DateTimeKind.Local).AddTicks(669),
                            CustomerId = "f66a78ed-4434-45e2-a06a-5bc2c51421a8",
                            DateOfSale = new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = "a7e01446-e088-4ec6-8252-df3d949914ea",
                            ProductId = "43e970b0-0d0e-463a-92e1-c999588a3eba",
                            Quantity = 10
                        },
                        new
                        {
                            Id = "05602d69-d4a0-49b8-a685-6f55f36f6931",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 620, DateTimeKind.Local).AddTicks(675),
                            CustomerId = "f66a78ed-4434-45e2-a06a-5bc2c51421a8",
                            DateOfSale = new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = "896a489c-3078-4fb8-820b-9b3ab7e958e9",
                            ProductId = "43e970b0-0d0e-463a-92e1-c999588a3eba",
                            Quantity = 10
                        },
                        new
                        {
                            Id = "7ed590d7-d5fb-4b76-94f8-e9113ee3a707",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 620, DateTimeKind.Local).AddTicks(683),
                            CustomerId = "02fd5335-d604-42a5-8cea-bb26ed79444a",
                            DateOfSale = new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = "522f0d25-920d-4391-b0be-111c725780f9",
                            ProductId = "92b54840-f5b2-421a-bf9f-2ceb0504a015",
                            Quantity = 19
                        });
                });

            modelBuilder.Entity("Store.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = "24f377fb-9236-4a49-9b3e-3e7eb84e7aa5",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 610, DateTimeKind.Local).AddTicks(7893),
                            Email = "user1@ba.bg",
                            Password = "very very hashed",
                            Telephone = "222-222-222"
                        },
                        new
                        {
                            Id = "bfa6df45-1a6b-4946-876f-6d61560ba6c3",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 614, DateTimeKind.Local).AddTicks(6974),
                            Email = "user2@ba.bg",
                            Password = "very very hashed",
                            Telephone = "443-111-222"
                        },
                        new
                        {
                            Id = "ed1450e4-2ccb-4a65-bd1d-001bcacce92d",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 614, DateTimeKind.Local).AddTicks(7103),
                            Email = "user3@ba.bg",
                            Password = "very very hashed",
                            Telephone = "443-122-222"
                        },
                        new
                        {
                            Id = "7eef0335-c667-4204-af51-cb3a9e18d51f",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 614, DateTimeKind.Local).AddTicks(7257),
                            Email = "user4@ba.bg",
                            Password = "very very hashed",
                            Telephone = "443-431-222"
                        },
                        new
                        {
                            Id = "b4b271f5-7bfb-4fd4-ab96-1ce6e2e9136e",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 614, DateTimeKind.Local).AddTicks(7271),
                            Email = "user5@ba.bg",
                            Password = "very very hashed",
                            Telephone = "443-111-857"
                        },
                        new
                        {
                            Id = "1534cf5f-30db-4ff1-8f7d-0d34f654dabf",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 614, DateTimeKind.Local).AddTicks(7285),
                            Email = "user6@ba.bg",
                            Password = "very very hashed",
                            Telephone = "443-111-347"
                        },
                        new
                        {
                            Id = "55ea4504-a20e-44d4-b6df-c86fc4c507b0",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 614, DateTimeKind.Local).AddTicks(7318),
                            Email = "user7@ba.bg",
                            Password = "very very hashed",
                            Telephone = "443-111-987"
                        },
                        new
                        {
                            Id = "e0035439-7f6d-4a9d-9ac2-e9af5aefe653",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 614, DateTimeKind.Local).AddTicks(7332),
                            Email = "user8@ba.bg",
                            Password = "very very hashed",
                            Telephone = "443-111-654"
                        },
                        new
                        {
                            Id = "eba70ec3-0770-4eac-94ea-c9b67254c00b",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 614, DateTimeKind.Local).AddTicks(7346),
                            Email = "user9@ba.bg",
                            Password = "very very hashed",
                            Telephone = "443-111-556"
                        },
                        new
                        {
                            Id = "efb64ac7-a813-4b7b-b9e2-02fb6d665ee0",
                            CreatedAt = new DateTime(2020, 3, 27, 23, 10, 32, 614, DateTimeKind.Local).AddTicks(7361),
                            Email = "user10@ba.bg",
                            Password = "very very hashed",
                            Telephone = "443-111-478"
                        });
                });

            modelBuilder.Entity("Store.Models.Customer", b =>
                {
                    b.HasOne("Store.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Store.Models.Employee", b =>
                {
                    b.HasOne("Store.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId");

                    b.HasOne("Store.Models.User", "User")
                        .WithOne("Employee")
                        .HasForeignKey("Store.Models.Employee", "UserId");
                });

            modelBuilder.Entity("Store.Models.EmployeeCustomers", b =>
                {
                    b.HasOne("Store.Models.Customer", "Customer")
                        .WithMany("EmployeeCustomers")
                        .HasForeignKey("CustomerId");

                    b.HasOne("Store.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");
                });

            modelBuilder.Entity("Store.Models.Photo", b =>
                {
                    b.HasOne("Store.Models.Product", "Product")
                        .WithMany("Photos")
                        .HasForeignKey("ProductId1");
                });

            modelBuilder.Entity("Store.Models.SaleOrder", b =>
                {
                    b.HasOne("Store.Models.Customer", "Customer")
                        .WithMany("SaleOrders")
                        .HasForeignKey("CustomerId");

                    b.HasOne("Store.Models.Product", "Product")
                        .WithMany("SalesOrders")
                        .HasForeignKey("ProductId");
                });
#pragma warning restore 612, 618
        }
    }
}