using BShop.Data;
using BShop.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BShop.Apis;

public static class UsersApi
{
    public static void MapUserEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/api/users");

        group.MapGet("/", GetAllUsers);
        group.MapGet("/{id}", GetUserById);
        group.MapPost("/", CreateUser);
        group.MapPut("/{id}", UpdateUser);
        group.MapDelete("/{id}", DeleteUser);
    }

    private static async Task<IResult> GetAllUsers(AppDbContext db)
    {
        var users = await db.Users
            .Where(u => u.Active)
            .ToListAsync();
        return Results.Ok(users);
    }

    private static async Task<IResult> GetUserById(Guid id, AppDbContext db)
    {
        var user = await db.Users.FindAsync(id);
        if (user is null || !user.Active)
            return Results.NotFound();

        return Results.Ok(user);
    }

    private static async Task<IResult> CreateUser([FromBody] AppUser user, AppDbContext db)
    {
        db.Users.Add(user);
        await db.SaveChangesAsync();
        return Results.Created($"/api/users/{user.Id}", user);
    }

    private static async Task<IResult> UpdateUser(Guid id, [FromBody] AppUser user, AppDbContext db)
    {
        var existing = await db.Users.FindAsync(id);
        if (existing is null || !existing.Active) 
            return Results.NotFound();

        existing.FullName = user.FullName;
        existing.Email = user.Email;
        existing.PhoneNumber = user.PhoneNumber;
        existing.UpdatedID = user.UpdatedID;
        existing.UpdatedTime = DateTime.UtcNow;

        await db.SaveChangesAsync();
        return Results.NoContent();
    }

    private static async Task<IResult> DeleteUser(Guid id, AppDbContext db)
    {
        var user = await db.Users.FindAsync(id);
        if (user is null || !user.Active) 
            return Results.NotFound();

        user.Active = false;
        user.UpdatedTime = DateTime.UtcNow;
        await db.SaveChangesAsync();

        return Results.NoContent();
    }
}