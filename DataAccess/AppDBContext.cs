﻿using BlazorEmployeeCRUD.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorEmployeeCRUD.DataAccess
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.GenerateSeed();
        }
    }
}
