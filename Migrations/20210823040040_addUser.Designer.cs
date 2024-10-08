﻿// <auto-generated />
using System;
using CRUDOperations.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CRUDOperations.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210823040040_addUser")]
    partial class addUser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CRUDOperations.Data.Models.Account", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("AccountNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("AccountType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Balance")
                        .HasColumnType("float");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CustomerId");

                    b.HasIndex("UserId");

                    b.ToTable("accounts");
                });

            modelBuilder.Entity("CRUDOperations.Data.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhnNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("CRUDOperations.Data.Models.Account", b =>
                {
                    b.HasOne("CRUDOperations.Data.Models.User", null)
                        .WithMany("Accounts")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("CRUDOperations.Data.Models.User", b =>
                {
                    b.Navigation("Accounts");
                });
#pragma warning restore 612, 618
        }
    }
}
