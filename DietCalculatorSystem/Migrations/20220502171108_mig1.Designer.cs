﻿// <auto-generated />
using System;
using DietCalculatorSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DietCalculatorSystem.Migrations
{
    [DbContext(typeof(DietCalculatorDbContext))]
    [Migration("20220502171108_mig1")]
    partial class mig1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DietCalculatorSystem.Data.Models.Diet", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double?>("BreakfastCalories")
                        .HasColumnType("float");

                    b.Property<double?>("BreakfastCarbohydrates")
                        .HasColumnType("float");

                    b.Property<double?>("BreakfastFats")
                        .HasColumnType("float");

                    b.Property<double?>("BreakfastProteins")
                        .HasColumnType("float");

                    b.Property<double?>("DinnerCalories")
                        .HasColumnType("float");

                    b.Property<double?>("DinnerCarbohydrates")
                        .HasColumnType("float");

                    b.Property<double?>("DinnerFats")
                        .HasColumnType("float");

                    b.Property<double?>("DinnerProteins")
                        .HasColumnType("float");

                    b.Property<double?>("LunchCalories")
                        .HasColumnType("float");

                    b.Property<double?>("LunchCarbohydrates")
                        .HasColumnType("float");

                    b.Property<double?>("LunchFats")
                        .HasColumnType("float");

                    b.Property<double?>("LunchProteins")
                        .HasColumnType("float");

                    b.Property<double?>("TotalCalories")
                        .HasColumnType("float");

                    b.Property<double?>("TotalCarbohydrates")
                        .HasColumnType("float");

                    b.Property<double?>("TotalFats")
                        .HasColumnType("float");

                    b.Property<double?>("TotalProteins")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Diets");
                });

            modelBuilder.Entity("DietCalculatorSystem.Data.Models.Food", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double?>("Calories")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<double?>("Carbohydrates")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Fats")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PictureUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Proteins")
                        .IsRequired()
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("DietCalculatorSystem.Data.Models.ManyToManyRelationships.BreakfastFood", b =>
                {
                    b.Property<string>("DietId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FoodId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("DietId", "FoodId");

                    b.HasIndex("FoodId");

                    b.ToTable("BreakfastFoods");
                });

            modelBuilder.Entity("DietCalculatorSystem.Data.Models.ManyToManyRelationships.DinnerFood", b =>
                {
                    b.Property<string>("DietId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FoodId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("DietId", "FoodId");

                    b.HasIndex("FoodId");

                    b.ToTable("DinnerFoods");
                });

            modelBuilder.Entity("DietCalculatorSystem.Data.Models.ManyToManyRelationships.LunchFood", b =>
                {
                    b.Property<string>("DietId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FoodId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("DietId", "FoodId");

                    b.HasIndex("FoodId");

                    b.ToTable("LunchFoods");
                });

            modelBuilder.Entity("DietCalculatorSystem.Data.Models.ManyToManyRelationships.TotalFood", b =>
                {
                    b.Property<string>("DietId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FoodId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("DietId", "FoodId");

                    b.HasIndex("FoodId");

                    b.ToTable("TotalFood");
                });

            modelBuilder.Entity("DietCalculatorSystem.Data.Models.OneToOneRelationships.BalancedDiet", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DietId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "DietId");

                    b.HasIndex("DietId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("BalancedDiets");
                });

            modelBuilder.Entity("DietCalculatorSystem.Data.Models.OneToOneRelationships.DeficitDiet", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DietId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "DietId");

                    b.HasIndex("DietId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("DeficitDiets");
                });

            modelBuilder.Entity("DietCalculatorSystem.Data.Models.OneToOneRelationships.SurplusDiet", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DietId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "DietId");

                    b.HasIndex("DietId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("SurplusDiets");
                });

            modelBuilder.Entity("DietCalculatorSystem.Data.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("BalancedDietId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeficitDietId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SurplusDietId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("DietCalculatorSystem.Data.Models.ManyToManyRelationships.BreakfastFood", b =>
                {
                    b.HasOne("DietCalculatorSystem.Data.Models.Diet", "Diet")
                        .WithMany("BreakfastFoods")
                        .HasForeignKey("DietId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DietCalculatorSystem.Data.Models.Food", "Food")
                        .WithMany()
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Diet");

                    b.Navigation("Food");
                });

            modelBuilder.Entity("DietCalculatorSystem.Data.Models.ManyToManyRelationships.DinnerFood", b =>
                {
                    b.HasOne("DietCalculatorSystem.Data.Models.Diet", "Diet")
                        .WithMany("DinnerFoods")
                        .HasForeignKey("DietId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DietCalculatorSystem.Data.Models.Food", "Food")
                        .WithMany()
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Diet");

                    b.Navigation("Food");
                });

            modelBuilder.Entity("DietCalculatorSystem.Data.Models.ManyToManyRelationships.LunchFood", b =>
                {
                    b.HasOne("DietCalculatorSystem.Data.Models.Diet", "Diet")
                        .WithMany("LunchFoods")
                        .HasForeignKey("DietId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DietCalculatorSystem.Data.Models.Food", "Food")
                        .WithMany()
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Diet");

                    b.Navigation("Food");
                });

            modelBuilder.Entity("DietCalculatorSystem.Data.Models.ManyToManyRelationships.TotalFood", b =>
                {
                    b.HasOne("DietCalculatorSystem.Data.Models.Diet", "Diet")
                        .WithMany("TotalFoods")
                        .HasForeignKey("DietId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DietCalculatorSystem.Data.Models.Food", "Food")
                        .WithMany()
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Diet");

                    b.Navigation("Food");
                });

            modelBuilder.Entity("DietCalculatorSystem.Data.Models.OneToOneRelationships.BalancedDiet", b =>
                {
                    b.HasOne("DietCalculatorSystem.Data.Models.Diet", "Diet")
                        .WithMany()
                        .HasForeignKey("DietId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DietCalculatorSystem.Data.Models.User", "User")
                        .WithOne("BalancedDiet")
                        .HasForeignKey("DietCalculatorSystem.Data.Models.OneToOneRelationships.BalancedDiet", "UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Diet");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DietCalculatorSystem.Data.Models.OneToOneRelationships.DeficitDiet", b =>
                {
                    b.HasOne("DietCalculatorSystem.Data.Models.Diet", "Diet")
                        .WithMany()
                        .HasForeignKey("DietId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DietCalculatorSystem.Data.Models.User", "User")
                        .WithOne("DeficitDiet")
                        .HasForeignKey("DietCalculatorSystem.Data.Models.OneToOneRelationships.DeficitDiet", "UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Diet");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DietCalculatorSystem.Data.Models.OneToOneRelationships.SurplusDiet", b =>
                {
                    b.HasOne("DietCalculatorSystem.Data.Models.Diet", "Diet")
                        .WithMany()
                        .HasForeignKey("DietId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DietCalculatorSystem.Data.Models.User", "User")
                        .WithOne("SurplusDiet")
                        .HasForeignKey("DietCalculatorSystem.Data.Models.OneToOneRelationships.SurplusDiet", "UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Diet");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DietCalculatorSystem.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DietCalculatorSystem.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DietCalculatorSystem.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DietCalculatorSystem.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DietCalculatorSystem.Data.Models.Diet", b =>
                {
                    b.Navigation("BreakfastFoods");

                    b.Navigation("DinnerFoods");

                    b.Navigation("LunchFoods");

                    b.Navigation("TotalFoods");
                });

            modelBuilder.Entity("DietCalculatorSystem.Data.Models.User", b =>
                {
                    b.Navigation("BalancedDiet");

                    b.Navigation("DeficitDiet");

                    b.Navigation("SurplusDiet");
                });
#pragma warning restore 612, 618
        }
    }
}
