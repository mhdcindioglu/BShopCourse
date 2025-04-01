using BShop.Data.Entities;
using Microsoft.AspNetCore.Identity;

namespace BShop.Data;

public static class SeedData
{
    static readonly DateTime SeedDate = new(2025, 01, 01, 00, 00, 00);

    public static List<IdentityRole<Guid>> Roles =>
    [
        new IdentityRole<Guid> { Id = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC"), Name = "Admin", NormalizedName = "ADMIN", ConcurrencyStamp = "9cf2716e-b9ae-4b32-b882-8a94e4ee2ce8", },
        new IdentityRole<Guid> { Id = new Guid("96095FE3-5264-4047-A18B-B1E9E6D2931F"), Name = "Seller", NormalizedName = "SELLER", ConcurrencyStamp = "4fd986e6-376f-4865-9aa8-57465851ef87", },
    ];

    public static List<AppUser> Users =>
    [
        new AppUser { Id = new Guid("B22698B8-42A2-4115-9631-1C2D1E2AC5F7"), FullName = "Admin", UserName = "admin@bshop.com", NormalizedUserName = "ADMIN@BSHOP.COM", Email = "admin@bshop.com", NormalizedEmail = "ADMIN@BSHOP.COM", EmailConfirmed = true, ConcurrencyStamp = "b27c53ef-1b8c-4f0a-922a-43af90e8d493", SecurityStamp = "22a57152-720b-44df-aee6-4c6b44e56a3e", PasswordHash = "AQAAAAIAAYagAAAAEF56DmfAObjRWfsPMzcojT5Xxl+xwnQoncgN0855J1aPpA15i0PngiW6gyAAQkmtoQ==", CreatedTime = SeedDate, CreatedID = new Guid("B22698B8-42A2-4115-9631-1C2D1E2AC5F7"), },
        new AppUser { Id = new Guid("C7BC5CC5-D2DF-43E5-BF6E-95F88BB9EE6A"), FullName = "Gorigor", UserName = "Seller@bshop.com", NormalizedUserName = "SELLER@BSHOP.COM", Email = "seller@bshop.com", NormalizedEmail = "Seller@BSHOP.COM", EmailConfirmed = true, ConcurrencyStamp = "9d125903-df64-4c00-bd26-bdb39657c38b", SecurityStamp = "571f0fbf-532d-408b-8386-884e7bb567ed", PasswordHash = "AQAAAAIAAYagAAAAED96CADbnMTUY5zBULNbCepEY53C5stLwnUN/dhMLRMYZydKsauWvBqqldebgCw0qQ==", CreatedTime = SeedDate, CreatedID = new Guid("C7BC5CC5-D2DF-43E5-BF6E-95F88BB9EE6A"), },
        new AppUser { Id = new Guid("AAB46B7A-B558-4F31-8A80-7A50E73A4115"), FullName = "Carhat", UserName = "Seller2@bshop.com", NormalizedUserName = "SELLER2@BSHOP.COM", Email = "seller2@bshop.com", NormalizedEmail = "Seller2@BSHOP.COM", EmailConfirmed = true, ConcurrencyStamp = "88b527d2-0f63-4a55-80b0-bee9c71b68fb", SecurityStamp = "4c8bcbc5-4537-4df6-8aa7-736bcf1002d5", PasswordHash = "AQAAAAIAAYagAAAAENmR5O5XiC+fa+41jaqq6Of5K7PGJpA6FTT82jiiWhhkD04hH9wW71Y3iTpcTw39dg==", CreatedTime = SeedDate, CreatedID = new Guid("AAB46B7A-B558-4F31-8A80-7A50E73A4115"), },
        new AppUser { Id = new Guid("59A2E5B0-A606-40C5-8CDB-BC90D947EEF8"), FullName = "Silvary", UserName = "Seller3@bshop.com", NormalizedUserName = "SELLER3@BSHOP.COM", Email = "seller3@bshop.com", NormalizedEmail = "Seller3@BSHOP.COM", EmailConfirmed = true, ConcurrencyStamp = "37b04abe-5f6b-4d4b-a700-61d5a310d879", SecurityStamp = "7bc6d622-f996-4d83-aa6c-634520e27f53", PasswordHash = "AQAAAAIAAYagAAAAEMPFb2knGowAxuhK9sxuyVC0P40QFeugoar21N/eabc7AmOMWHi8e5z4F17G51DmqQ==", CreatedTime = SeedDate, CreatedID = new Guid("59A2E5B0-A606-40C5-8CDB-BC90D947EEF8"), },
        new AppUser { Id = new Guid("44027CBA-B38D-4308-83AE-EDA59940D565"), FullName = "Sobnil", UserName = "Seller4@bshop.com", NormalizedUserName = "SELLER4@BSHOP.COM", Email = "seller4@bshop.com", NormalizedEmail = "Seller4@BSHOP.COM", EmailConfirmed = true, ConcurrencyStamp = "d7da95e6-e469-45ea-ae68-84e1d59d2ea8", SecurityStamp = "0d8f0cab-cf0c-4f0c-b27e-d567141c4561", PasswordHash = "AQAAAAIAAYagAAAAEO4LvnlPG6Fm2kivj2R7mwcu9/x8qor0oU43HrqpH8M+Js2FhaV2jl9GujRyutOuGg==", CreatedTime = SeedDate, CreatedID = new Guid("44027CBA-B38D-4308-83AE-EDA59940D565"), },
        new AppUser { Id = new Guid("2ABEF967-F3B0-42B1-8398-9645494724DE"), FullName = "Customer", UserName = "Customer@bshop.com", NormalizedUserName = "CUSTOMER@BSHOP.COM", Email = "Customer@bshop.com", NormalizedEmail = "CUSTOMER@BSHOP.COM", EmailConfirmed = true, ConcurrencyStamp = "df4b9965-2f84-4a86-8456-10f893487331", SecurityStamp = "0f41db6f-4a85-4d03-9a8d-fa39b8289327", PasswordHash = "AQAAAAIAAYagAAAAEKGi31AAsyydUXr589Ef44ZueWRC8MFzh8mh+hPo31K0YwUdgl7/WVhwEAUMjCW34w==", CreatedTime = SeedDate, CreatedID = new Guid("2ABEF967-F3B0-42B1-8398-9645494724DE"), },
    ];

    public static List<IdentityUserRole<Guid>> UserRoles =>
    [
        new IdentityUserRole<Guid> { UserId = new Guid("B22698B8-42A2-4115-9631-1C2D1E2AC5F7"), RoleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC") },
        new IdentityUserRole<Guid> { UserId = new Guid("C7BC5CC5-D2DF-43E5-BF6E-95F88BB9EE6A"), RoleId = new Guid("96095FE3-5264-4047-A18B-B1E9E6D2931F") },
        new IdentityUserRole<Guid> { UserId = new Guid("AAB46B7A-B558-4F31-8A80-7A50E73A4115"), RoleId = new Guid("96095FE3-5264-4047-A18B-B1E9E6D2931F") },
        new IdentityUserRole<Guid> { UserId = new Guid("59A2E5B0-A606-40C5-8CDB-BC90D947EEF8"), RoleId = new Guid("96095FE3-5264-4047-A18B-B1E9E6D2931F") },
        new IdentityUserRole<Guid> { UserId = new Guid("44027CBA-B38D-4308-83AE-EDA59940D565"), RoleId = new Guid("96095FE3-5264-4047-A18B-B1E9E6D2931F") },
    ];
}