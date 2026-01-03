using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement1.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "56a13011-d2ef-4885-9d48-a33cd224064f", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAECJEiORo6eQDwO7JBs+Odg1Zuyzup0jud7MT6ZGL2eRWa41g51BDwTohfp7tMIP+vA==", null, false, "6f0711cd-99ce-495c-b2e0-c3894187b5a9", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 3, 13, 40, 23, 849, DateTimeKind.Local).AddTicks(6645), new DateTime(2026, 1, 3, 13, 40, 23, 849, DateTimeKind.Local).AddTicks(6654) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 3, 13, 40, 23, 849, DateTimeKind.Local).AddTicks(6655), new DateTime(2026, 1, 3, 13, 40, 23, 849, DateTimeKind.Local).AddTicks(6656) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 3, 13, 40, 23, 849, DateTimeKind.Local).AddTicks(6796), new DateTime(2026, 1, 3, 13, 40, 23, 849, DateTimeKind.Local).AddTicks(6796) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 3, 13, 40, 23, 849, DateTimeKind.Local).AddTicks(6798), new DateTime(2026, 1, 3, 13, 40, 23, 849, DateTimeKind.Local).AddTicks(6798) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 3, 13, 40, 23, 849, DateTimeKind.Local).AddTicks(6879), new DateTime(2026, 1, 3, 13, 40, 23, 849, DateTimeKind.Local).AddTicks(6879) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 3, 13, 40, 23, 849, DateTimeKind.Local).AddTicks(6881), new DateTime(2026, 1, 3, 13, 40, 23, 849, DateTimeKind.Local).AddTicks(6881) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 3, 13, 40, 23, 849, DateTimeKind.Local).AddTicks(6882), new DateTime(2026, 1, 3, 13, 40, 23, 849, DateTimeKind.Local).AddTicks(6882) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 3, 13, 40, 23, 849, DateTimeKind.Local).AddTicks(6883), new DateTime(2026, 1, 3, 13, 40, 23, 849, DateTimeKind.Local).AddTicks(6884) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 3, 12, 27, 39, 523, DateTimeKind.Local).AddTicks(5055), new DateTime(2026, 1, 3, 12, 27, 39, 523, DateTimeKind.Local).AddTicks(5069) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 3, 12, 27, 39, 523, DateTimeKind.Local).AddTicks(5070), new DateTime(2026, 1, 3, 12, 27, 39, 523, DateTimeKind.Local).AddTicks(5071) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 3, 12, 27, 39, 523, DateTimeKind.Local).AddTicks(5196), new DateTime(2026, 1, 3, 12, 27, 39, 523, DateTimeKind.Local).AddTicks(5197) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 3, 12, 27, 39, 523, DateTimeKind.Local).AddTicks(5198), new DateTime(2026, 1, 3, 12, 27, 39, 523, DateTimeKind.Local).AddTicks(5198) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 3, 12, 27, 39, 523, DateTimeKind.Local).AddTicks(5252), new DateTime(2026, 1, 3, 12, 27, 39, 523, DateTimeKind.Local).AddTicks(5252) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 3, 12, 27, 39, 523, DateTimeKind.Local).AddTicks(5253), new DateTime(2026, 1, 3, 12, 27, 39, 523, DateTimeKind.Local).AddTicks(5254) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 3, 12, 27, 39, 523, DateTimeKind.Local).AddTicks(5254), new DateTime(2026, 1, 3, 12, 27, 39, 523, DateTimeKind.Local).AddTicks(5255) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 3, 12, 27, 39, 523, DateTimeKind.Local).AddTicks(5256), new DateTime(2026, 1, 3, 12, 27, 39, 523, DateTimeKind.Local).AddTicks(5256) });
        }
    }
}
