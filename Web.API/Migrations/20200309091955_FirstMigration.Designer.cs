﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Web.API.Data;

namespace Web.API.Migrations
{
    [DbContext(typeof(WebAPIDbContext))]
    [Migration("20200309091955_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

            modelBuilder.Entity("Web.API.Entities.Download", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Remark")
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Downloads");
                });

            modelBuilder.Entity("Web.API.Entities.Storage", b =>
                {
                    b.Property<string>("Pru")
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<int>("Prunum")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Pruspec")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Pru");

                    b.ToTable("Storages");

                    b.HasData(
                        new
                        {
                            Pru = "产品1",
                            Prunum = 1,
                            Pruspec = "规格1"
                        },
                        new
                        {
                            Pru = "产品2",
                            Prunum = 2,
                            Pruspec = "规格2"
                        },
                        new
                        {
                            Pru = "产品3",
                            Prunum = 3,
                            Pruspec = "规格3"
                        },
                        new
                        {
                            Pru = "产品4",
                            Prunum = 4,
                            Pruspec = "规格4"
                        },
                        new
                        {
                            Pru = "产品5",
                            Prunum = 5,
                            Pruspec = "规格5"
                        },
                        new
                        {
                            Pru = "产品6",
                            Prunum = 6,
                            Pruspec = "规格6"
                        });
                });

            modelBuilder.Entity("Web.API.Entities.Upload", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Remark")
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Uploads");
                });
#pragma warning restore 612, 618
        }
    }
}
