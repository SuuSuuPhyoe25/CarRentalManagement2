using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement1.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 12, 31, 20, 56, 37, 345, DateTimeKind.Local).AddTicks(1072), new DateTime(2025, 12, 31, 20, 56, 37, 345, DateTimeKind.Local).AddTicks(1082), "Black", "System" },
                    { 2, "System", new DateTime(2025, 12, 31, 20, 56, 37, 345, DateTimeKind.Local).AddTicks(1084), new DateTime(2025, 12, 31, 20, 56, 37, 345, DateTimeKind.Local).AddTicks(1084), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 12, 31, 20, 56, 37, 345, DateTimeKind.Local).AddTicks(1220), new DateTime(2025, 12, 31, 20, 56, 37, 345, DateTimeKind.Local).AddTicks(1221), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 12, 31, 20, 56, 37, 345, DateTimeKind.Local).AddTicks(1222), new DateTime(2025, 12, 31, 20, 56, 37, 345, DateTimeKind.Local).AddTicks(1222), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 12, 31, 20, 56, 37, 345, DateTimeKind.Local).AddTicks(1268), new DateTime(2025, 12, 31, 20, 56, 37, 345, DateTimeKind.Local).AddTicks(1269), "i4", "System" },
                    { 2, "System", new DateTime(2025, 12, 31, 20, 56, 37, 345, DateTimeKind.Local).AddTicks(1270), new DateTime(2025, 12, 31, 20, 56, 37, 345, DateTimeKind.Local).AddTicks(1270), "i5", "System" },
                    { 3, "System", new DateTime(2025, 12, 31, 20, 56, 37, 345, DateTimeKind.Local).AddTicks(1271), new DateTime(2025, 12, 31, 20, 56, 37, 345, DateTimeKind.Local).AddTicks(1272), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 12, 31, 20, 56, 37, 345, DateTimeKind.Local).AddTicks(1273), new DateTime(2025, 12, 31, 20, 56, 37, 345, DateTimeKind.Local).AddTicks(1273), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
