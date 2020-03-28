using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Store.Data.Migrations
{
    public partial class SaleOrderEdit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    Department_Name = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    ProductName = table.Column<string>(maxLength: 20, nullable: false),
                    Description = table.Column<string>(maxLength: 300, nullable: true),
                    ProductPrice = table.Column<decimal>(nullable: false),
                    CurrentQuantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    Email = table.Column<string>(maxLength: 30, nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Telephone = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    PhotoDir = table.Column<string>(nullable: true),
                    ImageType = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: true),
                    ProductId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photos_Products_ProductId1",
                        column: x => x.ProductId1,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    AccountNumber = table.Column<string>(maxLength: 10, nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    Employee_Number = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    DepartmentId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SaleOrders",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    DateOfSale = table.Column<DateTime>(nullable: false),
                    Note = table.Column<string>(maxLength: 200, nullable: true),
                    CustomerId = table.Column<string>(nullable: true),
                    ProductId = table.Column<string>(nullable: true),
                    EmployeeId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SaleOrders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SaleOrders_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeCustomers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    EmployeeId = table.Column<string>(nullable: true),
                    CustomerId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeCustomers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeCustomers_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeCustomers_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Department_Name", "ModifiedAt" },
                values: new object[,]
                {
                    { "0eb8f59a-fe9c-4ff6-9a48-8f6ba992e515", new DateTime(2020, 3, 27, 23, 10, 32, 615, DateTimeKind.Local).AddTicks(2129), null, "Sales", null },
                    { "c1eb11db-508a-4d73-8c06-d76695a79cae", new DateTime(2020, 3, 27, 23, 10, 32, 615, DateTimeKind.Local).AddTicks(3373), null, "CEO", null },
                    { "895be692-5dd1-473c-8676-c15ae25a588b", new DateTime(2020, 3, 27, 23, 10, 32, 615, DateTimeKind.Local).AddTicks(3435), null, "Warehouse", null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "CurrentQuantity", "DeletedAt", "Description", "ModifiedAt", "ProductName", "ProductPrice" },
                values: new object[,]
                {
                    { "7bdf0cac-7f5e-4290-9ad2-90a4edeb75d1", new DateTime(2020, 3, 27, 23, 10, 32, 616, DateTimeKind.Local).AddTicks(5703), 0, null, "product10", null, "Product10", 100m },
                    { "a23f8fcb-da5d-41ae-b005-e417fb69c80a", new DateTime(2020, 3, 27, 23, 10, 32, 616, DateTimeKind.Local).AddTicks(5687), 0, null, "product8", null, "Product8", 22m },
                    { "7b6376ab-24f4-4e1a-a6a0-fa6f107a6cdc", new DateTime(2020, 3, 27, 23, 10, 32, 616, DateTimeKind.Local).AddTicks(5680), 0, null, "product7", null, "Product7", 2m },
                    { "496bc70e-400b-4c77-993b-0055d746117a", new DateTime(2020, 3, 27, 23, 10, 32, 616, DateTimeKind.Local).AddTicks(5672), 0, null, "product6", null, "Product6", 19m },
                    { "92b54840-f5b2-421a-bf9f-2ceb0504a015", new DateTime(2020, 3, 27, 23, 10, 32, 616, DateTimeKind.Local).AddTicks(5695), 0, null, "product9", null, "Product9", 13m },
                    { "492986b9-c84b-402d-b089-a13674a52230", new DateTime(2020, 3, 27, 23, 10, 32, 616, DateTimeKind.Local).AddTicks(5656), 0, null, "product4", null, "Product4", 45m },
                    { "663178ff-c40f-4f4d-98c0-59c9d2a842b5", new DateTime(2020, 3, 27, 23, 10, 32, 616, DateTimeKind.Local).AddTicks(5580), 0, null, "product3", null, "Product3", 1m },
                    { "43e970b0-0d0e-463a-92e1-c999588a3eba", new DateTime(2020, 3, 27, 23, 10, 32, 616, DateTimeKind.Local).AddTicks(5518), 0, null, "product2", null, "Product2", 5m },
                    { "4860e880-e01a-4fac-8e6d-4ba5f6f4e582", new DateTime(2020, 3, 27, 23, 10, 32, 616, DateTimeKind.Local).AddTicks(3099), 0, null, "product1", null, "Product1", 10m },
                    { "dde4efe2-c0b5-4f58-b591-d5742761630c", new DateTime(2020, 3, 27, 23, 10, 32, 616, DateTimeKind.Local).AddTicks(5664), 0, null, "product5", null, "Product5", 11m }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Email", "ModifiedAt", "Password", "Telephone" },
                values: new object[,]
                {
                    { "eba70ec3-0770-4eac-94ea-c9b67254c00b", new DateTime(2020, 3, 27, 23, 10, 32, 614, DateTimeKind.Local).AddTicks(7346), null, "user9@ba.bg", null, "very very hashed", "443-111-556" },
                    { "24f377fb-9236-4a49-9b3e-3e7eb84e7aa5", new DateTime(2020, 3, 27, 23, 10, 32, 610, DateTimeKind.Local).AddTicks(7893), null, "user1@ba.bg", null, "very very hashed", "222-222-222" },
                    { "bfa6df45-1a6b-4946-876f-6d61560ba6c3", new DateTime(2020, 3, 27, 23, 10, 32, 614, DateTimeKind.Local).AddTicks(6974), null, "user2@ba.bg", null, "very very hashed", "443-111-222" },
                    { "ed1450e4-2ccb-4a65-bd1d-001bcacce92d", new DateTime(2020, 3, 27, 23, 10, 32, 614, DateTimeKind.Local).AddTicks(7103), null, "user3@ba.bg", null, "very very hashed", "443-122-222" },
                    { "7eef0335-c667-4204-af51-cb3a9e18d51f", new DateTime(2020, 3, 27, 23, 10, 32, 614, DateTimeKind.Local).AddTicks(7257), null, "user4@ba.bg", null, "very very hashed", "443-431-222" },
                    { "b4b271f5-7bfb-4fd4-ab96-1ce6e2e9136e", new DateTime(2020, 3, 27, 23, 10, 32, 614, DateTimeKind.Local).AddTicks(7271), null, "user5@ba.bg", null, "very very hashed", "443-111-857" },
                    { "1534cf5f-30db-4ff1-8f7d-0d34f654dabf", new DateTime(2020, 3, 27, 23, 10, 32, 614, DateTimeKind.Local).AddTicks(7285), null, "user6@ba.bg", null, "very very hashed", "443-111-347" },
                    { "55ea4504-a20e-44d4-b6df-c86fc4c507b0", new DateTime(2020, 3, 27, 23, 10, 32, 614, DateTimeKind.Local).AddTicks(7318), null, "user7@ba.bg", null, "very very hashed", "443-111-987" },
                    { "e0035439-7f6d-4a9d-9ac2-e9af5aefe653", new DateTime(2020, 3, 27, 23, 10, 32, 614, DateTimeKind.Local).AddTicks(7332), null, "user8@ba.bg", null, "very very hashed", "443-111-654" },
                    { "efb64ac7-a813-4b7b-b9e2-02fb6d665ee0", new DateTime(2020, 3, 27, 23, 10, 32, 614, DateTimeKind.Local).AddTicks(7361), null, "user10@ba.bg", null, "very very hashed", "443-111-478" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "AccountNumber", "CreatedAt", "DeletedAt", "ModifiedAt", "UserId" },
                values: new object[,]
                {
                    { "f66a78ed-4434-45e2-a06a-5bc2c51421a8", "091234", new DateTime(2020, 3, 27, 23, 10, 32, 616, DateTimeKind.Local).AddTicks(111), null, null, "24f377fb-9236-4a49-9b3e-3e7eb84e7aa5" },
                    { "02fd5335-d604-42a5-8cea-bb26ed79444a", "123213", new DateTime(2020, 3, 27, 23, 10, 32, 615, DateTimeKind.Local).AddTicks(9413), null, null, "55ea4504-a20e-44d4-b6df-c86fc4c507b0" },
                    { "608d9c82-c639-43d6-9597-faa9b6269c93", "134519", new DateTime(2020, 3, 27, 23, 10, 32, 616, DateTimeKind.Local).AddTicks(64), null, null, "e0035439-7f6d-4a9d-9ac2-e9af5aefe653" },
                    { "a3bc76f5-b95a-4630-b48d-ac70cab7b245", "914311", new DateTime(2020, 3, 27, 23, 10, 32, 616, DateTimeKind.Local).AddTicks(95), null, null, "eba70ec3-0770-4eac-94ea-c9b67254c00b" },
                    { "9465fa28-7508-4560-a1c6-a94ed0687941", "618299", new DateTime(2020, 3, 27, 23, 10, 32, 616, DateTimeKind.Local).AddTicks(103), null, null, "efb64ac7-a813-4b7b-b9e2-02fb6d665ee0" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "DepartmentId", "Employee_Number", "ModifiedAt", "UserId" },
                values: new object[,]
                {
                    { "896a489c-3078-4fb8-820b-9b3ab7e958e9", new DateTime(2020, 3, 27, 23, 10, 32, 615, DateTimeKind.Local).AddTicks(4308), null, "0eb8f59a-fe9c-4ff6-9a48-8f6ba992e515", null, null, "24f377fb-9236-4a49-9b3e-3e7eb84e7aa5" },
                    { "522f0d25-920d-4391-b0be-111c725780f9", new DateTime(2020, 3, 27, 23, 10, 32, 615, DateTimeKind.Local).AddTicks(4370), null, "0eb8f59a-fe9c-4ff6-9a48-8f6ba992e515", null, null, "bfa6df45-1a6b-4946-876f-6d61560ba6c3" },
                    { "e0291f81-7a11-46b4-ba6b-c02f9abf759d", new DateTime(2020, 3, 27, 23, 10, 32, 615, DateTimeKind.Local).AddTicks(4387), null, "895be692-5dd1-473c-8676-c15ae25a588b", null, null, "ed1450e4-2ccb-4a65-bd1d-001bcacce92d" },
                    { "1f2cfaf9-23a1-4edc-ac9d-2f3706400daa", new DateTime(2020, 3, 27, 23, 10, 32, 615, DateTimeKind.Local).AddTicks(4403), null, "895be692-5dd1-473c-8676-c15ae25a588b", null, null, "7eef0335-c667-4204-af51-cb3a9e18d51f" },
                    { "81deec43-4a71-4394-aed2-882bc5902244", new DateTime(2020, 3, 27, 23, 10, 32, 615, DateTimeKind.Local).AddTicks(4416), null, null, null, null, "b4b271f5-7bfb-4fd4-ab96-1ce6e2e9136e" },
                    { "a7e01446-e088-4ec6-8252-df3d949914ea", new DateTime(2020, 3, 27, 23, 10, 32, 615, DateTimeKind.Local).AddTicks(4428), null, "0eb8f59a-fe9c-4ff6-9a48-8f6ba992e515", null, null, "1534cf5f-30db-4ff1-8f7d-0d34f654dabf" }
                });

            migrationBuilder.InsertData(
                table: "EmployeeCustomers",
                columns: new[] { "Id", "CreatedAt", "CustomerId", "DeletedAt", "EmployeeId", "ModifiedAt" },
                values: new object[,]
                {
                    { "a203ee57-622a-475c-a8c1-5fa36127e4a2", new DateTime(2020, 3, 27, 23, 10, 32, 619, DateTimeKind.Local).AddTicks(5786), "608d9c82-c639-43d6-9597-faa9b6269c93", null, "896a489c-3078-4fb8-820b-9b3ab7e958e9", null },
                    { "8b80de2b-94af-48bb-a77c-266677d2f8dc", new DateTime(2020, 3, 27, 23, 10, 32, 619, DateTimeKind.Local).AddTicks(5906), "9465fa28-7508-4560-a1c6-a94ed0687941", null, "a7e01446-e088-4ec6-8252-df3d949914ea", null },
                    { "d9f0fff0-4933-41ee-842e-fdd39e19a960", new DateTime(2020, 3, 27, 23, 10, 32, 619, DateTimeKind.Local).AddTicks(5898), "f66a78ed-4434-45e2-a06a-5bc2c51421a8", null, "896a489c-3078-4fb8-820b-9b3ab7e958e9", null },
                    { "32b9bd42-d851-401d-bac8-33533dc87ec1", new DateTime(2020, 3, 27, 23, 10, 32, 619, DateTimeKind.Local).AddTicks(3405), "02fd5335-d604-42a5-8cea-bb26ed79444a", null, "896a489c-3078-4fb8-820b-9b3ab7e958e9", null },
                    { "a8715ad7-dde3-4255-8742-58d1693f8f72", new DateTime(2020, 3, 27, 23, 10, 32, 619, DateTimeKind.Local).AddTicks(5873), "02fd5335-d604-42a5-8cea-bb26ed79444a", null, "522f0d25-920d-4391-b0be-111c725780f9", null },
                    { "55c88fe9-ae66-4cbf-bbf7-2d53cddd8a77", new DateTime(2020, 3, 27, 23, 10, 32, 619, DateTimeKind.Local).AddTicks(5890), "a3bc76f5-b95a-4630-b48d-ac70cab7b245", null, "522f0d25-920d-4391-b0be-111c725780f9", null },
                    { "e06a9bc9-4162-437d-bb3e-5b21b6dbb9b8", new DateTime(2020, 3, 27, 23, 10, 32, 619, DateTimeKind.Local).AddTicks(5883), "608d9c82-c639-43d6-9597-faa9b6269c93", null, "522f0d25-920d-4391-b0be-111c725780f9", null }
                });

            migrationBuilder.InsertData(
                table: "SaleOrders",
                columns: new[] { "Id", "CreatedAt", "CustomerId", "DateOfSale", "DeletedAt", "EmployeeId", "ModifiedAt", "Note", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { "2cfadd10-917a-42bc-a4de-83b9b51138b4", new DateTime(2020, 3, 27, 23, 10, 32, 620, DateTimeKind.Local).AddTicks(534), "a3bc76f5-b95a-4630-b48d-ac70cab7b245", new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "522f0d25-920d-4391-b0be-111c725780f9", null, null, "92b54840-f5b2-421a-bf9f-2ceb0504a015", 100 },
                    { "34e033f1-c9ad-4682-941a-e7e25b2531cb", new DateTime(2020, 3, 27, 23, 10, 32, 620, DateTimeKind.Local).AddTicks(661), "608d9c82-c639-43d6-9597-faa9b6269c93", new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "522f0d25-920d-4391-b0be-111c725780f9", null, null, "4860e880-e01a-4fac-8e6d-4ba5f6f4e582", 2 },
                    { "18c56674-68e4-4524-81a6-6b4b677b2305", new DateTime(2020, 3, 27, 23, 10, 32, 620, DateTimeKind.Local).AddTicks(649), "608d9c82-c639-43d6-9597-faa9b6269c93", new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "522f0d25-920d-4391-b0be-111c725780f9", null, null, "7b6376ab-24f4-4e1a-a6a0-fa6f107a6cdc", 8 },
                    { "4ebd6f82-47da-4248-b50b-512d5050de3c", new DateTime(2020, 3, 27, 23, 10, 32, 620, DateTimeKind.Local).AddTicks(523), "608d9c82-c639-43d6-9597-faa9b6269c93", new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "522f0d25-920d-4391-b0be-111c725780f9", null, null, "dde4efe2-c0b5-4f58-b591-d5742761630c", 8 },
                    { "e044cb70-fc35-42ed-9c02-32b3bcaf7d25", new DateTime(2020, 3, 27, 23, 10, 32, 620, DateTimeKind.Local).AddTicks(633), "f66a78ed-4434-45e2-a06a-5bc2c51421a8", new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "896a489c-3078-4fb8-820b-9b3ab7e958e9", null, null, "a23f8fcb-da5d-41ae-b005-e417fb69c80a", 100 },
                    { "c9fb0730-bec2-4b28-ba8f-0fe2ee2b16cd", new DateTime(2020, 3, 27, 23, 10, 32, 620, DateTimeKind.Local).AddTicks(543), "9465fa28-7508-4560-a1c6-a94ed0687941", new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "896a489c-3078-4fb8-820b-9b3ab7e958e9", null, null, "7bdf0cac-7f5e-4290-9ad2-90a4edeb75d1", 7 },
                    { "7ed590d7-d5fb-4b76-94f8-e9113ee3a707", new DateTime(2020, 3, 27, 23, 10, 32, 620, DateTimeKind.Local).AddTicks(683), "02fd5335-d604-42a5-8cea-bb26ed79444a", new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "522f0d25-920d-4391-b0be-111c725780f9", null, null, "92b54840-f5b2-421a-bf9f-2ceb0504a015", 19 },
                    { "c6713a1a-2add-436f-9fb2-85a8e2b04884", new DateTime(2020, 3, 27, 23, 10, 32, 620, DateTimeKind.Local).AddTicks(641), "02fd5335-d604-42a5-8cea-bb26ed79444a", new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "522f0d25-920d-4391-b0be-111c725780f9", null, null, "4860e880-e01a-4fac-8e6d-4ba5f6f4e582", 4 },
                    { "08237c78-557c-4e0a-be1e-09ce243e64d3", new DateTime(2020, 3, 27, 23, 10, 32, 619, DateTimeKind.Local).AddTicks(7154), "02fd5335-d604-42a5-8cea-bb26ed79444a", new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "896a489c-3078-4fb8-820b-9b3ab7e958e9", null, null, "4860e880-e01a-4fac-8e6d-4ba5f6f4e582", 10 },
                    { "05602d69-d4a0-49b8-a685-6f55f36f6931", new DateTime(2020, 3, 27, 23, 10, 32, 620, DateTimeKind.Local).AddTicks(675), "f66a78ed-4434-45e2-a06a-5bc2c51421a8", new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "896a489c-3078-4fb8-820b-9b3ab7e958e9", null, null, "43e970b0-0d0e-463a-92e1-c999588a3eba", 10 },
                    { "144293c8-b846-4b34-aa9e-3463c98ed33a", new DateTime(2020, 3, 27, 23, 10, 32, 620, DateTimeKind.Local).AddTicks(669), "f66a78ed-4434-45e2-a06a-5bc2c51421a8", new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "a7e01446-e088-4ec6-8252-df3d949914ea", null, null, "43e970b0-0d0e-463a-92e1-c999588a3eba", 10 },
                    { "be215960-2971-405c-919a-6362fe6a8bbb", new DateTime(2020, 3, 27, 23, 10, 32, 620, DateTimeKind.Local).AddTicks(447), "608d9c82-c639-43d6-9597-faa9b6269c93", new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "896a489c-3078-4fb8-820b-9b3ab7e958e9", null, null, "43e970b0-0d0e-463a-92e1-c999588a3eba", 1 },
                    { "5416fe0b-08c4-45f2-9c2b-c16de6bf2c02", new DateTime(2020, 3, 27, 23, 10, 32, 620, DateTimeKind.Local).AddTicks(624), "9465fa28-7508-4560-a1c6-a94ed0687941", new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "a7e01446-e088-4ec6-8252-df3d949914ea", null, null, "663178ff-c40f-4f4d-98c0-59c9d2a842b5", 15 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_UserId",
                table: "Customers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeCustomers_CustomerId",
                table: "EmployeeCustomers",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeCustomers_EmployeeId",
                table: "EmployeeCustomers",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_UserId",
                table: "Employees",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_ProductId1",
                table: "Photos",
                column: "ProductId1");

            migrationBuilder.CreateIndex(
                name: "IX_SaleOrders_CustomerId",
                table: "SaleOrders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleOrders_ProductId",
                table: "SaleOrders",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeCustomers");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "SaleOrders");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
