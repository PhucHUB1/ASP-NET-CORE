using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Practical_Exam_MVC.Entities;

public class ManagementDbContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Department> Departments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Configure the database connection string
        optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=T2210M-K3;User ID=PHUC;Password=1234;TrustServerCertificate=true");
    }
}