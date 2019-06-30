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
    [Migration("20190629153059_refactored_domain_v2")]
    partial class refactored_domain_v2
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

                    b.Property<bool>("IsPaid");

                    b.Property<Guid>("ShowId");

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

                    b.Property<Guid>("ReservationId");

                    b.Property<int>("Row");

                    b.Property<int>("Seat");

                    b.Property<int>("Ticket");

                    b.HasKey("Id");

                    b.HasIndex("ReservationId");

                    b.ToTable("ReservedSeats");
                });

            modelBuilder.Entity("TicketReservation.Domain.Show", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CinemaId");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("MovieId");

                    b.Property<string>("PriceList");

                    b.HasKey("Id");

                    b.HasIndex("CinemaId");

                    b.HasIndex("MovieId");

                    b.ToTable("Shows");
                });

            modelBuilder.Entity("TicketReservation.Domain.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Login");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PasswordSalt");

                    b.Property<int>("Role");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c5bc32ae-ffe5-443d-849f-9c796f93299c"),
                            Login = "admin",
                            PasswordHash = "UOhOvyRhsQODsg5zHK2Fg7HyiFPfuHMVxfH+Q3cCusJeWveOwptGTw==",
                            PasswordSalt = "NjatPUsN7fWNrA5TcOh6qXo7JdqaDoaEKESC0R/Qq+BmMf6tbO+cdg==",
                            Role = 0
                        },
                        new
                        {
                            Id = new Guid("7761459d-f3ae-4af0-996f-4b84bea3b71a"),
                            Login = "cashier",
                            PasswordHash = "6pVcohC92nsfbqZbM8//OerciQB6TbrOyDnTRzjVZYxz6PCXDGGDaw==",
                            PasswordSalt = "fz5oNiRK56a5cx27G0dA3FHnT+oqjjWooEWJlXQXiFUGx7VCZQEg9g==",
                            Role = 0
                        },
                        new
                        {
                            Id = new Guid("02a05980-7a56-41e9-800e-6bc7f2eca063"),
                            Login = "user",
                            PasswordHash = "lRspeYpetNTf8bRqh2RgIXlR9XGUv9wGwlGtxVuVA0uBySKdg1YpIQ==",
                            PasswordSalt = "CWDnbhLbmyoErCqKPqCWTL/7MNqM5EhVa4s3o15RqXAJzD9GwxxEBg==",
                            Role = 0
                        });
                });

            modelBuilder.Entity("TicketReservation.Domain.Reservation", b =>
                {
                    b.HasOne("TicketReservation.Domain.Show")
                        .WithMany("Reservations")
                        .HasForeignKey("ShowId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TicketReservation.Domain.ReservedSeat", b =>
                {
                    b.HasOne("TicketReservation.Domain.Reservation")
                        .WithMany("ReservedSeats")
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TicketReservation.Domain.Show", b =>
                {
                    b.HasOne("TicketReservation.Domain.Cinema", "Cinema")
                        .WithMany("Shows")
                        .HasForeignKey("CinemaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TicketReservation.Domain.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
