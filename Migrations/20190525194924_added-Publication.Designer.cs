﻿// <auto-generated />
using System;
using MedicalEngineMicroService.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MedicalEngineMicroService.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190525194924_added-Publication")]
    partial class addedPublication
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MedicalEngineMicroService.Core.Models.Entities.Lookups.FileStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DATETIME2")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("0");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("NormalizedDescription")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("NormalizedName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("UpdatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DATETIME2")
                        .HasDefaultValueSql("GetDate()");

                    b.HasKey("Id");

                    b.ToTable("FileStatuses");

                    b.HasData(
                        new { Id = 1, CreatedBy = "Administrator", CreatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 554, DateTimeKind.Local), Description = "Successfully uploaded the file", IsDeleted = false, Name = "Uploaded", NormalizedDescription = "SUCCESSFULLYUPLOADEDTHEFILE", NormalizedName = "UPLOADED", UpdatedBy = "Administrator", UpdatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 556, DateTimeKind.Local) },
                        new { Id = 2, CreatedBy = "Administrator", CreatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 556, DateTimeKind.Local), Description = "The manager rejected the file", IsDeleted = false, Name = "Rejected", NormalizedDescription = "THEMANAGERREJECTEDTHEFILE", NormalizedName = "REJECTED", UpdatedBy = "Administrator", UpdatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 556, DateTimeKind.Local) },
                        new { Id = 3, CreatedBy = "Administrator", CreatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 556, DateTimeKind.Local), Description = "Ready to submit to the Fund", IsDeleted = false, Name = "Approved", NormalizedDescription = "READYTOSUBMITTOTHEFUND", NormalizedName = "APPROVED", UpdatedBy = "Administrator", UpdatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 556, DateTimeKind.Local) },
                        new { Id = 4, CreatedBy = "Administrator", CreatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 556, DateTimeKind.Local), Description = "File successfully submitted to the Fund", IsDeleted = false, Name = "Submitted", NormalizedDescription = "FILESUCCESSFULLYSUBMITTEDTOTHEFUND", NormalizedName = "SUBMITTED", UpdatedBy = "Administrator", UpdatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 556, DateTimeKind.Local) },
                        new { Id = 5, CreatedBy = "Administrator", CreatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 556, DateTimeKind.Local), Description = "Not all invoices were paid", IsDeleted = false, Name = "Partially Paid", NormalizedDescription = "NOTALLINVOICESWEREPAID", NormalizedName = "PARTIALLY PAID", UpdatedBy = "Administrator", UpdatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 556, DateTimeKind.Local) },
                        new { Id = 6, CreatedBy = "Administrator", CreatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 556, DateTimeKind.Local), Description = "All invoices were successfully paid", IsDeleted = false, Name = "Paid", NormalizedDescription = "ALLINVOICESWERESUCCESSFULLYPAID", NormalizedName = "PAID", UpdatedBy = "Administrator", UpdatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 556, DateTimeKind.Local) },
                        new { Id = 7, CreatedBy = "Administrator", CreatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 556, DateTimeKind.Local), Description = "File Overdue", IsDeleted = false, Name = "Overdue", NormalizedDescription = "FILEOVERDUE", NormalizedName = "OVERDUE", UpdatedBy = "Administrator", UpdatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 556, DateTimeKind.Local) }
                    );
                });

            modelBuilder.Entity("MedicalEngineMicroService.Core.Models.Entities.Lookups.InvoiceStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DATETIME2")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("0");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("NormalizedDescription")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("NormalizedName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("UpdatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DATETIME2")
                        .HasDefaultValueSql("GetDate()");

                    b.HasKey("Id");

                    b.ToTable("InvoiceStatuses");

                    b.HasData(
                        new { Id = 1, CreatedBy = "Administrator", CreatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 559, DateTimeKind.Local), Description = "Pending", IsDeleted = false, Name = "Pending", NormalizedDescription = "PENDING", NormalizedName = "PENDING", UpdatedBy = "Administrator", UpdatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 559, DateTimeKind.Local) },
                        new { Id = 2, CreatedBy = "Administrator", CreatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 559, DateTimeKind.Local), Description = "Approved", IsDeleted = false, Name = "Approved", NormalizedDescription = "APPROVED", NormalizedName = "APPROVED", UpdatedBy = "Administrator", UpdatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 559, DateTimeKind.Local) },
                        new { Id = 3, CreatedBy = "Administrator", CreatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 559, DateTimeKind.Local), Description = "Payment rejected", IsDeleted = false, Name = "Rejected", NormalizedDescription = "PAYMENTREJECTED", NormalizedName = "REJECTED", UpdatedBy = "Administrator", UpdatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 559, DateTimeKind.Local) },
                        new { Id = 4, CreatedBy = "Administrator", CreatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 559, DateTimeKind.Local), Description = "Invoice submitted to the fund", IsDeleted = false, Name = "Submitted", NormalizedDescription = "INVOICESUBMITTEDTOTHEFUND", NormalizedName = "SUBMITTED", UpdatedBy = "Administrator", UpdatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 559, DateTimeKind.Local) },
                        new { Id = 5, CreatedBy = "Administrator", CreatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 559, DateTimeKind.Local), Description = "Invoice paid", IsDeleted = false, Name = "Paid", NormalizedDescription = "INVOICEPAID", NormalizedName = "PAID", UpdatedBy = "Administrator", UpdatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 559, DateTimeKind.Local) },
                        new { Id = 6, CreatedBy = "Administrator", CreatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 559, DateTimeKind.Local), Description = "Invoice Overdue", IsDeleted = false, Name = "Overdue", NormalizedDescription = "INVOICEOVERDUE", NormalizedName = "OVERDUE", UpdatedBy = "Administrator", UpdatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 559, DateTimeKind.Local) }
                    );
                });

            modelBuilder.Entity("MedicalEngineMicroService.Core.Models.Entities.Tariffs.Tariff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasMaxLength(10);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DATETIME2")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("0");

                    b.Property<int>("TariffTypeId");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("UpdatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DATETIME2")
                        .HasDefaultValueSql("GetDate()");

                    b.HasKey("Id");

                    b.HasIndex("TariffTypeId");

                    b.ToTable("Tariffs");
                });

            modelBuilder.Entity("MedicalEngineMicroService.Core.Models.Entities.Tariffs.TariffType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DATETIME2")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("0");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("NormalizedDescription")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("NormalizedName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("UpdatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DATETIME2")
                        .HasDefaultValueSql("GetDate()");

                    b.HasKey("Id");

                    b.ToTable("TariffTypes");

                    b.HasData(
                        new { Id = 1, CreatedBy = "Administrator", CreatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local), Description = "Chiropractor Tariffs", IsDeleted = false, Name = "Chiropractor", NormalizedDescription = "CHIROPRACTORTARIFFS", NormalizedName = "CHIROPRACTOR", UpdatedBy = "Administrator", UpdatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local) },
                        new { Id = 2, CreatedBy = "Administrator", CreatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local), Description = "Radiologists Tariffs", IsDeleted = false, Name = "Radiologist", NormalizedDescription = "RADIOLOGISTSTARIFFS", NormalizedName = "RADIOLOGIST", UpdatedBy = "Administrator", UpdatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local) },
                        new { Id = 3, CreatedBy = "Administrator", CreatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local), Description = "Dentists tarrifs", IsDeleted = false, Name = "Dentist", NormalizedDescription = "DENTISTSTARRIFS", NormalizedName = "DENTIST", UpdatedBy = "Administrator", UpdatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local) },
                        new { Id = 4, CreatedBy = "Administrator", CreatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local), Description = "Physiotherapist tariffs", IsDeleted = false, Name = "Physiotherapist", NormalizedDescription = "PHYSIOTHERAPISTTARIFFS", NormalizedName = "PHYSIOTHERAPIST", UpdatedBy = "Administrator", UpdatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local) },
                        new { Id = 5, CreatedBy = "Administrator", CreatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local), Description = "Private Ambulance Tariffs", IsDeleted = false, Name = "Private Ambulance", NormalizedDescription = "PRIVATEAMBULANCETARIFFS", NormalizedName = "PRIVATEAMBULANCE", UpdatedBy = "Administrator", UpdatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local) },
                        new { Id = 6, CreatedBy = "Administrator", CreatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local), Description = "General Practioner Tariffs", IsDeleted = false, Name = "General Practioner", NormalizedDescription = "GENERALPRACTIONERTARIFFS", NormalizedName = "GENERALPRACTIONER", UpdatedBy = "Administrator", UpdatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local) },
                        new { Id = 7, CreatedBy = "Administrator", CreatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local), Description = "Renal Care Tariffs", IsDeleted = false, Name = "Renal Care", NormalizedDescription = "RENALCARETARIFFS", NormalizedName = "RENALCARE", UpdatedBy = "Administrator", UpdatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local) },
                        new { Id = 8, CreatedBy = "Administrator", CreatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local), Description = "Social Worker Tariffs", IsDeleted = false, Name = "Social Worker", NormalizedDescription = "SOCIALWORKERTARIFFS", NormalizedName = "SOCIALWORKER", UpdatedBy = "Administrator", UpdatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local) },
                        new { Id = 9, CreatedBy = "Administrator", CreatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local), Description = "Wound Care Tariffs", IsDeleted = false, Name = "Wound Care", NormalizedDescription = "WOUNDCARETARIFFS", NormalizedName = "WOUNDCARE", UpdatedBy = "Administrator", UpdatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 565, DateTimeKind.Local) }
                    );
                });

            modelBuilder.Entity("MedicalEngineMicroService.Core.Models.Entities.Tariffs.TariffUnitCost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("ActualAmount")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 38, scale: 17)))
                        .HasColumnType("DECIMAL(19,4)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DATETIME2")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("0");

                    b.Property<string>("ItemDescription");

                    b.Property<int>("TariffId");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("UpdatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DATETIME2")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<DateTime>("ValidFrom")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DATETIME2")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<DateTime>("ValidTo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DATETIME2")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<decimal>("VatAmount")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 38, scale: 17)))
                        .HasColumnType("DECIMAL(19,4)");

                    b.Property<int>("VatId");

                    b.HasKey("Id");

                    b.HasIndex("TariffId");

                    b.HasIndex("VatId");

                    b.ToTable("TariffUnitCosts");
                });

            modelBuilder.Entity("MedicalEngineMicroService.Core.Models.Entities.Tariffs.Vat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DATETIME2")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("0");

                    b.Property<decimal>("Percentage")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 38, scale: 17)))
                        .HasColumnType("DECIMAL(5,2)");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("UpdatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DATETIME2")
                        .HasDefaultValueSql("GetDate()");

                    b.HasKey("Id");

                    b.ToTable("Vats");

                    b.HasData(
                        new { Id = 1, CreatedBy = "Administrator", CreatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 568, DateTimeKind.Local), Description = "14% Percent VAT", IsDeleted = false, Percentage = 0.14m, UpdatedBy = "Administrator", UpdatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 568, DateTimeKind.Local) },
                        new { Id = 2, CreatedBy = "Administrator", CreatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 568, DateTimeKind.Local), Description = "15% Percent VAT", IsDeleted = false, Percentage = 0.15m, UpdatedBy = "Administrator", UpdatedDate = new DateTime(2019, 5, 25, 21, 49, 23, 568, DateTimeKind.Local) }
                    );
                });

            modelBuilder.Entity("MedicalEngineMicroService.Core.Models.Entities.Users.ApplicationRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DATETIME")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("UpdatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DATETIME")
                        .HasDefaultValueSql("GetDate()");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("MedicalEngineMicroService.Core.Models.Entities.Users.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DATETIME")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("PracticeNumber");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("UpdatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DATETIME")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("MedicalEngineMicroService.Core.Models.Entities.Users.ApplicationUserRole", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Publication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DATETIME2")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("From");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("0");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("NormalizedDescription")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("NormalizedName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime?>("To");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("UpdatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DATETIME2")
                        .HasDefaultValueSql("GetDate()");

                    b.HasKey("Id");

                    b.ToTable("Publications");
                });

            modelBuilder.Entity("MedicalEngineMicroService.Core.Models.Entities.Tariffs.Tariff", b =>
                {
                    b.HasOne("MedicalEngineMicroService.Core.Models.Entities.Tariffs.TariffType", "TariffType")
                        .WithMany("Tariffs")
                        .HasForeignKey("TariffTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MedicalEngineMicroService.Core.Models.Entities.Tariffs.TariffUnitCost", b =>
                {
                    b.HasOne("MedicalEngineMicroService.Core.Models.Entities.Tariffs.Tariff", "Tariff")
                        .WithMany("TariffUnitCostS")
                        .HasForeignKey("TariffId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MedicalEngineMicroService.Core.Models.Entities.Tariffs.Vat", "Vat")
                        .WithMany()
                        .HasForeignKey("VatId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MedicalEngineMicroService.Core.Models.Entities.Users.ApplicationUserRole", b =>
                {
                    b.HasOne("MedicalEngineMicroService.Core.Models.Entities.Users.ApplicationRole", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MedicalEngineMicroService.Core.Models.Entities.Users.ApplicationUser", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("MedicalEngineMicroService.Core.Models.Entities.Users.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MedicalEngineMicroService.Core.Models.Entities.Users.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MedicalEngineMicroService.Core.Models.Entities.Users.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MedicalEngineMicroService.Core.Models.Entities.Users.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
