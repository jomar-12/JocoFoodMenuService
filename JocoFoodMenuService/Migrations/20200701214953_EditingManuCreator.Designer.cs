﻿// <auto-generated />
using System;
using JocoFoodMenuService.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JocoFoodMenuService.Migrations
{
    [DbContext(typeof(JocoFoodMenuServiceContext))]
    [Migration("20200701214953_EditingManuCreator")]
    partial class EditingManuCreator
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JocoFoodMenuService.Models.Beverage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MenuCreatorId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MenuCreatorId");

                    b.ToTable("Beverage");
                });

            modelBuilder.Entity("JocoFoodMenuService.Models.Complement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MenuCreatorId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MenuCreatorId");

                    b.ToTable("Complement");
                });

            modelBuilder.Entity("JocoFoodMenuService.Models.Grain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MenuCreatorId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MenuCreatorId");

                    b.ToTable("Grain");
                });

            modelBuilder.Entity("JocoFoodMenuService.Models.Meat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MenuCreatorId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MenuCreatorId");

                    b.ToTable("Meat");
                });

            modelBuilder.Entity("JocoFoodMenuService.Models.MenuCreator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MenuDaily")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MenuDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("MenuCreator");
                });

            modelBuilder.Entity("JocoFoodMenuService.Models.Rice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MenuCreatorId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MenuCreatorId");

                    b.ToTable("Rice");
                });

            modelBuilder.Entity("JocoFoodMenuService.Models.Beverage", b =>
                {
                    b.HasOne("JocoFoodMenuService.Models.MenuCreator", "MenuCreator")
                        .WithMany()
                        .HasForeignKey("MenuCreatorId");
                });

            modelBuilder.Entity("JocoFoodMenuService.Models.Complement", b =>
                {
                    b.HasOne("JocoFoodMenuService.Models.MenuCreator", "MenuCreator")
                        .WithMany()
                        .HasForeignKey("MenuCreatorId");
                });

            modelBuilder.Entity("JocoFoodMenuService.Models.Grain", b =>
                {
                    b.HasOne("JocoFoodMenuService.Models.MenuCreator", "MenuCreator")
                        .WithMany()
                        .HasForeignKey("MenuCreatorId");
                });

            modelBuilder.Entity("JocoFoodMenuService.Models.Meat", b =>
                {
                    b.HasOne("JocoFoodMenuService.Models.MenuCreator", "MenuCreator")
                        .WithMany()
                        .HasForeignKey("MenuCreatorId");
                });

            modelBuilder.Entity("JocoFoodMenuService.Models.Rice", b =>
                {
                    b.HasOne("JocoFoodMenuService.Models.MenuCreator", "MenuCreator")
                        .WithMany()
                        .HasForeignKey("MenuCreatorId");
                });
#pragma warning restore 612, 618
        }
    }
}