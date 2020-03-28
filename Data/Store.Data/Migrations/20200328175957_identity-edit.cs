using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Store.Data.Migrations
{
    public partial class identityedit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Email = table.Column<string>(maxLength: 256, nullable: false),
                    Telephone = table.Column<string>(maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        name: "FK_Customers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
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
                        name: "FK_Employees_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "DeletedAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "ModifiedAt", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Telephone", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4fee8d86-bed2-48df-9b2c-f02835b35099", 0, "6779cf34-3c32-4a4e-82f8-2a8f08f52b8b", new DateTime(2020, 3, 28, 19, 59, 56, 628, DateTimeKind.Local).AddTicks(7896), null, "user10@ba.bg", false, false, null, null, "USER10@BA.BG", null, "AQAAAAEAACcQAAAAENI86EpO2CpaCc9AAFlmBI7IizVT84RuuqX/eLzlYh+yxb3HY3JI1chDwVOggW1Wsw==", null, false, "10235585-f192-4399-9c91-0509039fe9b6", "443-111-478", false, null },
                    { "71ae1df7-a006-4a2b-b0a5-31cf12583ac9", 0, "bd74e3d0-102d-4ed4-84dc-d3733cfe1668", new DateTime(2020, 3, 28, 19, 59, 56, 628, DateTimeKind.Local).AddTicks(7865), null, "user8@ba.bg", false, false, null, null, "USER8@BA.BG", null, "AQAAAAEAACcQAAAAEEaepcLJWZ7kkuK+984oQJol8IKQtrZRsyn+dNS9s0u62SmIykGLL24u8THb4skX8Q==", null, false, "4f2d6217-dfb3-43b5-82ff-1544aa125cb1", "443-111-654", false, null },
                    { "0dcd5437-0bc7-40ba-b87b-5d5f5e177929", 0, "42cc57f9-a34c-4cbe-aaab-fcb2c47478b6", new DateTime(2020, 3, 28, 19, 59, 56, 628, DateTimeKind.Local).AddTicks(7847), null, "user7@ba.bg", false, false, null, null, "USER7@BA.BG", null, "AQAAAAEAACcQAAAAEHAMQI2JpS0F3W3gyMROgiMnRWT769HiPzYShSFyk94By+ENkB/lkiwSCLIFi+KpRg==", null, false, "6a7283a8-6e34-49c8-bd48-bbc9a1521081", "443-111-987", false, null },
                    { "819c826b-b24f-4f01-bef4-57b21a092a1b", 0, "44f82615-d731-487e-ad06-cabf28db4ebc", new DateTime(2020, 3, 28, 19, 59, 56, 628, DateTimeKind.Local).AddTicks(7768), null, "user6@ba.bg", false, false, null, null, "USER6@BA.BG", null, "AQAAAAEAACcQAAAAENndrTCXHaKtyYm9tfodClhpSa0ftGTzM5rBY6/FM9FMH3w6hTdrhBtTY68hO71pug==", null, false, "87f802c5-4622-4a87-ae2d-991d395c62e9", "443-111-347", false, null },
                    { "ce6ad629-339a-475b-bc6c-198fca6a03a3", 0, "05fc2d30-f330-4045-b5c3-9da5e6fbda1e", new DateTime(2020, 3, 28, 19, 59, 56, 628, DateTimeKind.Local).AddTicks(7752), null, "user5@ba.bg", false, false, null, null, "USER5@BA.BG", null, "AQAAAAEAACcQAAAAEPwtUqCxPpBwXvFynDxyBjoGHO8FUigUIKebkhp/sz8gyQqxJUehJev039DIFIC7Bg==", null, false, "2a41f14c-eb60-4212-ae86-c7a49feefd35", "443-111-857", false, null },
                    { "d08a0aa9-3dfd-4dd5-a0fd-2b92a98957dd", 0, "61c06445-e7f8-4ef1-8f75-9f58ff1c7467", new DateTime(2020, 3, 28, 19, 59, 56, 628, DateTimeKind.Local).AddTicks(7738), null, "user4@ba.bg", false, false, null, null, "USER4@BA.BG", null, "AQAAAAEAACcQAAAAEAPeBntJdVe/WUW82VCJ1ilMcAhP3g+2PWqIr4DLs1d5AzD3kthMZAt9Ym5N3frXvg==", null, false, "fbd76d36-c196-4a1d-9631-a6427f6bbba4", "443-431-222", false, null },
                    { "8596e3f0-646b-4f4f-9a29-26e46a3eff93", 0, "f2c5beaf-e166-4506-be4b-2df5912f003f", new DateTime(2020, 3, 28, 19, 59, 56, 628, DateTimeKind.Local).AddTicks(7712), null, "user3@ba.bg", false, false, null, null, "USER3@BA.BG", null, "AQAAAAEAACcQAAAAECXkkjJ4hfwe2eAAdNxGaAX/gU1vesURr54zBv/BGBrp2TgjKsIFh+wn1BJXvUARhg==", null, false, "01dc99ca-69b4-41f0-92a1-4fb2d363bc98", "443-122-222", false, null },
                    { "597d6bd2-63db-4a77-8194-bf7ba6e0872f", 0, "ef8bd5bf-045d-498f-87d6-52f6409633a7", new DateTime(2020, 3, 28, 19, 59, 56, 628, DateTimeKind.Local).AddTicks(7625), null, "user2@ba.bg", false, false, null, null, "USER2@BA.BG", null, "AQAAAAEAACcQAAAAEM+yUatBpqyAucVarYgcJV+yYS62NmTDuYkKOLyI/d7r5kIdKG/2lWuldtfTAmwCnQ==", null, false, "2cb46ae3-224e-4ceb-a26f-3a79bc040f29", "443-111-222", false, null },
                    { "4696c10b-8fd9-4dc3-b70d-9a4a9cd60aa8", 0, "230bb3a4-b2be-4e89-bf8c-74e40275b30e", new DateTime(2020, 3, 28, 19, 59, 56, 625, DateTimeKind.Local).AddTicks(2734), null, "user1@ba.bg", false, false, null, null, "USER1@BA.BG", null, "AQAAAAEAACcQAAAAEJg9sRcPMYkP2IIofYVlgEXlAeHYBMAK1D6N44fk/AUHzK8QiGnFpodF/Btz+aYhnQ==", null, false, "39fc85b9-f8d9-4860-bd13-713ac2e92cb7", "222-222-222", false, null },
                    { "3c452363-ea64-4fac-934c-95a8c892fb04", 0, "325b3fc8-87ea-4035-8bf3-7aed627b0a82", new DateTime(2020, 3, 28, 19, 59, 56, 628, DateTimeKind.Local).AddTicks(7880), null, "user9@ba.bg", false, false, null, null, "USER9@BA.BG", null, "AQAAAAEAACcQAAAAELwySTvK6m+GCOyBMw1TSfJfgBnC5WBhuzwEeHofQVM37n8t9//SuGnfSjxKzj0Z1w==", null, false, "daabcee1-1c4f-4b57-95b8-c8aef9c7bb28", "443-111-556", false, null }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Department_Name", "ModifiedAt" },
                values: new object[,]
                {
                    { "e7ee5f0b-3ef0-4959-bf12-5c25f2fa8c8f", new DateTime(2020, 3, 28, 19, 59, 56, 714, DateTimeKind.Local).AddTicks(8503), null, "Sales", null },
                    { "ff24da7e-d0fe-4452-88c6-6a0636e6e8ad", new DateTime(2020, 3, 28, 19, 59, 56, 714, DateTimeKind.Local).AddTicks(9878), null, "Warehouse", null },
                    { "76676194-ad55-41a0-a515-6f8ca54b1791", new DateTime(2020, 3, 28, 19, 59, 56, 714, DateTimeKind.Local).AddTicks(9836), null, "CEO", null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "CurrentQuantity", "DeletedAt", "Description", "ModifiedAt", "ProductName", "ProductPrice" },
                values: new object[,]
                {
                    { "05edd358-f76a-4c0b-8ae3-d252448b9ffe", new DateTime(2020, 3, 28, 19, 59, 56, 716, DateTimeKind.Local).AddTicks(546), 0, null, "product7", null, "Product7", 2m },
                    { "ea014a4f-0aca-4953-adce-5eb4c381912e", new DateTime(2020, 3, 28, 19, 59, 56, 716, DateTimeKind.Local).AddTicks(579), 0, null, "product10", null, "Product10", 100m },
                    { "3061b56a-d4af-43cf-8f0c-dfbda75138c1", new DateTime(2020, 3, 28, 19, 59, 56, 716, DateTimeKind.Local).AddTicks(428), 0, null, "product6", null, "Product6", 19m },
                    { "b28596e7-1d8d-468a-b682-2dc115bb1c8b", new DateTime(2020, 3, 28, 19, 59, 56, 716, DateTimeKind.Local).AddTicks(420), 0, null, "product5", null, "Product5", 11m },
                    { "2b4acedf-3b88-47dd-ab3b-e30904468fee", new DateTime(2020, 3, 28, 19, 59, 56, 716, DateTimeKind.Local).AddTicks(413), 0, null, "product4", null, "Product4", 45m },
                    { "d83737cb-40a0-4cc1-8cb5-ccf335148863", new DateTime(2020, 3, 28, 19, 59, 56, 716, DateTimeKind.Local).AddTicks(403), 0, null, "product3", null, "Product3", 1m },
                    { "ddc924a7-8a83-4781-b7dc-866da899525f", new DateTime(2020, 3, 28, 19, 59, 56, 716, DateTimeKind.Local).AddTicks(357), 0, null, "product2", null, "Product2", 5m },
                    { "cc9e7577-a4b6-413c-ade2-7f249a1ae631", new DateTime(2020, 3, 28, 19, 59, 56, 715, DateTimeKind.Local).AddTicks(8689), 0, null, "product1", null, "Product1", 10m },
                    { "aa2a3f59-5a9d-4bbe-bb27-fd23e6e6bbbf", new DateTime(2020, 3, 28, 19, 59, 56, 716, DateTimeKind.Local).AddTicks(558), 0, null, "product8", null, "Product8", 22m },
                    { "4462f1c7-4b12-4503-8beb-3784bad34344", new DateTime(2020, 3, 28, 19, 59, 56, 716, DateTimeKind.Local).AddTicks(567), 0, null, "product9", null, "Product9", 13m }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "AccountNumber", "CreatedAt", "DeletedAt", "ModifiedAt", "UserId" },
                values: new object[,]
                {
                    { "d293c4d5-897a-4296-9a25-4693f6bde8ef", "091234", new DateTime(2020, 3, 28, 19, 59, 56, 715, DateTimeKind.Local).AddTicks(5926), null, null, "4696c10b-8fd9-4dc3-b70d-9a4a9cd60aa8" },
                    { "e3a5f66c-c766-4d22-a3da-ec778b6174d6", "123213", new DateTime(2020, 3, 28, 19, 59, 56, 715, DateTimeKind.Local).AddTicks(4814), null, null, "0dcd5437-0bc7-40ba-b87b-5d5f5e177929" },
                    { "5814b840-0c68-4d1c-9dc6-90d7178298e8", "134519", new DateTime(2020, 3, 28, 19, 59, 56, 715, DateTimeKind.Local).AddTicks(5878), null, null, "71ae1df7-a006-4a2b-b0a5-31cf12583ac9" },
                    { "e4069e1a-5560-4e2b-8c12-098da53c893e", "914311", new DateTime(2020, 3, 28, 19, 59, 56, 715, DateTimeKind.Local).AddTicks(5910), null, null, "3c452363-ea64-4fac-934c-95a8c892fb04" },
                    { "d3cad1bc-654f-4600-8471-c9dea0307964", "618299", new DateTime(2020, 3, 28, 19, 59, 56, 715, DateTimeKind.Local).AddTicks(5919), null, null, "4fee8d86-bed2-48df-9b2c-f02835b35099" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "DepartmentId", "Employee_Number", "ModifiedAt", "UserId" },
                values: new object[,]
                {
                    { "7cd3b260-1376-492b-a230-724a09532112", new DateTime(2020, 3, 28, 19, 59, 56, 715, DateTimeKind.Local).AddTicks(1824), null, "e7ee5f0b-3ef0-4959-bf12-5c25f2fa8c8f", null, null, "4696c10b-8fd9-4dc3-b70d-9a4a9cd60aa8" },
                    { "2ea1896c-b31a-4aff-a555-4a976c64bb5e", new DateTime(2020, 3, 28, 19, 59, 56, 715, DateTimeKind.Local).AddTicks(1889), null, "e7ee5f0b-3ef0-4959-bf12-5c25f2fa8c8f", null, null, "597d6bd2-63db-4a77-8194-bf7ba6e0872f" },
                    { "91fd0c0f-93f0-4472-8d6a-8397850e1b9a", new DateTime(2020, 3, 28, 19, 59, 56, 715, DateTimeKind.Local).AddTicks(1898), null, "ff24da7e-d0fe-4452-88c6-6a0636e6e8ad", null, null, "8596e3f0-646b-4f4f-9a29-26e46a3eff93" },
                    { "d9b74665-16b9-4e9f-9dbf-03ccb1ccb818", new DateTime(2020, 3, 28, 19, 59, 56, 715, DateTimeKind.Local).AddTicks(1906), null, "ff24da7e-d0fe-4452-88c6-6a0636e6e8ad", null, null, "d08a0aa9-3dfd-4dd5-a0fd-2b92a98957dd" },
                    { "e2b8ad7b-8c8a-425e-bb5a-80f11f2e464c", new DateTime(2020, 3, 28, 19, 59, 56, 715, DateTimeKind.Local).AddTicks(1924), null, null, null, null, "ce6ad629-339a-475b-bc6c-198fca6a03a3" },
                    { "7ac1eb4f-b127-456c-9d22-5b1e4fb7aedd", new DateTime(2020, 3, 28, 19, 59, 56, 715, DateTimeKind.Local).AddTicks(1932), null, "e7ee5f0b-3ef0-4959-bf12-5c25f2fa8c8f", null, null, "819c826b-b24f-4f01-bef4-57b21a092a1b" }
                });

            migrationBuilder.InsertData(
                table: "EmployeeCustomers",
                columns: new[] { "Id", "CreatedAt", "CustomerId", "DeletedAt", "EmployeeId", "ModifiedAt" },
                values: new object[,]
                {
                    { "35435880-fa60-48bb-ae30-59e42c648640", new DateTime(2020, 3, 28, 19, 59, 56, 718, DateTimeKind.Local).AddTicks(7191), "5814b840-0c68-4d1c-9dc6-90d7178298e8", null, "7cd3b260-1376-492b-a230-724a09532112", null },
                    { "2639e831-9b33-4457-8135-731ffeee7598", new DateTime(2020, 3, 28, 19, 59, 56, 718, DateTimeKind.Local).AddTicks(7344), "d3cad1bc-654f-4600-8471-c9dea0307964", null, "7ac1eb4f-b127-456c-9d22-5b1e4fb7aedd", null },
                    { "93fcd2c7-a30c-4542-8cff-4ecda2533438", new DateTime(2020, 3, 28, 19, 59, 56, 718, DateTimeKind.Local).AddTicks(7338), "d293c4d5-897a-4296-9a25-4693f6bde8ef", null, "7cd3b260-1376-492b-a230-724a09532112", null },
                    { "05ba135e-33fc-400d-9d85-fda69abe29ee", new DateTime(2020, 3, 28, 19, 59, 56, 718, DateTimeKind.Local).AddTicks(5931), "e3a5f66c-c766-4d22-a3da-ec778b6174d6", null, "7cd3b260-1376-492b-a230-724a09532112", null },
                    { "941a9d00-690e-40b1-bd19-3e7ed4371c55", new DateTime(2020, 3, 28, 19, 59, 56, 718, DateTimeKind.Local).AddTicks(7313), "e3a5f66c-c766-4d22-a3da-ec778b6174d6", null, "2ea1896c-b31a-4aff-a555-4a976c64bb5e", null },
                    { "2edfa306-691d-4b4f-8299-0ec3a3260de6", new DateTime(2020, 3, 28, 19, 59, 56, 718, DateTimeKind.Local).AddTicks(7330), "e4069e1a-5560-4e2b-8c12-098da53c893e", null, "2ea1896c-b31a-4aff-a555-4a976c64bb5e", null },
                    { "363c56c9-f8c4-42d1-95f2-5c8de2ed5611", new DateTime(2020, 3, 28, 19, 59, 56, 718, DateTimeKind.Local).AddTicks(7321), "5814b840-0c68-4d1c-9dc6-90d7178298e8", null, "2ea1896c-b31a-4aff-a555-4a976c64bb5e", null }
                });

            migrationBuilder.InsertData(
                table: "SaleOrders",
                columns: new[] { "Id", "CreatedAt", "CustomerId", "DateOfSale", "DeletedAt", "EmployeeId", "ModifiedAt", "Note", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { "11c04314-a122-4d8c-a387-2e8f667b40bc", new DateTime(2020, 3, 28, 19, 59, 56, 719, DateTimeKind.Local).AddTicks(1017), "e4069e1a-5560-4e2b-8c12-098da53c893e", new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "2ea1896c-b31a-4aff-a555-4a976c64bb5e", null, null, "4462f1c7-4b12-4503-8beb-3784bad34344", 100 },
                    { "0fbce389-eddd-4022-ba17-6072ae4717b2", new DateTime(2020, 3, 28, 19, 59, 56, 719, DateTimeKind.Local).AddTicks(1185), "5814b840-0c68-4d1c-9dc6-90d7178298e8", new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "2ea1896c-b31a-4aff-a555-4a976c64bb5e", null, null, "cc9e7577-a4b6-413c-ade2-7f249a1ae631", 2 },
                    { "3eb28c3b-a0ca-4ab6-8ed6-f46683059b41", new DateTime(2020, 3, 28, 19, 59, 56, 719, DateTimeKind.Local).AddTicks(1173), "5814b840-0c68-4d1c-9dc6-90d7178298e8", new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "2ea1896c-b31a-4aff-a555-4a976c64bb5e", null, null, "05edd358-f76a-4c0b-8ae3-d252448b9ffe", 8 },
                    { "31287f49-6c2e-467d-baab-5421e66d411d", new DateTime(2020, 3, 28, 19, 59, 56, 719, DateTimeKind.Local).AddTicks(1007), "5814b840-0c68-4d1c-9dc6-90d7178298e8", new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "2ea1896c-b31a-4aff-a555-4a976c64bb5e", null, null, "b28596e7-1d8d-468a-b682-2dc115bb1c8b", 8 },
                    { "286f9c83-4378-4b9e-a886-78130687a2da", new DateTime(2020, 3, 28, 19, 59, 56, 719, DateTimeKind.Local).AddTicks(1041), "d293c4d5-897a-4296-9a25-4693f6bde8ef", new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "7cd3b260-1376-492b-a230-724a09532112", null, null, "aa2a3f59-5a9d-4bbe-bb27-fd23e6e6bbbf", 100 },
                    { "d309dbf1-c37a-4190-90fb-0f1ffeb37fa8", new DateTime(2020, 3, 28, 19, 59, 56, 719, DateTimeKind.Local).AddTicks(1025), "d3cad1bc-654f-4600-8471-c9dea0307964", new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "7cd3b260-1376-492b-a230-724a09532112", null, null, "ea014a4f-0aca-4953-adce-5eb4c381912e", 7 },
                    { "f99ce219-6069-4ef1-9046-4b038dcb3379", new DateTime(2020, 3, 28, 19, 59, 56, 719, DateTimeKind.Local).AddTicks(1207), "e3a5f66c-c766-4d22-a3da-ec778b6174d6", new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "2ea1896c-b31a-4aff-a555-4a976c64bb5e", null, null, "4462f1c7-4b12-4503-8beb-3784bad34344", 19 },
                    { "a1fea377-fcfc-456e-885d-8ecfa8c3192c", new DateTime(2020, 3, 28, 19, 59, 56, 719, DateTimeKind.Local).AddTicks(1049), "e3a5f66c-c766-4d22-a3da-ec778b6174d6", new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "2ea1896c-b31a-4aff-a555-4a976c64bb5e", null, null, "cc9e7577-a4b6-413c-ade2-7f249a1ae631", 4 },
                    { "2e2a584b-5c4c-4861-a8fe-34378efd742a", new DateTime(2020, 3, 28, 19, 59, 56, 718, DateTimeKind.Local).AddTicks(8217), "e3a5f66c-c766-4d22-a3da-ec778b6174d6", new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "7cd3b260-1376-492b-a230-724a09532112", null, null, "cc9e7577-a4b6-413c-ade2-7f249a1ae631", 10 },
                    { "243a6712-7186-4f02-9a57-0e007de799f0", new DateTime(2020, 3, 28, 19, 59, 56, 719, DateTimeKind.Local).AddTicks(1199), "d293c4d5-897a-4296-9a25-4693f6bde8ef", new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "7cd3b260-1376-492b-a230-724a09532112", null, null, "ddc924a7-8a83-4781-b7dc-866da899525f", 10 },
                    { "d09b642a-2feb-47f9-a0e8-fd78a2c6b1a4", new DateTime(2020, 3, 28, 19, 59, 56, 719, DateTimeKind.Local).AddTicks(1192), "d293c4d5-897a-4296-9a25-4693f6bde8ef", new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "7ac1eb4f-b127-456c-9d22-5b1e4fb7aedd", null, null, "ddc924a7-8a83-4781-b7dc-866da899525f", 10 },
                    { "4c2d8306-a4bb-4c10-871d-d136cd5bcae5", new DateTime(2020, 3, 28, 19, 59, 56, 719, DateTimeKind.Local).AddTicks(946), "5814b840-0c68-4d1c-9dc6-90d7178298e8", new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "7cd3b260-1376-492b-a230-724a09532112", null, null, "ddc924a7-8a83-4781-b7dc-866da899525f", 1 },
                    { "ff31e1e6-a4ff-42b0-804b-43d2d3e35be6", new DateTime(2020, 3, 28, 19, 59, 56, 719, DateTimeKind.Local).AddTicks(1033), "d3cad1bc-654f-4600-8471-c9dea0307964", new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "7ac1eb4f-b127-456c-9d22-5b1e4fb7aedd", null, null, "d83737cb-40a0-4cc1-8cb5-ccf335148863", 15 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

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
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "EmployeeCustomers");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "SaleOrders");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
