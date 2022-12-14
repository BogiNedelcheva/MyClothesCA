// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyClothesCA.Infrastructure.Persistence;

#nullable disable

namespace MyClothesCA.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221009192400_Second")]
    partial class Second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
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

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
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

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MyClothesCA.Domain.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

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

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("MyClothesCA.Domain.Entities.Category", b =>
                {
                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = "1",
                            ImageUrl = "https://images.unsplash.com/photo-1620799140408-edc6dcb6d633?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=772&q=80",
                            Name = "Tops"
                        },
                        new
                        {
                            CategoryId = "2",
                            ImageUrl = "https://image.made-in-china.com/202f0j00KstVjilPEIov/Spring-Autumn-Solid-Children-Sweatpants-Overalls-Casual-Kids-Clothes-Trousers-Pants-for-Toddler-Baby-Boys.jpg",
                            Name = "Bottoms"
                        },
                        new
                        {
                            CategoryId = "3",
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRasPMutrSVbqShT-0oGXzDQzvW02zn1qxHZw&usqp=CAU",
                            Name = "Shoes"
                        },
                        new
                        {
                            CategoryId = "4",
                            ImageUrl = "https://media.istockphoto.com/photos/fashion-in-new-york-city-picture-id186543936?k=20&m=186543936&s=612x612&w=0&h=gHHBtMHDGD7EnVRZawGxKpSI_LEhYEvS49DGo3UYu4I=",
                            Name = "Dresses"
                        },
                        new
                        {
                            CategoryId = "5",
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSDCbH7ePNeJPR_vH1LejSPlGtItvFEM4dc4g&usqp=CAU",
                            Name = "Bags"
                        },
                        new
                        {
                            CategoryId = "6",
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR852-Y1089K1O-4Z3A5kcuYqEE2Yg9T_95Dg&usqp=CAU",
                            Name = "Accessories"
                        },
                        new
                        {
                            CategoryId = "7",
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTK7lBmtYRlf3xGbkpz12obB6wk61zW4-LTX7I5XwdN2jBvSslJlCS9O1r_TUR77Fts4zQ&usqp=CAU",
                            Name = "Outerwear"
                        });
                });

            modelBuilder.Entity("MyClothesCA.Domain.Entities.Colour", b =>
                {
                    b.Property<string>("ColourId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("ColourId");

                    b.ToTable("Colours");

                    b.HasData(
                        new
                        {
                            ColourId = "1",
                            Name = "White"
                        },
                        new
                        {
                            ColourId = "2",
                            Name = "Black"
                        },
                        new
                        {
                            ColourId = "3",
                            Name = "Red"
                        },
                        new
                        {
                            ColourId = "4",
                            Name = "Blue"
                        },
                        new
                        {
                            ColourId = "5",
                            Name = "Orange"
                        },
                        new
                        {
                            ColourId = "6",
                            Name = "Brown"
                        },
                        new
                        {
                            ColourId = "7",
                            Name = "Beige"
                        },
                        new
                        {
                            ColourId = "8",
                            Name = "Green"
                        },
                        new
                        {
                            ColourId = "9",
                            Name = "Yellow"
                        },
                        new
                        {
                            ColourId = "10",
                            Name = "Turquoise"
                        },
                        new
                        {
                            ColourId = "11",
                            Name = "Mint"
                        },
                        new
                        {
                            ColourId = "12",
                            Name = "Ruby"
                        });
                });

            modelBuilder.Entity("MyClothesCA.Domain.Entities.Garment", b =>
                {
                    b.Property<string>("GarmentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ColourId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ImageId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeasonId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("GarmentId");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ColourId");

                    b.HasIndex("SeasonId");

                    b.ToTable("Clothes");
                });

            modelBuilder.Entity("MyClothesCA.Domain.Entities.Image", b =>
                {
                    b.Property<string>("ImageId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AddedByApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Extension")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RemoteImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ImageId");

                    b.HasIndex("AddedByApplicationUserId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("MyClothesCA.Domain.Entities.Season", b =>
                {
                    b.Property<string>("SeasonId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("SeasonId");

                    b.ToTable("Seasons");

                    b.HasData(
                        new
                        {
                            SeasonId = "f96622db-2708-43cc-99e3-3e8e7d80ae77",
                            Name = "Autumn "
                        },
                        new
                        {
                            SeasonId = "742f395f-1d93-45f0-af9c-92cb10082956",
                            Name = "Winter"
                        },
                        new
                        {
                            SeasonId = "0c84af58-67c4-41a4-81ef-fbd864f3f758",
                            Name = "Spring"
                        },
                        new
                        {
                            SeasonId = "41e43896-df44-443a-ad87-74781a3b52ed",
                            Name = "Summer"
                        });
                });

            modelBuilder.Entity("MyClothesCA.Domain.Entities.UserCategory", b =>
                {
                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ApplicationUserId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("UsersCategories");
                });

            modelBuilder.Entity("MyClothesCA.Domain.Entities.UserClothes", b =>
                {
                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GarmentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ApplicationUserId1")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ApplicationUserId", "GarmentId");

                    b.HasIndex("ApplicationUserId1");

                    b.HasIndex("GarmentId");

                    b.ToTable("UserClothes");
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
                    b.HasOne("MyClothesCA.Domain.Entities.ApplicationUser", null)
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MyClothesCA.Domain.Entities.ApplicationUser", null)
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyClothesCA.Domain.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MyClothesCA.Domain.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyClothesCA.Domain.Entities.Garment", b =>
                {
                    b.HasOne("MyClothesCA.Domain.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany("UserClothesCollection")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("MyClothesCA.Domain.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("MyClothesCA.Domain.Entities.Colour", "Colour")
                        .WithMany()
                        .HasForeignKey("ColourId");

                    b.HasOne("MyClothesCA.Domain.Entities.Season", "Season")
                        .WithMany()
                        .HasForeignKey("SeasonId");

                    b.Navigation("ApplicationUser");

                    b.Navigation("Category");

                    b.Navigation("Colour");

                    b.Navigation("Season");
                });

            modelBuilder.Entity("MyClothesCA.Domain.Entities.Image", b =>
                {
                    b.HasOne("MyClothesCA.Domain.Entities.ApplicationUser", "AddedByApplicationUser")
                        .WithMany()
                        .HasForeignKey("AddedByApplicationUserId");

                    b.Navigation("AddedByApplicationUser");
                });

            modelBuilder.Entity("MyClothesCA.Domain.Entities.UserCategory", b =>
                {
                    b.HasOne("MyClothesCA.Domain.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany("UserCategoriesList")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyClothesCA.Domain.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("MyClothesCA.Domain.Entities.UserClothes", b =>
                {
                    b.HasOne("MyClothesCA.Domain.Entities.ApplicationUser", null)
                        .WithMany("Clothes")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyClothesCA.Domain.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId1");

                    b.HasOne("MyClothesCA.Domain.Entities.Garment", "Garment")
                        .WithMany()
                        .HasForeignKey("GarmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");

                    b.Navigation("Garment");
                });

            modelBuilder.Entity("MyClothesCA.Domain.Entities.ApplicationUser", b =>
                {
                    b.Navigation("Claims");

                    b.Navigation("Clothes");

                    b.Navigation("Logins");

                    b.Navigation("UserCategoriesList");

                    b.Navigation("UserClothesCollection");
                });
#pragma warning restore 612, 618
        }
    }
}
