﻿using CodeKata.Domain.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CodeKata.Domain
{
    public class CodeKataContext : DbContext
    {

        public CodeKataContext() : base("CodeKataContext")
        {
        }

        public DbSet<TestModel> TestModel { get; set; }
        public DbSet<TestModel2> TestModel2 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}