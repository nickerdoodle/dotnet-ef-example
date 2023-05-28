*Prerequisite*
- Make sure the dotnet cli tool is installed on your machine

*Commands*
- dotnet new webapi -n YourProjectName
    - Creates a new web api project
- dotnet run
    - Runs the project (perform in project root)
- dotnet ef migrations add InitialMigration
    - Creates a migration
- dotnet ef database update
    - Applies all missing migrations to the database
- docker compose up -d
    - Starts the database and adminer (an optional image that provides a GUI to view/make changes to the database)

*Package dependencies*
- dotnet add package Microsoft.EntityFrameworkCore
    - Installing the framework (orm tool) to interface with the database
- dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
    - The postgres provider that entity framework offers to understand how to interface with a postgres db. For each db, it should have a provider from EFCore
- dotnet add package Microsoft.EntityFrameworkCore.Tools
    - Tools/commands in the cli to run EFCore commands like creating a migration or updating the database
