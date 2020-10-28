﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ZeroWaste.Data;

namespace ZeroWaste.Migrations
{
    [DbContext(typeof(ZeroWasteContext))]
    partial class ZeroWasteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(767)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(767)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(767)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(767)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(767)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ZeroWaste.Models.Allergy", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.Property<long?>("ZWMemberID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("ZWMemberID");

                    b.ToTable("Allergies");
                });

            modelBuilder.Entity("ZeroWaste.Models.Ingredient", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("PictureLink")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.Property<long?>("ZWMemberID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("ZWMemberID");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("ZeroWaste.Models.Keyword", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long?>("AllergyID")
                        .HasColumnType("bigint");

                    b.Property<long?>("IngredientID")
                        .HasColumnType("bigint");

                    b.Property<long?>("IngredientID1")
                        .HasColumnType("bigint");

                    b.Property<long?>("NewsID")
                        .HasColumnType("bigint");

                    b.Property<long?>("RecipieId")
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<long?>("ZWMemberID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("AllergyID");

                    b.HasIndex("IngredientID");

                    b.HasIndex("IngredientID1");

                    b.HasIndex("NewsID");

                    b.HasIndex("RecipieId");

                    b.HasIndex("ZWMemberID");

                    b.ToTable("Keywords");
                });

            modelBuilder.Entity("ZeroWaste.Models.News", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int>("MainText")
                        .HasColumnType("int");

                    b.Property<string>("PictureLink")
                        .HasColumnType("text");

                    b.Property<DateTime>("PublicationDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("News");
                });

            modelBuilder.Entity("ZeroWaste.Models.NutritionalType", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("NutritionalTypes");
                });

            modelBuilder.Entity("ZeroWaste.Models.Recipie", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int>("ExecTime")
                        .HasColumnType("int");

                    b.Property<string>("PictureLink1")
                        .HasColumnType("text");

                    b.Property<string>("PictureLink2")
                        .HasColumnType("text");

                    b.Property<int>("Portions")
                        .HasColumnType("int");

                    b.Property<int>("PrepTime")
                        .HasColumnType("int");

                    b.Property<int>("PreparationMethod")
                        .HasColumnType("int");

                    b.Property<int>("Simplicity")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<long?>("ZWMemberID")
                        .HasColumnType("bigint");

                    b.Property<long?>("ZWMemberID1")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ZWMemberID");

                    b.HasIndex("ZWMemberID1");

                    b.ToTable("Recipies");
                });

            modelBuilder.Entity("ZeroWaste.Models.RecipieIngredient", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<float>("Amount")
                        .HasColumnType("float");

                    b.Property<long?>("IngredientID")
                        .HasColumnType("bigint");

                    b.Property<long?>("RecipieId")
                        .HasColumnType("bigint");

                    b.Property<string>("Unit")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("IngredientID");

                    b.HasIndex("RecipieId");

                    b.ToTable("RecipieIngredient");
                });

            modelBuilder.Entity("ZeroWaste.Models.RecipieNutritionalType", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long?>("NutrionalTypeID")
                        .HasColumnType("bigint");

                    b.Property<float>("NutrionalValue")
                        .HasColumnType("float");

                    b.Property<long?>("RecipieId")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("NutrionalTypeID");

                    b.HasIndex("RecipieId");

                    b.ToTable("RecipieNutritionalType");
                });

            modelBuilder.Entity("ZeroWaste.Models.ZWMember", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DoB")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Gender")
                        .HasColumnType("text");

                    b.Property<string>("PictureLink")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("ZWMembers");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ZeroWaste.Models.Allergy", b =>
                {
                    b.HasOne("ZeroWaste.Models.ZWMember", null)
                        .WithMany("Allergies")
                        .HasForeignKey("ZWMemberID");
                });

            modelBuilder.Entity("ZeroWaste.Models.Ingredient", b =>
                {
                    b.HasOne("ZeroWaste.Models.ZWMember", null)
                        .WithMany("FavoriteIngredients")
                        .HasForeignKey("ZWMemberID");
                });

            modelBuilder.Entity("ZeroWaste.Models.Keyword", b =>
                {
                    b.HasOne("ZeroWaste.Models.Allergy", null)
                        .WithMany("Keywords")
                        .HasForeignKey("AllergyID");

                    b.HasOne("ZeroWaste.Models.Ingredient", null)
                        .WithMany("Keywords")
                        .HasForeignKey("IngredientID");

                    b.HasOne("ZeroWaste.Models.Ingredient", null)
                        .WithMany("OtherNames")
                        .HasForeignKey("IngredientID1");

                    b.HasOne("ZeroWaste.Models.News", null)
                        .WithMany("Keywords")
                        .HasForeignKey("NewsID");

                    b.HasOne("ZeroWaste.Models.Recipie", null)
                        .WithMany("Keywords")
                        .HasForeignKey("RecipieId");

                    b.HasOne("ZeroWaste.Models.ZWMember", null)
                        .WithMany("PreferencesKeywords")
                        .HasForeignKey("ZWMemberID");
                });

            modelBuilder.Entity("ZeroWaste.Models.Recipie", b =>
                {
                    b.HasOne("ZeroWaste.Models.ZWMember", null)
                        .WithMany("FavoriteRecipies")
                        .HasForeignKey("ZWMemberID");

                    b.HasOne("ZeroWaste.Models.ZWMember", null)
                        .WithMany("TestedRecipies")
                        .HasForeignKey("ZWMemberID1");
                });

            modelBuilder.Entity("ZeroWaste.Models.RecipieIngredient", b =>
                {
                    b.HasOne("ZeroWaste.Models.Ingredient", "Ingredient")
                        .WithMany()
                        .HasForeignKey("IngredientID");

                    b.HasOne("ZeroWaste.Models.Recipie", null)
                        .WithMany("Ingredients")
                        .HasForeignKey("RecipieId");
                });

            modelBuilder.Entity("ZeroWaste.Models.RecipieNutritionalType", b =>
                {
                    b.HasOne("ZeroWaste.Models.NutritionalType", "NutrionalType")
                        .WithMany()
                        .HasForeignKey("NutrionalTypeID");

                    b.HasOne("ZeroWaste.Models.Recipie", null)
                        .WithMany("NutrionalTypes")
                        .HasForeignKey("RecipieId");
                });
#pragma warning restore 612, 618
        }
    }
}
