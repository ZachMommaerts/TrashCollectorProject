using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class autoentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "788b6a64-7234-4ebd-a252-3b106f809989");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d220ab83-6e34-4b31-9474-8e09f2b45081");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "321669fe-911f-44de-a830-60dfee883000", "ea0c8126-95ff-44fb-ba20-955dcdf0cfd1", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5061d225-6d7f-4648-a1c8-a9daf3ea8278", "964c1152-52d7-453c-b48f-fe6d31d92663", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "321669fe-911f-44de-a830-60dfee883000");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5061d225-6d7f-4648-a1c8-a9daf3ea8278");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "788b6a64-7234-4ebd-a252-3b106f809989", "fbdeeed4-cdb7-4b18-8c6b-5e4cfa2f0784", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d220ab83-6e34-4b31-9474-8e09f2b45081", "115a2a12-fc6b-4494-bce1-11f56ef11998", "Employee", "EMPLOYEE" });
        }
    }
}
