﻿// <auto-generated />
using System;
using BankAccountService.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BankAccountService.Infrastructure.Migrations
{
    [DbContext(typeof(BankAccountServiceDbContext))]
    partial class BankAccountServiceDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BankAccountService.Core.Entities.BankAccountEntities.BankAccount", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("BankBranch")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("BankName")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime?>("ClosingTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<DateTime>("DataCreationTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataLastDeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataLastEditTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("IBAN")
                        .IsRequired()
                        .HasMaxLength(34)
                        .HasColumnType("nvarchar(34)");

                    b.Property<decimal>("InterestRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEdited")
                        .HasColumnType("bit");

                    b.Property<string>("Nickname")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<decimal>("OverdraftLimit")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("OwnerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SWIFT_BIC_Code")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.HasIndex("StatusId");

                    b.HasIndex("TypeId");

                    b.ToTable("BankAccounts");
                });

            modelBuilder.Entity("BankAccountService.Core.Entities.BankAccountEntities.BankAccountStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(10000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Id");

                    b.ToTable("BankAccountStatuses");
                });

            modelBuilder.Entity("BankAccountService.Core.Entities.BankAccountEntities.BankAccountType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(10000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Id");

                    b.ToTable("BankAccountTypes");
                });

            modelBuilder.Entity("BankAccountService.Core.Entities.CustomerEntities.Customer", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("BankAccountService.Core.Entities.BankAccountEntities.BankAccount", b =>
                {
                    b.HasOne("BankAccountService.Core.Entities.CustomerEntities.Customer", "Owner")
                        .WithMany("OwnerBankAccounts")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BankAccountService.Core.Entities.BankAccountEntities.BankAccountStatus", "Status")
                        .WithMany("BankAccounts")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BankAccountService.Core.Entities.BankAccountEntities.BankAccountType", "Type")
                        .WithMany("BankAccounts")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");

                    b.Navigation("Status");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("BankAccountService.Core.Entities.BankAccountEntities.BankAccountStatus", b =>
                {
                    b.Navigation("BankAccounts");
                });

            modelBuilder.Entity("BankAccountService.Core.Entities.BankAccountEntities.BankAccountType", b =>
                {
                    b.Navigation("BankAccounts");
                });

            modelBuilder.Entity("BankAccountService.Core.Entities.CustomerEntities.Customer", b =>
                {
                    b.Navigation("OwnerBankAccounts");
                });
#pragma warning restore 612, 618
        }
    }
}
