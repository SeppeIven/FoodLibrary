﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TodoApi.Models;

namespace TodoApi.Migrations
{
    [DbContext(typeof(FoodLibraryContext))]
    partial class FoodLibraryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("TodoApi.Models.Dish", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("MealType")
                        .HasColumnType("text");

                    b.Property<string>("Meat")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PreparationTimeMinutes")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.ToTable("Dishes");
                });

            modelBuilder.Entity("TodoApi.Models.DishIngredientRelation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("AmountPerPerson")
                        .HasColumnType("integer");

                    b.Property<string>("UnitType")
                        .HasColumnType("text");

                    b.Property<int?>("dishID")
                        .HasColumnType("integer");

                    b.Property<int?>("ingredientID")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.HasIndex("dishID");

                    b.HasIndex("ingredientID");

                    b.ToTable("DishIngredientRelations");
                });

            modelBuilder.Entity("TodoApi.Models.Ingredient", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("TodoApi.Models.DishIngredientRelation", b =>
                {
                    b.HasOne("TodoApi.Models.Dish", "dish")
                        .WithMany()
                        .HasForeignKey("dishID");

                    b.HasOne("TodoApi.Models.Ingredient", "ingredient")
                        .WithMany()
                        .HasForeignKey("ingredientID");

                    b.Navigation("dish");

                    b.Navigation("ingredient");
                });
#pragma warning restore 612, 618
        }
    }
}
