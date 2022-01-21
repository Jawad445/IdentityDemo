using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using IdentityDemo.Shared.Extentions;

namespace IdentityDemo.API.Data
{
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

                //// Convert column names from PascalCase to snake_case.
                //foreach (var property in entity.GetProperties())
                //{
                //    property.SetColumnName(property.Name.ToSnakeCase());
                //}

                //// Convert primary key names from PascalCase to snake_case. E.g. PK_users -> pk_users
                //foreach (var key in entity.GetKeys())
                //{
                //    key.SetName(key.GetName().ToSnakeCase());
                //}

                //// Convert foreign key names from PascalCase to snake_case.
                //foreach (var key in entity.GetForeignKeys())
                //{
                //    key.SetConstraintName(key.GetConstraintName().ToSnakeCase());
                //}

                //// Convert index names from PascalCase to snake_case.
                //foreach (var index in entity.GetIndexes())
                //{
                //    index.SetName(index.GetName().ToSnakeCase());
                //}
            }
        }
    }
}
