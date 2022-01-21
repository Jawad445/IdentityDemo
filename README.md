# IdentityDemo
-> Create a Web API project 
-> Add a .Net standard class library that will contain all the shared info
-> Add Nuget packages in API project
        Microsoft.AspNetCore.Identity
        Microsoft.AspNetCore.Authentication.JwtBearer
        Microsoft.EntityFrameworkCore
        Microsoft.EntityFrameworkCore.SqlServer
        Microsoft.AspNetCore.Identity.EntityFrameworkCore
        Microsoft.EntityFrameworkCore.Design
        Microsoft.EntityFrameworkCore.Tool
-> Add Connection String in appsettings.json file
          "ConnectionStrings": {
              "DefaultConnection": "Server=localhost; Database=Identity; Trusted_Connection=True;”
            }
-> Create a new Context class and inherit it from IdentityDbContext
-> Use Fluent API to change the table names 
-> Configure DbContext in service container 
-> AddIdentity<IdentityUser, IdentityRole> service in service container
-> Add the options for password and user configuration
-> After that run the migrations
          Add-Migration “{migrationName}”
          Update-Database
-> Create a user service with membership methods
-> Create viewmodels and models for request and response 
-> write business logic in service and register that service in service container as scoped




