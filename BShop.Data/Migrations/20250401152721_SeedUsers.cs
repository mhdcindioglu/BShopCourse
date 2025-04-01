using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), "9cf2716e-b9ae-4b32-b882-8a94e4ee2ce8", "Admin", "ADMIN" },
                    { new Guid("96095fe3-5264-4047-a18b-b1e9e6d2931f"), "4fd986e6-376f-4865-9aa8-57465851ef87", "Seller", "SELLER" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Active", "ConcurrencyStamp", "CreatedID", "CreatedTime", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedID", "UpdatedTime", "UserName" },
                values: new object[,]
                {
                    { new Guid("2abef967-f3b0-42b1-8398-9645494724de"), 0, true, "df4b9965-2f84-4a86-8456-10f893487331", new Guid("2abef967-f3b0-42b1-8398-9645494724de"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer@bshop.com", true, "Customer", false, null, "CUSTOMER@BSHOP.COM", "CUSTOMER@BSHOP.COM", "AQAAAAIAAYagAAAAEKGi31AAsyydUXr589Ef44ZueWRC8MFzh8mh+hPo31K0YwUdgl7/WVhwEAUMjCW34w==", null, false, "0f41db6f-4a85-4d03-9a8d-fa39b8289327", false, null, null, "Customer@bshop.com" },
                    { new Guid("44027cba-b38d-4308-83ae-eda59940d565"), 0, true, "d7da95e6-e469-45ea-ae68-84e1d59d2ea8", new Guid("44027cba-b38d-4308-83ae-eda59940d565"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "seller4@bshop.com", true, "Sobnil", false, null, "Seller4@BSHOP.COM", "SELLER4@BSHOP.COM", "AQAAAAIAAYagAAAAEO4LvnlPG6Fm2kivj2R7mwcu9/x8qor0oU43HrqpH8M+Js2FhaV2jl9GujRyutOuGg==", null, false, "0d8f0cab-cf0c-4f0c-b27e-d567141c4561", false, null, null, "Seller4@bshop.com" },
                    { new Guid("59a2e5b0-a606-40c5-8cdb-bc90d947eef8"), 0, true, "37b04abe-5f6b-4d4b-a700-61d5a310d879", new Guid("59a2e5b0-a606-40c5-8cdb-bc90d947eef8"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "seller3@bshop.com", true, "Silvary", false, null, "Seller3@BSHOP.COM", "SELLER3@BSHOP.COM", "AQAAAAIAAYagAAAAEMPFb2knGowAxuhK9sxuyVC0P40QFeugoar21N/eabc7AmOMWHi8e5z4F17G51DmqQ==", null, false, "7bc6d622-f996-4d83-aa6c-634520e27f53", false, null, null, "Seller3@bshop.com" },
                    { new Guid("aab46b7a-b558-4f31-8a80-7a50e73a4115"), 0, true, "88b527d2-0f63-4a55-80b0-bee9c71b68fb", new Guid("aab46b7a-b558-4f31-8a80-7a50e73a4115"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "seller2@bshop.com", true, "Carhat", false, null, "Seller2@BSHOP.COM", "SELLER2@BSHOP.COM", "AQAAAAIAAYagAAAAENmR5O5XiC+fa+41jaqq6Of5K7PGJpA6FTT82jiiWhhkD04hH9wW71Y3iTpcTw39dg==", null, false, "4c8bcbc5-4537-4df6-8aa7-736bcf1002d5", false, null, null, "Seller2@bshop.com" },
                    { new Guid("b22698b8-42a2-4115-9631-1c2d1e2ac5f7"), 0, true, "b27c53ef-1b8c-4f0a-922a-43af90e8d493", new Guid("b22698b8-42a2-4115-9631-1c2d1e2ac5f7"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@bshop.com", true, "Admin", false, null, "ADMIN@BSHOP.COM", "ADMIN@BSHOP.COM", "AQAAAAIAAYagAAAAEF56DmfAObjRWfsPMzcojT5Xxl+xwnQoncgN0855J1aPpA15i0PngiW6gyAAQkmtoQ==", null, false, "22a57152-720b-44df-aee6-4c6b44e56a3e", false, null, null, "admin@bshop.com" },
                    { new Guid("c7bc5cc5-d2df-43e5-bf6e-95f88bb9ee6a"), 0, true, "9d125903-df64-4c00-bd26-bdb39657c38b", new Guid("c7bc5cc5-d2df-43e5-bf6e-95f88bb9ee6a"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "seller@bshop.com", true, "Gorigor", false, null, "Seller@BSHOP.COM", "SELLER@BSHOP.COM", "AQAAAAIAAYagAAAAED96CADbnMTUY5zBULNbCepEY53C5stLwnUN/dhMLRMYZydKsauWvBqqldebgCw0qQ==", null, false, "571f0fbf-532d-408b-8386-884e7bb567ed", false, null, null, "Seller@bshop.com" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("96095fe3-5264-4047-a18b-b1e9e6d2931f"), new Guid("44027cba-b38d-4308-83ae-eda59940d565") },
                    { new Guid("96095fe3-5264-4047-a18b-b1e9e6d2931f"), new Guid("59a2e5b0-a606-40c5-8cdb-bc90d947eef8") },
                    { new Guid("96095fe3-5264-4047-a18b-b1e9e6d2931f"), new Guid("aab46b7a-b558-4f31-8a80-7a50e73a4115") },
                    { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), new Guid("b22698b8-42a2-4115-9631-1c2d1e2ac5f7") },
                    { new Guid("96095fe3-5264-4047-a18b-b1e9e6d2931f"), new Guid("c7bc5cc5-d2df-43e5-bf6e-95f88bb9ee6a") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("96095fe3-5264-4047-a18b-b1e9e6d2931f"), new Guid("44027cba-b38d-4308-83ae-eda59940d565") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("96095fe3-5264-4047-a18b-b1e9e6d2931f"), new Guid("59a2e5b0-a606-40c5-8cdb-bc90d947eef8") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("96095fe3-5264-4047-a18b-b1e9e6d2931f"), new Guid("aab46b7a-b558-4f31-8a80-7a50e73a4115") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), new Guid("b22698b8-42a2-4115-9631-1c2d1e2ac5f7") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("96095fe3-5264-4047-a18b-b1e9e6d2931f"), new Guid("c7bc5cc5-d2df-43e5-bf6e-95f88bb9ee6a") });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2abef967-f3b0-42b1-8398-9645494724de"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("96095fe3-5264-4047-a18b-b1e9e6d2931f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44027cba-b38d-4308-83ae-eda59940d565"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("59a2e5b0-a606-40c5-8cdb-bc90d947eef8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aab46b7a-b558-4f31-8a80-7a50e73a4115"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b22698b8-42a2-4115-9631-1c2d1e2ac5f7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c7bc5cc5-d2df-43e5-bf6e-95f88bb9ee6a"));
        }
    }
}
