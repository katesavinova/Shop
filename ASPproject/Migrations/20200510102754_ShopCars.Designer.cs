﻿// <auto-generated />
using System;
using ASPproject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASPproject.Migrations
{
    [DbContext(typeof(AppDBContent))]
    [Migration("20200510102754_ShopCars")]
    partial class ShopCars
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ASPproject.Data.Models.Car", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("available");

                    b.Property<int>("categoryID");

                    b.Property<string>("img");

                    b.Property<bool>("isFavourite");

                    b.Property<string>("longDesc");

                    b.Property<string>("name");

                    b.Property<int>("price");

                    b.Property<string>("shortDesc");

                    b.HasKey("id");

                    b.HasIndex("categoryID");

                    b.ToTable("Car");
                });

            modelBuilder.Entity("ASPproject.Data.Models.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("categoreName");

                    b.Property<string>("desc");

                    b.HasKey("id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("ASPproject.Data.Models.ShopCaritem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ShopCarId");

                    b.Property<int?>("carid");

                    b.Property<int>("price");

                    b.HasKey("Id");

                    b.HasIndex("carid");

                    b.ToTable("ShopCaritems");
                });

            modelBuilder.Entity("ASPproject.Data.Models.Car", b =>
                {
                    b.HasOne("ASPproject.Data.Models.Category", "Category")
                        .WithMany("cars")
                        .HasForeignKey("categoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ASPproject.Data.Models.ShopCaritem", b =>
                {
                    b.HasOne("ASPproject.Data.Models.Car", "car")
                        .WithMany()
                        .HasForeignKey("carid");
                });
#pragma warning restore 612, 618
        }
    }
}
