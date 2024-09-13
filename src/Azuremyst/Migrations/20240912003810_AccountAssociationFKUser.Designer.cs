﻿// <auto-generated />
using System;
using Azuremyst.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Azuremyst.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240912003810_AccountAssociationFKUser")]
    partial class AccountAssociationFKUser
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Azuremyst.Models.AccountAssociation", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint unsigned");

                    b.Property<uint?>("AccountId")
                        .HasColumnType("int unsigned");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<ulong>("CreatedBy")
                        .HasColumnType("bigint unsigned");

                    b.Property<string>("Guid")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<ulong>("UpdatedBy")
                        .HasColumnType("bigint unsigned");

                    b.Property<ulong?>("UserId")
                        .HasColumnType("bigint unsigned");

                    b.HasKey("Id");

                    b.ToTable("AccountAssociations", (string)null);
                });

            modelBuilder.Entity("Azuremyst.Models.Role", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint unsigned");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<ulong>("CreatedBy")
                        .HasColumnType("bigint unsigned");

                    b.Property<string>("Guid")
                        .HasColumnType("longtext");

                    b.Property<int>("RoleType")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<ulong>("UpdatedBy")
                        .HasColumnType("bigint unsigned");

                    b.HasKey("Id");

                    b.ToTable("Roles", (string)null);
                });

            modelBuilder.Entity("Azuremyst.Models.User", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint unsigned");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<ulong>("CreatedBy")
                        .HasColumnType("bigint unsigned");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Guid")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<ulong>("UpdatedBy")
                        .HasColumnType("bigint unsigned");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.DataProtection.EntityFrameworkCore.DataProtectionKey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FriendlyName")
                        .HasColumnType("longtext");

                    b.Property<string>("Xml")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("DataProtectionKeys");
                });
#pragma warning restore 612, 618
        }
    }
}
