﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TicketReservation.Application.Common.Database;

namespace TicketReservation.Application.Common.Database.Migrations
{
    [DbContext(typeof(TicketReservationContext))]
    [Migration("20190628190355_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TicketReservation.Domain.Cinema", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Cinemas");
                });

            modelBuilder.Entity("TicketReservation.Domain.CinemaMovie", b =>
                {
                    b.Property<Guid>("CinemaId");

                    b.Property<Guid>("MovieId");

                    b.HasKey("CinemaId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("CinemaMovies");
                });

            modelBuilder.Entity("TicketReservation.Domain.Identity.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("663e301f-b5e0-44d1-8165-0a0b3f256b17"),
                            ConcurrencyStamp = "bcfd0d9d-b89b-41fe-abbb-75f3c83b70a5",
                            Name = "Administrator"
                        },
                        new
                        {
                            Id = new Guid("9b742753-2888-4327-a978-10b84a10ba6a"),
                            ConcurrencyStamp = "c25f547d-3d5d-4258-b20f-a11b053a2a84",
                            Name = "Cashier"
                        },
                        new
                        {
                            Id = new Guid("1a40654f-0d9e-4120-8255-415fbb229e48"),
                            ConcurrencyStamp = "ca099b34-88ff-42d8-a5ec-77b21e3e8b9f",
                            Name = "Customer"
                        });
                });

            modelBuilder.Entity("TicketReservation.Domain.Identity.RoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("TicketReservation.Domain.Identity.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TicketReservation.Domain.Identity.UserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("TicketReservation.Domain.Identity.UserLogin", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<Guid>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("TicketReservation.Domain.Identity.UserRole", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<Guid>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("TicketReservation.Domain.Identity.UserToken", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("TicketReservation.Domain.Movie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("TicketReservation.Domain.Reservation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("ShowId");

                    b.Property<string>("UserEmail")
                        .HasMaxLength(100);

                    b.Property<string>("UserFirstName")
                        .HasMaxLength(100);

                    b.Property<string>("UserLastName")
                        .HasMaxLength(100);

                    b.Property<string>("UserPhone")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("ShowId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("TicketReservation.Domain.ReservedSeat", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Column");

                    b.Property<bool>("IsPaid");

                    b.Property<Guid?>("ReservationId");

                    b.Property<int>("Row");

                    b.Property<int>("Ticket");

                    b.HasKey("Id");

                    b.HasIndex("ReservationId");

                    b.ToTable("ReservedSeats");
                });

            modelBuilder.Entity("TicketReservation.Domain.Show", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("CinemaId");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("MovieId");

                    b.Property<string>("PriceList");

                    b.HasKey("Id");

                    b.HasIndex("CinemaId");

                    b.HasIndex("MovieId");

                    b.ToTable("Shows");
                });

            modelBuilder.Entity("TicketReservation.Domain.CinemaMovie", b =>
                {
                    b.HasOne("TicketReservation.Domain.Cinema", "Cinema")
                        .WithMany("Movies")
                        .HasForeignKey("CinemaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TicketReservation.Domain.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TicketReservation.Domain.Identity.RoleClaim", b =>
                {
                    b.HasOne("TicketReservation.Domain.Identity.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TicketReservation.Domain.Identity.UserClaim", b =>
                {
                    b.HasOne("TicketReservation.Domain.Identity.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TicketReservation.Domain.Identity.UserLogin", b =>
                {
                    b.HasOne("TicketReservation.Domain.Identity.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TicketReservation.Domain.Identity.UserRole", b =>
                {
                    b.HasOne("TicketReservation.Domain.Identity.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TicketReservation.Domain.Identity.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TicketReservation.Domain.Identity.UserToken", b =>
                {
                    b.HasOne("TicketReservation.Domain.Identity.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TicketReservation.Domain.Reservation", b =>
                {
                    b.HasOne("TicketReservation.Domain.Show")
                        .WithMany("Reservations")
                        .HasForeignKey("ShowId");
                });

            modelBuilder.Entity("TicketReservation.Domain.ReservedSeat", b =>
                {
                    b.HasOne("TicketReservation.Domain.Reservation")
                        .WithMany("ReservedSeats")
                        .HasForeignKey("ReservationId");
                });

            modelBuilder.Entity("TicketReservation.Domain.Show", b =>
                {
                    b.HasOne("TicketReservation.Domain.Cinema", "Cinema")
                        .WithMany()
                        .HasForeignKey("CinemaId");

                    b.HasOne("TicketReservation.Domain.Movie", "Movie")
                        .WithMany("Shows")
                        .HasForeignKey("MovieId");
                });
#pragma warning restore 612, 618
        }
    }
}
