﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TrackYourLife.Common.Persistence;


#nullable disable

namespace TrackYourLife.Persistence.Migrations
{
    [DbContext(typeof(ApplicationWriteDbContext))]
    [Migration("20240503153143_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("TrackYourLifeDotnet.Domain.FoodDiaries.FoodDiaryEntry", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedOnUtc")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<Guid>("FoodId")
                        .HasColumnType("uuid");

                    b.Property<string>("MealType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("ModifiedOnUtc")
                        .HasColumnType("timestamp with time zone");

                    b.Property<float>("Quantity")
                        .HasColumnType("real");

                    b.Property<Guid>("ServingSizeId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("FoodId");

                    b.HasIndex("ServingSizeId");

                    b.HasIndex("UserId");

                    b.ToTable("FoodDiary", (string)null);
                });

            modelBuilder.Entity("TrackYourLifeDotnet.Domain.Foods.Food", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<long?>("ApiId")
                        .HasColumnType("bigint");

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text")
                        .HasDefaultValue("");

                    b.Property<string>("CountryCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ApiId")
                        .IsUnique();

                    b.ToTable("Food", (string)null);
                });

            modelBuilder.Entity("TrackYourLifeDotnet.Domain.Foods.FoodServingSize", b =>
                {
                    b.Property<Guid>("FoodId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ServingSizeId")
                        .HasColumnType("uuid");

                    b.Property<int>("Index")
                        .HasColumnType("integer");

                    b.HasKey("FoodId", "ServingSizeId");

                    b.HasIndex("ServingSizeId");

                    b.ToTable("FoodServingSize", (string)null);
                });

            modelBuilder.Entity("TrackYourLifeDotnet.Domain.Foods.SearchedFood", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("SearchedFood", (string)null);
                });

            modelBuilder.Entity("TrackYourLifeDotnet.Domain.OutboxMessages.OutboxMessage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Error")
                        .HasColumnType("text");

                    b.Property<DateTime>("OccurredOnUtc")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("ProcessedOnUtc")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("OutboxMessages", (string)null);
                });

            modelBuilder.Entity("TrackYourLifeDotnet.Domain.OutboxMessages.OutboxMessageConsumer", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id", "Name");

                    b.ToTable("OutboxMessageConsumers", (string)null);
                });

            modelBuilder.Entity("TrackYourLifeDotnet.Domain.ServingSizes.ServingSize", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<long?>("ApiId")
                        .HasColumnType("bigint");

                    b.Property<double>("NutritionMultiplier")
                        .HasColumnType("double precision");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Value")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("ApiId")
                        .IsUnique();

                    b.ToTable("ServingSize", (string)null);
                });

            modelBuilder.Entity("TrackYourLifeDotnet.Domain.UserGoals.UserGoal", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateOnly>("EndDate")
                        .HasColumnType("date");

                    b.Property<string>("PerPeriod")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<int>("Value")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserGoals", (string)null);
                });

            modelBuilder.Entity("TrackYourLifeDotnet.Domain.Users.User", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedOnUtc")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime?>("ModifiedOnUtc")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("VerifiedOnUtc")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("TrackYourLifeDotnet.Domain.Users.UserToken", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("ExpiresAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("Value")
                        .IsUnique();

                    b.ToTable("UserTokens", (string)null);
                });

            modelBuilder.Entity("TrackYourLifeDotnet.Domain.FoodDiaries.FoodDiaryEntry", b =>
                {
                    b.HasOne("TrackYourLifeDotnet.Domain.Foods.Food", "Food")
                        .WithMany()
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrackYourLifeDotnet.Domain.ServingSizes.ServingSize", "ServingSize")
                        .WithMany()
                        .HasForeignKey("ServingSizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrackYourLifeDotnet.Domain.Users.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Food");

                    b.Navigation("ServingSize");
                });

            modelBuilder.Entity("TrackYourLifeDotnet.Domain.Foods.Food", b =>
                {
                    b.OwnsOne("TrackYourLifeDotnet.Domain.Foods.NutritionalContent", "NutritionalContent", b1 =>
                        {
                            b1.Property<Guid>("FoodId")
                                .HasColumnType("uuid");

                            b1.Property<double>("Calcium")
                                .HasColumnType("double precision");

                            b1.Property<double>("Carbohydrates")
                                .HasColumnType("double precision");

                            b1.Property<double>("Cholesterol")
                                .HasColumnType("double precision");

                            b1.Property<double>("Fat")
                                .HasColumnType("double precision");

                            b1.Property<double>("Fiber")
                                .HasColumnType("double precision");

                            b1.Property<double>("Iron")
                                .HasColumnType("double precision");

                            b1.Property<double>("MonounsaturatedFat")
                                .HasColumnType("double precision");

                            b1.Property<double>("NetCarbs")
                                .HasColumnType("double precision");

                            b1.Property<double>("PolyunsaturatedFat")
                                .HasColumnType("double precision");

                            b1.Property<double>("Potassium")
                                .HasColumnType("double precision");

                            b1.Property<double>("Protein")
                                .HasColumnType("double precision");

                            b1.Property<double>("SaturatedFat")
                                .HasColumnType("double precision");

                            b1.Property<double>("Sodium")
                                .HasColumnType("double precision");

                            b1.Property<double>("Sugar")
                                .HasColumnType("double precision");

                            b1.Property<double>("TransFat")
                                .HasColumnType("double precision");

                            b1.Property<double>("VitaminA")
                                .HasColumnType("double precision");

                            b1.Property<double>("VitaminC")
                                .HasColumnType("double precision");

                            b1.HasKey("FoodId");

                            b1.ToTable("Food");

                            b1.WithOwner()
                                .HasForeignKey("FoodId");

                            b1.OwnsOne("TrackYourLifeDotnet.Domain.Foods.Energy", "Energy", b2 =>
                                {
                                    b2.Property<Guid>("NutritionalContentFoodId")
                                        .HasColumnType("uuid");

                                    b2.Property<string>("Unit")
                                        .IsRequired()
                                        .HasColumnType("text");

                                    b2.Property<float>("Value")
                                        .HasColumnType("real");

                                    b2.HasKey("NutritionalContentFoodId");

                                    b2.ToTable("Food");

                                    b2.WithOwner()
                                        .HasForeignKey("NutritionalContentFoodId");
                                });

                            b1.Navigation("Energy")
                                .IsRequired();
                        });

                    b.Navigation("NutritionalContent")
                        .IsRequired();
                });

            modelBuilder.Entity("TrackYourLifeDotnet.Domain.Foods.FoodServingSize", b =>
                {
                    b.HasOne("TrackYourLifeDotnet.Domain.Foods.Food", null)
                        .WithMany("FoodServingSizes")
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrackYourLifeDotnet.Domain.ServingSizes.ServingSize", "ServingSize")
                        .WithMany()
                        .HasForeignKey("ServingSizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ServingSize");
                });

            modelBuilder.Entity("TrackYourLifeDotnet.Domain.UserGoals.UserGoal", b =>
                {
                    b.HasOne("TrackYourLifeDotnet.Domain.Users.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TrackYourLifeDotnet.Domain.Users.UserToken", b =>
                {
                    b.HasOne("TrackYourLifeDotnet.Domain.Users.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TrackYourLifeDotnet.Domain.Foods.Food", b =>
                {
                    b.Navigation("FoodServingSizes");
                });
#pragma warning restore 612, 618
        }
    }
}