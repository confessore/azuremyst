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
    [Migration("20240912003117_AccountAssociation")]
    partial class AccountAssociation
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

                    b.HasIndex("AccountId");

                    b.HasIndex("UserId");

                    b.ToTable("AccountAssociations", (string)null);
                });

            modelBuilder.Entity("Azuremyst.Models.Acore.Auth.Account", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int unsigned");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<byte>("Expansion")
                        .HasColumnType("tinyint unsigned");

                    b.Property<uint>("FailedLogins")
                        .HasColumnType("int unsigned");

                    b.Property<DateTime>("Joindate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("LastAttemptIp")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastIp")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("LastLogin")
                        .HasColumnType("datetime(6)");

                    b.Property<byte>("Locale")
                        .HasColumnType("tinyint unsigned");

                    b.Property<string>("LockCountry")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<byte>("Locked")
                        .HasColumnType("tinyint unsigned");

                    b.Property<string>("Muteby")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Mutereason")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("Mutetime")
                        .HasColumnType("bigint");

                    b.Property<uint>("Online")
                        .HasColumnType("int unsigned");

                    b.Property<string>("Os")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<uint>("Recruiter")
                        .HasColumnType("int unsigned");

                    b.Property<string>("RegMail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<byte[]>("Salt")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.Property<byte[]>("SessionKey")
                        .HasColumnType("longblob");

                    b.Property<uint>("Totaltime")
                        .HasColumnType("int unsigned");

                    b.Property<byte[]>("TotpSecret")
                        .HasColumnType("longblob");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<byte[]>("Verifier")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.HasKey("Id");

                    b.ToTable("Account");
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

            modelBuilder.Entity("Azuremyst.Models.AccountAssociation", b =>
                {
                    b.HasOne("Azuremyst.Models.Acore.Auth.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId");

                    b.HasOne("Azuremyst.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Account");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
