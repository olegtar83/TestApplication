Create database:

CREATE DATABASE JTITestDB;

Create Migrations:

dotnet ef migrations add Init

dotnet ef database update

Run Sql Scripts in Sp folder for Storage Procedures:

GetMostActiveEmployee_Sp

GetMostVisitedDepartments_Sp



