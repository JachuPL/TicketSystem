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
    [Migration("20190629160927_user_fields")]
    partial class user_fields
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

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Login");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PasswordSalt");

                    b.Property<string>("Phone");

                    b.Property<int>("Role");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c744871e-8e30-4bef-b0df-9a0bee8b01b9"),
                            Login = "admin",
                            PasswordHash = "wQ6cDrcWiFS6LNZ3ieG6DYR9zthofrRs9a6rzxYFXnyu4cFka+a4Ag==",
                            PasswordSalt = "QN0ZGBESjAY0KkcxouwcuhUa9bbfQd4cV+HCw4xwoULAh4jUqnuUxw==",
                            Role = 2
                        },
                        new
                        {
                            Id = new Guid("24e026ad-e069-4ab7-8003-f623a3a3d146"),
                            Login = "cashier",
                            PasswordHash = "aSGUzrjSGaN8vWa8nq0bAIfWfu/ZX6hqyRLepNdjG1RrM3xobM9p/g==",
                            PasswordSalt = "NuU5eKt6sxp5pLUwGOu5HPMChEwXnDNG51lQJd6x8lFGkEFI9tiYJQ==",
                            Role = 1
                        },
                        new
                        {
                            Id = new Guid("8d4b7ed2-a241-4744-b776-da80cae8e0a9"),
                            Login = "user",
                            PasswordHash = "TI/o5T3zrn9XaKkx29WtG27aNRIFd62mhiMiZq2RsglSj8Xr5bpVww==",
                            PasswordSalt = "KspogfYOBAo0/tXk8poWuihixt2J/9BwJZzfB+NtN1ZT54OHW6VfSA==",
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
