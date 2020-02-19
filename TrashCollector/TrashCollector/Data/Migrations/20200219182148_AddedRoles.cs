using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class AddedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce2aeecf-812e-4d24-8bb7-0fad6d1b343b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "21896804-7cb9-464d-b54c-d36f8a05276f", "899ce174-da73-4535-9abf-1a5fdc10104d", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3643ece3-3cc3-40cb-a866-5360565bf4ab", "d7bcfe24-03e0-4164-931a-62544897c81d", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21896804-7cb9-464d-b54c-d36f8a05276f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3643ece3-3cc3-40cb-a866-5360565bf4ab");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ce2aeecf-812e-4d24-8bb7-0fad6d1b343b", "abb413d7-fc79-40dc-b413-411aa8725832", "Admin", "ADMIN" });
        }
    }
}
