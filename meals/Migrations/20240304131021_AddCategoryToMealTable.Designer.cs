﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using meals.Data;

#nullable disable

namespace meals.Migrations
{
    [DbContext(typeof(MealsDBContext))]
    [Migration("20240304131021_AddCategoryToMealTable")]
    partial class AddCategoryToMealTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("meals.Data.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImagUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("meals.Data.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ingredient");
                });

            modelBuilder.Entity("meals.Data.IngredientRecipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("IngredientCountInGM")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.Property<int?>("RecipeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IngredientId");

                    b.HasIndex("RecipeId");

                    b.ToTable("IngredientRecipe");
                });

            modelBuilder.Entity("meals.Data.Meal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Meal");
                });

            modelBuilder.Entity("meals.Data.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("MealId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MealId")
                        .IsUnique()
                        .HasFilter("[MealId] IS NOT NULL");

                    b.ToTable("Recipe");
                });

            modelBuilder.Entity("meals.Data.IngredientRecipe", b =>
                {
                    b.HasOne("meals.Data.Ingredient", "Ingredient")
                        .WithMany()
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("meals.Data.Recipe", "Recipe")
                        .WithMany("IngredientRecipes")
                        .HasForeignKey("RecipeId");

                    b.Navigation("Ingredient");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("meals.Data.Meal", b =>
                {
                    b.HasOne("meals.Data.Category", "Category")
                        .WithMany("Meals")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("meals.Data.Recipe", b =>
                {
                    b.HasOne("meals.Data.Meal", "Meal")
                        .WithOne("Recipe")
                        .HasForeignKey("meals.Data.Recipe", "MealId");

                    b.Navigation("Meal");
                });

            modelBuilder.Entity("meals.Data.Category", b =>
                {
                    b.Navigation("Meals");
                });

            modelBuilder.Entity("meals.Data.Meal", b =>
                {
                    b.Navigation("Recipe")
                        .IsRequired();
                });

            modelBuilder.Entity("meals.Data.Recipe", b =>
                {
                    b.Navigation("IngredientRecipes");
                });
#pragma warning restore 612, 618
        }
    }
}
