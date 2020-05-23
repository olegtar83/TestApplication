using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TestDAL.Models;

namespace TestDAL.Seed
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departments>().HasData(
                new Departments
                {
                    Id = 1,
                    Name = "Software Development"
                },
                new Departments
                {
                    Id = 2,
                    Name = "Sales"
                },
                new Departments
                {
                    Id = 3,
                    Name = "Business Development"
                },
                new Departments
                {
                    Id = 4,
                    Name = "Marketing"
                },
                new Departments
                {
                    Id = 5,
                    Name = "Human Resource"
                },
                new Departments
                {
                    Id = 6,
                    Name = "Purchase"
                }
            );
            modelBuilder.Entity<Employees>().HasData(
                new Employees { Id = 1, FirstName = "Vasya", LastName = "Solovyov" },
                new Employees { Id = 2, FirstName = "Oleg", LastName = "Vidin" },
                new Employees { Id = 3, FirstName = "Egor", LastName = "Aleksandrov" },
                new Employees { Id = 4, FirstName = "Johan", LastName = "Harris" },
                new Employees { Id = 5, FirstName = "Oleg", LastName = "Prokofiev" },
                new Employees { Id = 6, FirstName = "Leon", LastName = "Martirasyan" },
                new Employees { Id = 7, FirstName = "Vasya", LastName = "Sokolov" },
                new Employees { Id = 8, FirstName = "Seva", LastName = "Vagshtein" },
                new Employees { Id = 9, FirstName = "Aleksandr", LastName = "Elistratov" },
                new Employees { Id = 10, FirstName = "Vasiliy", LastName = "Lozhkin" },
                new Employees { Id = 11, FirstName = "Maksim", LastName = "Belyaev" },
                new Employees { Id = 12, FirstName = "Mikhail", LastName = "Demchenko" },
                new Employees { Id = 13, FirstName = "Olga", LastName = "Vortonyan" },
                new Employees { Id = 14, FirstName = "Ivan", LastName = "Demushkin" },
                new Employees { Id = 15, FirstName = "Irina", LastName = "Zolotova" });

            modelBuilder.Entity<Visits>().HasData(
                new Visits { Id = 1, DepartmentId = 1, EmployeeId = 14},
                new Visits { Id = 2, DepartmentId = 1, EmployeeId = 3 },
                new Visits { Id = 3, DepartmentId = 4, EmployeeId = 5 },
                new Visits { Id = 4, DepartmentId = 4, EmployeeId = 2 },
                new Visits { Id = 5, DepartmentId = 5, EmployeeId = 9 },
                new Visits { Id = 6, DepartmentId = 2, EmployeeId = 10 },
                new Visits { Id = 7, DepartmentId = 3, EmployeeId = 10 },
                new Visits { Id = 8, DepartmentId = 1, EmployeeId = 7 },
                new Visits { Id = 9, DepartmentId = 1, EmployeeId = 5 },
                new Visits { Id = 10, DepartmentId = 2, EmployeeId = 10 },
                new Visits { Id = 11, DepartmentId = 4, EmployeeId = 4 },
                new Visits { Id = 12, DepartmentId = 5, EmployeeId = 7 },
                new Visits { Id = 13, DepartmentId = 2, EmployeeId = 8 },
                new Visits { Id = 14, DepartmentId = 3, EmployeeId = 9 },
                new Visits { Id = 15, DepartmentId = 4, EmployeeId = 3 },
                new Visits { Id = 16, DepartmentId = 2, EmployeeId = 2 },
                new Visits { Id = 17, DepartmentId = 4, EmployeeId = 8 },
                new Visits { Id = 18, DepartmentId = 5, EmployeeId = 9 },
                new Visits { Id = 19, DepartmentId = 1, EmployeeId = 11 },
                new Visits { Id = 20, DepartmentId = 2, EmployeeId = 13 },
                new Visits { Id = 21, DepartmentId = 3, EmployeeId = 10 },
                new Visits { Id = 22, DepartmentId = 3, EmployeeId = 9 },
                new Visits { Id = 23, DepartmentId = 4, EmployeeId = 8 },
                new Visits { Id = 24, DepartmentId = 4, EmployeeId = 7 },
                new Visits { Id = 25, DepartmentId = 5, EmployeeId = 2 },
                new Visits { Id = 26, DepartmentId = 6, EmployeeId = 15 },
                new Visits { Id = 27, DepartmentId = 1, EmployeeId = 12 },
                new Visits { Id = 28, DepartmentId = 2, EmployeeId = 1 },
                new Visits { Id = 29, DepartmentId = 4, EmployeeId = 9 },
                new Visits { Id = 30, DepartmentId = 5, EmployeeId = 10 },
                new Visits { Id = 31, DepartmentId = 3, EmployeeId = 1 },
                new Visits { Id = 32, DepartmentId = 2, EmployeeId = 3 },
                new Visits { Id = 33, DepartmentId = 2, EmployeeId = 4 },
                new Visits { Id = 34, DepartmentId = 2, EmployeeId = 5 },
                new Visits { Id = 35, DepartmentId = 6, EmployeeId = 6 },
                new Visits { Id = 36, DepartmentId = 2, EmployeeId = 6 },
                new Visits { Id = 37, DepartmentId = 1, EmployeeId = 7 },
                new Visits { Id = 38, DepartmentId = 3, EmployeeId = 15 },
                new Visits { Id = 39, DepartmentId = 3, EmployeeId = 14 },
                new Visits { Id = 40, DepartmentId = 4, EmployeeId = 13 },
                new Visits { Id = 41, DepartmentId = 5, EmployeeId = 12 },
                new Visits { Id = 42, DepartmentId = 6, EmployeeId = 10 },
                new Visits { Id = 43, DepartmentId = 5, EmployeeId = 9 },
                new Visits { Id = 44, DepartmentId = 3, EmployeeId = 8 },
                new Visits { Id = 45, DepartmentId = 3, EmployeeId = 7 },
                new Visits { Id = 46, DepartmentId = 4, EmployeeId = 6 },
                new Visits { Id = 47, DepartmentId = 1, EmployeeId = 5 }
                );
        }
    }
}
