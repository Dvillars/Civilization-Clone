using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Civilized.Models;

namespace Civilized.Migrations
{
    [DbContext(typeof(CivDbContext))]
    [Migration("20170503203315_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Civilized.Models.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AssignedUserIdId");

                    b.Property<int?>("HasPlayerIdPlayerId");

                    b.HasKey("AccountId");

                    b.HasIndex("AssignedUserIdId");

                    b.HasIndex("HasPlayerIdPlayerId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Civilized.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Civilized.Models.Civilization", b =>
                {
                    b.Property<int>("CivilizationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Con");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("Pro");

                    b.HasKey("CivilizationId");

                    b.ToTable("Civilizations");
                });

            modelBuilder.Entity("Civilized.Models.Economy", b =>
                {
                    b.Property<int>("EconomyId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Con");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("Pro");

                    b.HasKey("EconomyId");

                    b.ToTable("Economies");
                });

            modelBuilder.Entity("Civilized.Models.Geography", b =>
                {
                    b.Property<int>("GeographyId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Con");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("Pro");

                    b.HasKey("GeographyId");

                    b.ToTable("Geographies");
                });

            modelBuilder.Entity("Civilized.Models.Government", b =>
                {
                    b.Property<int>("GovId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Con");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("Pro");

                    b.HasKey("GovId");

                    b.ToTable("Governments");
                });

            modelBuilder.Entity("Civilized.Models.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CivilizationId");

                    b.Property<int?>("EconomyId");

                    b.Property<int?>("GeographyId");

                    b.Property<int?>("GovernmentGovId");

                    b.Property<string>("Name");

                    b.HasKey("PlayerId");

                    b.HasIndex("CivilizationId");

                    b.HasIndex("EconomyId");

                    b.HasIndex("GeographyId");

                    b.HasIndex("GovernmentGovId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Civilized.Models.Account", b =>
                {
                    b.HasOne("Civilized.Models.ApplicationUser", "AssignedUserId")
                        .WithMany()
                        .HasForeignKey("AssignedUserIdId");

                    b.HasOne("Civilized.Models.Player", "HasPlayerId")
                        .WithMany()
                        .HasForeignKey("HasPlayerIdPlayerId");
                });

            modelBuilder.Entity("Civilized.Models.Player", b =>
                {
                    b.HasOne("Civilized.Models.Civilization", "Civilization")
                        .WithMany()
                        .HasForeignKey("CivilizationId");

                    b.HasOne("Civilized.Models.Economy", "Economy")
                        .WithMany()
                        .HasForeignKey("EconomyId");

                    b.HasOne("Civilized.Models.Geography", "Geography")
                        .WithMany()
                        .HasForeignKey("GeographyId");

                    b.HasOne("Civilized.Models.Government", "Government")
                        .WithMany()
                        .HasForeignKey("GovernmentGovId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Civilized.Models.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Civilized.Models.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Civilized.Models.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
