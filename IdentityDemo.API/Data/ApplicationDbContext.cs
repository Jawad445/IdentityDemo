namespace IdentityDemo.API.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using IdentityDemo.Shared.Extentions;

public class ApplicationDbContext: IdentityDbContext<IdentityUser>
{
    public ApplicationDbContext(DbContextOptions options)
    : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        foreach (var entity in builder.Model.GetEntityTypes())
        {
            // Remove 'AspNet' prefix and convert table name from PascalCase to snake_case. E.g. AspNetRoleClaims -> role_claims
            entity.SetTableName(entity?.GetTableName()?.Replace("AspNet", "").ToSnakeCase());              
        }
    }
}

