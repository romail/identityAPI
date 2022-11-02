﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Takoha.Infrastructure.Data;

#nullable disable

namespace Takoha.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Takoha.Core.BookingAggregate.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("Takoha.Core.BookingAggregate.BookingTimeSlot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("BookingId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDone")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("LaneAvailablePeriodId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookingId");

                    b.HasIndex("LaneAvailablePeriodId");

                    b.ToTable("BookingTimeSlot");
                });

            modelBuilder.Entity("Takoha.Core.BookingAggregate.Duration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("WeekDay")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Duration");
                });

            modelBuilder.Entity("Takoha.Core.BookingAggregate.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BookingId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("BookingId");

                    b.ToTable("Transaction");
                });

            modelBuilder.Entity("Takoha.Core.LaneAggregate.LaneAvailablePeriod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DurationId")
                        .HasColumnType("int");

                    b.Property<bool>("IsBooked")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("LaneId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DurationId");

                    b.HasIndex("LaneId");

                    b.ToTable("LaneAvailablePeriods");
                });

            modelBuilder.Entity("Takoha.Core.TaxeAggregate.Taxe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("TaxAmount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("TaxeStateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TaxeStateId");

                    b.ToTable("Taxe");
                });

            modelBuilder.Entity("Takoha.Core.TaxeAggregate.TaxeState", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("TaxeState");
                });

            modelBuilder.Entity("Takoha.Core.UserAggregate.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("UserProfileId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserProfileId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Takoha.Core.UserAggregate.UserProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("UserProfile");
                });

            modelBuilder.Entity("Takoha.Core.VanueAggregate.Lane", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("LaneNumber")
                        .HasColumnType("int");

                    b.Property<int>("VanueId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VanueId");

                    b.ToTable("Lane");
                });

            modelBuilder.Entity("Takoha.Core.VanueAggregate.Vanue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Vanue");
                });

            modelBuilder.Entity("Takoha.Core.BookingAggregate.Booking", b =>
                {
                    b.HasOne("Takoha.Core.UserAggregate.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Takoha.Core.BookingAggregate.BookingTimeSlot", b =>
                {
                    b.HasOne("Takoha.Core.BookingAggregate.Booking", "Booking")
                        .WithMany("Items")
                        .HasForeignKey("BookingId");

                    b.HasOne("Takoha.Core.LaneAggregate.LaneAvailablePeriod", "LaneAvailablePeriod")
                        .WithMany()
                        .HasForeignKey("LaneAvailablePeriodId");

                    b.Navigation("Booking");

                    b.Navigation("LaneAvailablePeriod");
                });

            modelBuilder.Entity("Takoha.Core.BookingAggregate.Transaction", b =>
                {
                    b.HasOne("Takoha.Core.BookingAggregate.Booking", "Booking")
                        .WithMany("ItemsTransaction")
                        .HasForeignKey("BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");
                });

            modelBuilder.Entity("Takoha.Core.LaneAggregate.LaneAvailablePeriod", b =>
                {
                    b.HasOne("Takoha.Core.BookingAggregate.Duration", "Duration")
                        .WithMany()
                        .HasForeignKey("DurationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Takoha.Core.VanueAggregate.Lane", "Lane")
                        .WithMany("Items")
                        .HasForeignKey("LaneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Duration");

                    b.Navigation("Lane");
                });

            modelBuilder.Entity("Takoha.Core.TaxeAggregate.Taxe", b =>
                {
                    b.HasOne("Takoha.Core.TaxeAggregate.TaxeState", "TaxeState")
                        .WithMany()
                        .HasForeignKey("TaxeStateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TaxeState");
                });

            modelBuilder.Entity("Takoha.Core.UserAggregate.User", b =>
                {
                    b.HasOne("Takoha.Core.UserAggregate.UserProfile", "UserProfile")
                        .WithMany()
                        .HasForeignKey("UserProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserProfile");
                });

            modelBuilder.Entity("Takoha.Core.VanueAggregate.Lane", b =>
                {
                    b.HasOne("Takoha.Core.VanueAggregate.Vanue", "Vanue")
                        .WithMany("Items")
                        .HasForeignKey("VanueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vanue");
                });

            modelBuilder.Entity("Takoha.Core.BookingAggregate.Booking", b =>
                {
                    b.Navigation("Items");

                    b.Navigation("ItemsTransaction");
                });

            modelBuilder.Entity("Takoha.Core.VanueAggregate.Lane", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("Takoha.Core.VanueAggregate.Vanue", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
