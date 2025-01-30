using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorEmployeeCRUD.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "DateOfBirth", "Department", "FullName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, 25, new DateTime(1999, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Abc", "1234567890" },
                    { 2, 24, new DateTime(1999, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Mno", "1234567890" },
                    { 3, 29, new DateTime(1993, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Excecutive", "Xyz", "1234567890" },
                    { 4, 25, new DateTime(1999, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Dfg", "1234567890" },
                    { 5, 25, new DateTime(1991, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Qml", "1234567890" },
                    { 6, 28, new DateTime(1993, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manufacturing", "Bju", "1234567890" },
                    { 7, 32, new DateTime(1988, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Kgd", "1234567890" },
                    { 8, 25, new DateTime(1990, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Cey", "1234567890" },
                    { 9, 26, new DateTime(1998, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Excecutive", "Ndw", "1234567890" },
                    { 10, 24, new DateTime(2000, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Production", "Mki", "1234567890" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10);
        }
    }
}
