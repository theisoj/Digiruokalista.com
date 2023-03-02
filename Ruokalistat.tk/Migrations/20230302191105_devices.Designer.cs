﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Ruokalistat.tk.Models;

#nullable disable

namespace Digiruokalista.com.Migrations
{
    [DbContext(typeof(tietokantaContext))]
    [Migration("20230302191105_devices")]
    partial class devices
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Digiruokalista.com.Models.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("PushAuth")
                        .HasColumnType("longtext");

                    b.Property<string>("PushEndpoint")
                        .HasColumnType("longtext");

                    b.Property<string>("PushP256DH")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Laitteet");
                });

            modelBuilder.Entity("Digiruokalista.com.Models.Hintahistoria", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("Hinta")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("PVM")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("RuokaID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("RuokaID");

                    b.ToTable("Hintahistoria");
                });

            modelBuilder.Entity("Digiruokalista.com.Models.RuokaTykkays", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("IP")
                        .HasColumnType("longtext");

                    b.Property<int?>("RuokaIdID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RuokaIdID");

                    b.ToTable("RuokaTykkaykset");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Ruokalistat.tk.Models.Arvostelu", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("source")
                        .HasColumnType("longtext");

                    b.Property<int?>("yritysID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("yritysID");

                    b.ToTable("Arvostelu");
                });

            modelBuilder.Entity("Ruokalistat.tk.Models.Kategoria", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Kuvaus")
                        .HasColumnType("longtext");

                    b.Property<string>("Nimi")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("RuokalistaID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("RuokalistaID");

                    b.ToTable("Kategoria");
                });

            modelBuilder.Entity("Ruokalistat.tk.Models.Ruoka", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Annos")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("AnnosNumero")
                        .HasColumnType("int");

                    b.Property<decimal>("Hinta")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("KategoriaID")
                        .HasColumnType("int");

                    b.Property<string>("Kuvaus")
                        .HasColumnType("longtext");

                    b.Property<string>("Nimi")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Vegan")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("ID");

                    b.HasIndex("KategoriaID");

                    b.ToTable("Ruoka");
                });

            modelBuilder.Entity("Ruokalistat.tk.Models.Ruokalista", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("piilotettu")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("viimeksiPaivitetty")
                        .HasColumnType("datetime(6)");

                    b.HasKey("ID");

                    b.ToTable("Ruokalista");
                });

            modelBuilder.Entity("Ruokalistat.tk.Models.Yritys", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Kaupunki")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nimi")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Osoite")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Owner")
                        .HasColumnType("longtext");

                    b.Property<string>("Postinumero")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Puhelin")
                        .HasColumnType("longtext");

                    b.Property<int?>("RuokalistaID")
                        .HasColumnType("int");

                    b.Property<string>("VapaaTeksti")
                        .HasColumnType("longtext");

                    b.Property<string>("yTunnus")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.HasIndex("RuokalistaID");

                    b.ToTable("Yritys");
                });

            modelBuilder.Entity("Digiruokalista.com.Models.Hintahistoria", b =>
                {
                    b.HasOne("Ruokalistat.tk.Models.Ruoka", "Ruoka")
                        .WithMany()
                        .HasForeignKey("RuokaID");

                    b.Navigation("Ruoka");
                });

            modelBuilder.Entity("Digiruokalista.com.Models.RuokaTykkays", b =>
                {
                    b.HasOne("Ruokalistat.tk.Models.Ruoka", "RuokaId")
                        .WithMany("Tykkaykset")
                        .HasForeignKey("RuokaIdID");

                    b.Navigation("RuokaId");
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

            modelBuilder.Entity("Ruokalistat.tk.Models.Arvostelu", b =>
                {
                    b.HasOne("Ruokalistat.tk.Models.Yritys", "yritys")
                        .WithMany("Arvostelut")
                        .HasForeignKey("yritysID");

                    b.Navigation("yritys");
                });

            modelBuilder.Entity("Ruokalistat.tk.Models.Kategoria", b =>
                {
                    b.HasOne("Ruokalistat.tk.Models.Ruokalista", null)
                        .WithMany("Kategoriat")
                        .HasForeignKey("RuokalistaID");
                });

            modelBuilder.Entity("Ruokalistat.tk.Models.Ruoka", b =>
                {
                    b.HasOne("Ruokalistat.tk.Models.Kategoria", null)
                        .WithMany("Ruuat")
                        .HasForeignKey("KategoriaID");
                });

            modelBuilder.Entity("Ruokalistat.tk.Models.Yritys", b =>
                {
                    b.HasOne("Ruokalistat.tk.Models.Ruokalista", "Ruokalista")
                        .WithMany()
                        .HasForeignKey("RuokalistaID");

                    b.Navigation("Ruokalista");
                });

            modelBuilder.Entity("Ruokalistat.tk.Models.Kategoria", b =>
                {
                    b.Navigation("Ruuat");
                });

            modelBuilder.Entity("Ruokalistat.tk.Models.Ruoka", b =>
                {
                    b.Navigation("Tykkaykset");
                });

            modelBuilder.Entity("Ruokalistat.tk.Models.Ruokalista", b =>
                {
                    b.Navigation("Kategoriat");
                });

            modelBuilder.Entity("Ruokalistat.tk.Models.Yritys", b =>
                {
                    b.Navigation("Arvostelut");
                });
#pragma warning restore 612, 618
        }
    }
}
