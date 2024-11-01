﻿// <auto-generated />
using System;
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(HmsDBContext))]
    partial class HmsDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BusinessObjects.BookingDetail", b =>
                {
                    b.Property<int>("BookingReservationID")
                        .HasColumnType("int");

                    b.Property<int>("RoomID")
                        .HasColumnType("int");

                    b.Property<decimal>("ActualPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateOnly>("EndDate")
                        .HasColumnType("date");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date");

                    b.HasKey("BookingReservationID", "RoomID");

                    b.HasIndex("RoomID");

                    b.ToTable("BookingDetails");

                    b.HasData(
                        new
                        {
                            BookingReservationID = 1,
                            RoomID = 3,
                            ActualPrice = 199.00m,
                            EndDate = new DateOnly(2024, 1, 2),
                            StartDate = new DateOnly(2024, 1, 1)
                        },
                        new
                        {
                            BookingReservationID = 1,
                            RoomID = 7,
                            ActualPrice = 179.00m,
                            EndDate = new DateOnly(2024, 1, 2),
                            StartDate = new DateOnly(2024, 1, 1)
                        },
                        new
                        {
                            BookingReservationID = 2,
                            RoomID = 3,
                            ActualPrice = 199.00m,
                            EndDate = new DateOnly(2024, 1, 6),
                            StartDate = new DateOnly(2024, 1, 5)
                        },
                        new
                        {
                            BookingReservationID = 2,
                            RoomID = 5,
                            ActualPrice = 219.00m,
                            EndDate = new DateOnly(2024, 1, 9),
                            StartDate = new DateOnly(2024, 1, 5)
                        });
                });

            modelBuilder.Entity("BusinessObjects.BookingReservation", b =>
                {
                    b.Property<int>("BookingReservationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingReservationID"));

                    b.Property<DateOnly>("BookingDate")
                        .HasColumnType("date");

                    b.Property<int?>("BookingStatus")
                        .HasColumnType("int");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("BookingReservationID");

                    b.HasIndex("CustomerID");

                    b.ToTable("BookingReservations");

                    b.HasData(
                        new
                        {
                            BookingReservationID = 1,
                            BookingDate = new DateOnly(2023, 12, 20),
                            BookingStatus = 1,
                            CustomerID = 3,
                            TotalPrice = 378.00m
                        },
                        new
                        {
                            BookingReservationID = 2,
                            BookingDate = new DateOnly(2023, 12, 21),
                            BookingStatus = 1,
                            CustomerID = 3,
                            TotalPrice = 1493.00m
                        });
                });

            modelBuilder.Entity("BusinessObjects.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerID"));

                    b.Property<DateOnly?>("CustomerBirthday")
                        .HasColumnType("date");

                    b.Property<string>("CustomerFullName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("CustomerStatus")
                        .HasColumnType("int");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Telephone")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerID = 3,
                            CustomerBirthday = new DateOnly(1990, 2, 2),
                            CustomerFullName = "William Shakespeare",
                            CustomerStatus = 1,
                            EmailAddress = "WilliamShakespeare@FUMiniHotel.org",
                            Password = "123@",
                            Telephone = "0903939393"
                        },
                        new
                        {
                            CustomerID = 5,
                            CustomerBirthday = new DateOnly(1991, 3, 3),
                            CustomerFullName = "Elizabeth Taylor",
                            CustomerStatus = 1,
                            EmailAddress = "ElizabethTaylor@FUMiniHotel.org",
                            Password = "144@",
                            Telephone = "0903939377"
                        },
                        new
                        {
                            CustomerID = 8,
                            CustomerBirthday = new DateOnly(1992, 11, 10),
                            CustomerFullName = "James Cameron",
                            CustomerStatus = 1,
                            EmailAddress = "JamesCameron@FUMiniHotel.org",
                            Password = "443@",
                            Telephone = "0903946582"
                        },
                        new
                        {
                            CustomerID = 9,
                            CustomerBirthday = new DateOnly(1991, 12, 5),
                            CustomerFullName = "Charles Dickens",
                            CustomerStatus = 1,
                            EmailAddress = "CharlesDickens@FUMiniHotel.org",
                            Password = "563@",
                            Telephone = "0903955633"
                        },
                        new
                        {
                            CustomerID = 10,
                            CustomerBirthday = new DateOnly(1993, 12, 24),
                            CustomerFullName = "George Orwell",
                            CustomerStatus = 1,
                            EmailAddress = "GeorgeOrwell@FUMiniHotel.org",
                            Password = "177@",
                            Telephone = "0913933493"
                        },
                        new
                        {
                            CustomerID = 11,
                            CustomerBirthday = new DateOnly(1990, 9, 9),
                            CustomerFullName = "Victoria Beckham",
                            CustomerStatus = 1,
                            EmailAddress = "VictoriaBeckham@FUMiniHotel.org",
                            Password = "654@",
                            Telephone = "0983246773"
                        });
                });

            modelBuilder.Entity("BusinessObjects.RoomInformation", b =>
                {
                    b.Property<int>("RoomID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomID"));

                    b.Property<string>("RoomDetailDescription")
                        .HasMaxLength(220)
                        .HasColumnType("nvarchar(220)");

                    b.Property<int?>("RoomMaxCapacity")
                        .HasColumnType("int");

                    b.Property<string>("RoomNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal?>("RoomPricePerDate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("RoomStatus")
                        .HasColumnType("int");

                    b.Property<int>("RoomTypeID")
                        .HasColumnType("int");

                    b.HasKey("RoomID");

                    b.HasIndex("RoomTypeID");

                    b.ToTable("RoomInformations");

                    b.HasData(
                        new
                        {
                            RoomID = 1,
                            RoomDetailDescription = "A basic room with essential amenities.",
                            RoomMaxCapacity = 3,
                            RoomNumber = "2364",
                            RoomPricePerDate = 149.00m,
                            RoomStatus = 1,
                            RoomTypeID = 1
                        },
                        new
                        {
                            RoomID = 2,
                            RoomDetailDescription = "Deluxe room with additional features.",
                            RoomMaxCapacity = 5,
                            RoomNumber = "3345",
                            RoomPricePerDate = 299.00m,
                            RoomStatus = 1,
                            RoomTypeID = 3
                        },
                        new
                        {
                            RoomID = 3,
                            RoomDetailDescription = "Luxurious room with separate living and sleeping areas.",
                            RoomMaxCapacity = 4,
                            RoomNumber = "4432",
                            RoomPricePerDate = 199.00m,
                            RoomStatus = 1,
                            RoomTypeID = 2
                        },
                        new
                        {
                            RoomID = 5,
                            RoomDetailDescription = "Floor 3, North West window.",
                            RoomMaxCapacity = 5,
                            RoomNumber = "3342",
                            RoomPricePerDate = 219.00m,
                            RoomStatus = 1,
                            RoomTypeID = 5
                        },
                        new
                        {
                            RoomID = 7,
                            RoomDetailDescription = "Floor 4, South window.",
                            RoomMaxCapacity = 4,
                            RoomNumber = "4434",
                            RoomPricePerDate = 179.00m,
                            RoomStatus = 1,
                            RoomTypeID = 1
                        });
                });

            modelBuilder.Entity("BusinessObjects.RoomType", b =>
                {
                    b.Property<int>("RoomTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomTypeID"));

                    b.Property<string>("RoomTypeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TypeDescription")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("TypeNote")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("RoomTypeID");

                    b.ToTable("RoomTypes");

                    b.HasData(
                        new
                        {
                            RoomTypeID = 1,
                            RoomTypeName = "Standard room",
                            TypeDescription = "Basic amenities such as a bed, dresser, and TV.",
                            TypeNote = "N/A"
                        },
                        new
                        {
                            RoomTypeID = 2,
                            RoomTypeName = "Suite",
                            TypeDescription = "Offers more space and amenities like a living area and kitchenette.",
                            TypeNote = "N/A"
                        },
                        new
                        {
                            RoomTypeID = 3,
                            RoomTypeName = "Deluxe room",
                            TypeDescription = "Deluxe rooms with additional features like balcony or sea view.",
                            TypeNote = "N/A"
                        },
                        new
                        {
                            RoomTypeID = 4,
                            RoomTypeName = "Executive room",
                            TypeDescription = "Designed for business travelers with perks like free breakfast.",
                            TypeNote = "N/A"
                        },
                        new
                        {
                            RoomTypeID = 5,
                            RoomTypeName = "Family Room",
                            TypeDescription = "Specifically designed for families with multiple beds and additional space.",
                            TypeNote = "N/A"
                        },
                        new
                        {
                            RoomTypeID = 6,
                            RoomTypeName = "Connecting Room",
                            TypeDescription = "Rooms with a connecting door for larger groups or families.",
                            TypeNote = "N/A"
                        },
                        new
                        {
                            RoomTypeID = 7,
                            RoomTypeName = "Penthouse Suite",
                            TypeDescription = "An extravagant suite with exceptional views and exclusive amenities.",
                            TypeNote = "N/A"
                        },
                        new
                        {
                            RoomTypeID = 8,
                            RoomTypeName = "Bungalow",
                            TypeDescription = "Standalone cottage-style accommodation for privacy.",
                            TypeNote = "N/A"
                        });
                });

            modelBuilder.Entity("BusinessObjects.BookingDetail", b =>
                {
                    b.HasOne("BusinessObjects.BookingReservation", "BookingReservation")
                        .WithMany("BookingDetails")
                        .HasForeignKey("BookingReservationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusinessObjects.RoomInformation", "RoomInformation")
                        .WithMany("BookingDetails")
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("BookingReservation");

                    b.Navigation("RoomInformation");
                });

            modelBuilder.Entity("BusinessObjects.BookingReservation", b =>
                {
                    b.HasOne("BusinessObjects.Customer", "Customer")
                        .WithMany("BookingReservations")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("BusinessObjects.RoomInformation", b =>
                {
                    b.HasOne("BusinessObjects.RoomType", "RoomType")
                        .WithMany("Rooms")
                        .HasForeignKey("RoomTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RoomType");
                });

            modelBuilder.Entity("BusinessObjects.BookingReservation", b =>
                {
                    b.Navigation("BookingDetails");
                });

            modelBuilder.Entity("BusinessObjects.Customer", b =>
                {
                    b.Navigation("BookingReservations");
                });

            modelBuilder.Entity("BusinessObjects.RoomInformation", b =>
                {
                    b.Navigation("BookingDetails");
                });

            modelBuilder.Entity("BusinessObjects.RoomType", b =>
                {
                    b.Navigation("Rooms");
                });
#pragma warning restore 612, 618
        }
    }
}
