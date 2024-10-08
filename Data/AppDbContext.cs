﻿using CRUDOperations.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDOperations.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Account>()
        //        .HasRequired<User>(b => b.User)
        //        .WithMany(ba => ba.Accounts)
        //        .HasForeignKey<int>(K => K.UserId);
        //}

        public DbSet<User> users { get; set; }
        public DbSet<Account> accounts { get; set; }
    }
}
