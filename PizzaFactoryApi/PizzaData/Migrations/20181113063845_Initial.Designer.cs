﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PizzaData;

namespace PizzaData.Migrations
{
    [DbContext(typeof(PizzaContext))]
    [Migration("20181113063845_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("Relational:Sequence:.Id", "'Id', '', '1', '1', '', '', 'Int32', 'False'");

            modelBuilder.Entity("PizzaData.Models.Ingredient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Cost");

                    b.Property<string>("Description");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("PizzaData.Models.Pizza", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Cost");

                    b.Property<string>("Description");

                    b.Property<bool>("Hit");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Pizza");
                });

            modelBuilder.Entity("PizzaData.Models.PizzaIngredient", b =>
                {
                    b.Property<Guid>("IngredientId");

                    b.Property<Guid>("PizzaId");

                    b.Property<Guid>("Id");

                    b.HasKey("IngredientId", "PizzaId");

                    b.HasIndex("PizzaId");

                    b.ToTable("PizzaIngredient");
                });

            modelBuilder.Entity("PizzaData.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PizzaData.Models.PizzaIngredient", b =>
                {
                    b.HasOne("PizzaData.Models.Ingredient", "Ingredient")
                        .WithMany("Pizzas")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PizzaData.Models.Pizza", "Pizza")
                        .WithMany("Recipe")
                        .HasForeignKey("PizzaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}