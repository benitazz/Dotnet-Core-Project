﻿// <auto-generated />
using System;
using MedicalBilingMicroservice.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace switchapi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MedicalBilingBackEnd.Core.Models.Entities.Lookups.FileStatus", b =>
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

                    b.Property<string>("Name")
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
                        new { Id = 1, CreatedBy = "Administrator", CreatedDate = new DateTime(2018, 9, 25, 3, 54, 38, 174, DateTimeKind.Utc), Description = "Successfully uploaded the file", Name = "Uploaded", UpdatedBy = "Administrator", UpdatedDate = new DateTime(2018, 9, 25, 3, 54, 38, 175, DateTimeKind.Utc) },
                        new { Id = 2, CreatedBy = "Administrator", CreatedDate = new DateTime(2018, 9, 25, 3, 54, 38, 175, DateTimeKind.Utc), Description = "The manager rejected the file", Name = "Rejected", UpdatedBy = "Administrator", UpdatedDate = new DateTime(2018, 9, 25, 3, 54, 38, 175, DateTimeKind.Utc) },
                        new { Id = 3, CreatedBy = "Administrator", CreatedDate = new DateTime(2018, 9, 25, 3, 54, 38, 175, DateTimeKind.Utc), Description = "Ready to submit to the Fund", Name = "Approved", UpdatedBy = "Administrator", UpdatedDate = new DateTime(2018, 9, 25, 3, 54, 38, 175, DateTimeKind.Utc) },
                        new { Id = 4, CreatedBy = "Administrator", CreatedDate = new DateTime(2018, 9, 25, 3, 54, 38, 175, DateTimeKind.Utc), Description = "File successfully submitted to the Fund", Name = "Submitted", UpdatedBy = "Administrator", UpdatedDate = new DateTime(2018, 9, 25, 3, 54, 38, 175, DateTimeKind.Utc) },
                        new { Id = 5, CreatedBy = "Administrator", CreatedDate = new DateTime(2018, 9, 25, 3, 54, 38, 175, DateTimeKind.Utc), Description = "Not all invoices were paid", Name = "Partially Paid", UpdatedBy = "Administrator", UpdatedDate = new DateTime(2018, 9, 25, 3, 54, 38, 175, DateTimeKind.Utc) },
                        new { Id = 6, CreatedBy = "Administrator", CreatedDate = new DateTime(2018, 9, 25, 3, 54, 38, 175, DateTimeKind.Utc), Description = "All invoices were successfully paid", Name = "Paid", UpdatedBy = "Administrator", UpdatedDate = new DateTime(2018, 9, 25, 3, 54, 38, 175, DateTimeKind.Utc) },
                        new { Id = 7, CreatedBy = "Administrator", CreatedDate = new DateTime(2018, 9, 25, 3, 54, 38, 175, DateTimeKind.Utc), Description = "File Overdue", Name = "Overdue", UpdatedBy = "Administrator", UpdatedDate = new DateTime(2018, 9, 25, 3, 54, 38, 175, DateTimeKind.Utc) }
                    );
                });

            modelBuilder.Entity("MedicalBilingBackEnd.Core.Models.Entities.Lookups.InvoiceStatus", b =>
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

                    b.Property<string>("Name")
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
                        new { Id = 1, CreatedBy = "Administrator", CreatedDate = new DateTime(2018, 9, 25, 5, 54, 38, 176, DateTimeKind.Local), Description = "Pending", Name = "Pending", UpdatedBy = "Administrator", UpdatedDate = new DateTime(2018, 9, 25, 5, 54, 38, 176, DateTimeKind.Local) },
                        new { Id = 2, CreatedBy = "Administrator", CreatedDate = new DateTime(2018, 9, 25, 5, 54, 38, 176, DateTimeKind.Local), Description = "Approved", Name = "Approved", UpdatedBy = "Administrator", UpdatedDate = new DateTime(2018, 9, 25, 5, 54, 38, 176, DateTimeKind.Local) },
                        new { Id = 3, CreatedBy = "Administrator", CreatedDate = new DateTime(2018, 9, 25, 5, 54, 38, 176, DateTimeKind.Local), Description = "Payment rejected", Name = "Rejected", UpdatedBy = "Administrator", UpdatedDate = new DateTime(2018, 9, 25, 5, 54, 38, 176, DateTimeKind.Local) },
                        new { Id = 4, CreatedBy = "Administrator", CreatedDate = new DateTime(2018, 9, 25, 5, 54, 38, 176, DateTimeKind.Local), Description = "Invoice submitted to the fund", Name = "Submitted", UpdatedBy = "Administrator", UpdatedDate = new DateTime(2018, 9, 25, 5, 54, 38, 176, DateTimeKind.Local) },
                        new { Id = 5, CreatedBy = "Administrator", CreatedDate = new DateTime(2018, 9, 25, 5, 54, 38, 176, DateTimeKind.Local), Description = "Invoice paid", Name = "Paid", UpdatedBy = "Administrator", UpdatedDate = new DateTime(2018, 9, 25, 5, 54, 38, 176, DateTimeKind.Local) },
                        new { Id = 6, CreatedBy = "Administrator", CreatedDate = new DateTime(2018, 9, 25, 5, 54, 38, 176, DateTimeKind.Local), Description = "Invoice Overdue", Name = "Overdue", UpdatedBy = "Administrator", UpdatedDate = new DateTime(2018, 9, 25, 5, 54, 38, 176, DateTimeKind.Local) }
                    );
                });

            modelBuilder.Entity("MedicalBilingMicroservice.Core.Models.Entities.Users.ApplicationRole", b =>
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

            modelBuilder.Entity("MedicalBilingMicroservice.Core.Models.Entities.Users.ApplicationUser", b =>
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

            modelBuilder.Entity("MedicalBilingMicroservice.Core.Models.Entities.Users.ApplicationUserRole", b =>
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

            modelBuilder.Entity("MedicalBilingMicroservice.Core.Models.Entities.Users.ApplicationUserRole", b =>
                {
                    b.HasOne("MedicalBilingMicroservice.Core.Models.Entities.Users.ApplicationRole", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MedicalBilingMicroservice.Core.Models.Entities.Users.ApplicationUser", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("MedicalBilingMicroservice.Core.Models.Entities.Users.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MedicalBilingMicroservice.Core.Models.Entities.Users.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MedicalBilingMicroservice.Core.Models.Entities.Users.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MedicalBilingMicroservice.Core.Models.Entities.Users.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
