﻿// <auto-generated />
using System;
using CleanArchitectureConcept_Infrastructure.Persistence.ApplicationDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CleanArchitectureConcept_Infrastructure.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    partial class DataBaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CleanArchitectureConcept_Domain.Entities.Company", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = "c9d4c053-49b6-410c-bc78-2d54a9991870",
                            Address = "583 Wall Dr. Gwynn Oak, MD 21207",
                            Country = "USA",
                            CreatedAt = new DateTime(2023, 8, 9, 15, 25, 4, 618, DateTimeKind.Utc).AddTicks(1572),
                            ModifiedAt = new DateTime(2023, 8, 9, 15, 25, 4, 618, DateTimeKind.Utc).AddTicks(1579),
                            Name = "IT_Solutions Ltd"
                        },
                        new
                        {
                            Id = "3d490a70-94ce-4d15-9494-5248280c2ce3",
                            Address = "312 Forest Avenue, BF 923",
                            Country = "USA",
                            CreatedAt = new DateTime(2023, 8, 9, 15, 25, 4, 618, DateTimeKind.Utc).AddTicks(1622),
                            ModifiedAt = new DateTime(2023, 8, 9, 15, 25, 4, 618, DateTimeKind.Utc).AddTicks(1622),
                            Name = "Admin_Solutions Ltd"
                        });
                });

            modelBuilder.Entity("CleanArchitectureConcept_Domain.Entities.Employee", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("CompanyId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = "80abbca8-664d-4b20-b5de-024705497d4a",
                            Age = 26,
                            CompanyId = "c9d4c053-49b6-410c-bc78-2d54a9991870",
                            CreatedAt = new DateTime(2023, 8, 9, 15, 25, 4, 618, DateTimeKind.Utc).AddTicks(2033),
                            ModifiedAt = new DateTime(2023, 8, 9, 15, 25, 4, 618, DateTimeKind.Utc).AddTicks(2034),
                            Name = "Sam Raiden",
                            Position = "Software developer"
                        },
                        new
                        {
                            Id = "86dba8c0-d178-41e7-938c-ed49778fb52a",
                            Age = 30,
                            CompanyId = "3d490a70-94ce-4d15-9494-5248280c2ce3",
                            CreatedAt = new DateTime(2023, 8, 9, 15, 25, 4, 618, DateTimeKind.Utc).AddTicks(2046),
                            ModifiedAt = new DateTime(2023, 8, 9, 15, 25, 4, 618, DateTimeKind.Utc).AddTicks(2046),
                            Name = "Jana McLeaf",
                            Position = "Software developer"
                        });
                });

            modelBuilder.Entity("CleanArchitectureConcept_Domain.Entities.Employee", b =>
                {
                    b.HasOne("CleanArchitectureConcept_Domain.Entities.Company", "Company")
                        .WithMany("Employees")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("CleanArchitectureConcept_Domain.Entities.Company", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
