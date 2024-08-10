﻿// <auto-generated />
using System;
using BookingSystem.DatabaseAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookingSystem.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookingSystem.Models.AvailabilityModel", b =>
                {
                    b.Property<string>("AvailabilityId")
                        .HasColumnType("nvarchar(36)")
                        .HasColumnName("AvailabilityId");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedAt");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2")
                        .HasColumnName("Date");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time")
                        .HasColumnName("EndTime");

                    b.Property<string>("SalonSpaId")
                        .IsRequired()
                        .HasColumnType("nvarchar(36)")
                        .HasColumnName("SalonSpaId");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time")
                        .HasColumnName("StartTime");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedAt");

                    b.HasKey("AvailabilityId");

                    b.HasIndex("SalonSpaId");

                    b.ToTable("Availabilities");
                });

            modelBuilder.Entity("BookingSystem.Models.BookingModel", b =>
                {
                    b.Property<string>("BookingId")
                        .HasColumnType("nvarchar(36)")
                        .HasColumnName("BookingId");

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("BookingDate");

                    b.Property<TimeSpan>("BookingTime")
                        .HasColumnType("time")
                        .HasColumnName("BookingTime");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedAt");

                    b.Property<string>("SalonSpaId")
                        .IsRequired()
                        .HasColumnType("nvarchar(36)")
                        .HasColumnName("SalonSpaId");

                    b.Property<string>("ServiceId")
                        .IsRequired()
                        .HasColumnType("nvarchar(36)")
                        .HasColumnName("ServiceId");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Status");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("TotalPrice");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedAt");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(36)")
                        .HasColumnName("UserId");

                    b.HasKey("BookingId");

                    b.HasIndex("SalonSpaId");

                    b.HasIndex("ServiceId");

                    b.HasIndex("UserId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("BookingSystem.Models.NotificationModel", b =>
                {
                    b.Property<string>("NotificationId")
                        .HasColumnType("nvarchar(36)")
                        .HasColumnName("NotificationId");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedAt");

                    b.Property<bool>("IsRead")
                        .HasColumnType("bit")
                        .HasColumnName("IsRead");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("Message");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(36)")
                        .HasColumnName("UserId");

                    b.HasKey("NotificationId");

                    b.HasIndex("UserId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("BookingSystem.Models.PaymentModel", b =>
                {
                    b.Property<string>("PaymentId")
                        .HasColumnType("nvarchar(36)")
                        .HasColumnName("PaymentId");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Amount");

                    b.Property<string>("BookingId")
                        .IsRequired()
                        .HasColumnType("nvarchar(36)")
                        .HasColumnName("BookingId");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedAt");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("PaymentDate");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("PaymentMethod");

                    b.Property<string>("PaymentStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(36)")
                        .HasColumnName("PaymentStatus");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedAt");

                    b.HasKey("PaymentId");

                    b.HasIndex("BookingId")
                        .IsUnique();

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("BookingSystem.Models.ReviewModel", b =>
                {
                    b.Property<string>("ReviewId")
                        .HasColumnType("nvarchar(36)")
                        .HasColumnName("ReviewId");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("Comment");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedAt");

                    b.Property<int>("Rating")
                        .HasColumnType("int")
                        .HasColumnName("Rating");

                    b.Property<string>("SalonSpaId")
                        .IsRequired()
                        .HasColumnType("nvarchar(36)")
                        .HasColumnName("SalonSpaId");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedAt");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(36)")
                        .HasColumnName("UserId");

                    b.HasKey("ReviewId");

                    b.HasIndex("SalonSpaId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("BookingSystem.Models.SalonSpaModel", b =>
                {
                    b.Property<string>("SalonSpaId")
                        .HasColumnType("nvarchar(36)")
                        .HasColumnName("SalonSpaId");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(300)")
                        .HasColumnName("Address");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("City");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Country");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedAt");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("Description");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("Email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Name");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("PhoneNumber");

                    b.Property<string>("SalonOwnerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(36)")
                        .HasColumnName("SalonOwnerId");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("State");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedAt");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("ZipCode");

                    b.HasKey("SalonSpaId");

                    b.HasIndex("SalonOwnerId");

                    b.ToTable("SalonSpas");
                });

            modelBuilder.Entity("BookingSystem.Models.ServiceModel", b =>
                {
                    b.Property<string>("ServiceId")
                        .HasColumnType("nvarchar(36)")
                        .HasColumnName("ServiceId");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedAt");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("Description");

                    b.Property<int>("Duration")
                        .HasColumnType("int")
                        .HasColumnName("Duration");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)")
                        .HasColumnName("Price");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedAt");

                    b.HasKey("ServiceId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("BookingSystem.Models.ServiceSalonSpaModel", b =>
                {
                    b.Property<string>("ServiceSalonSpaId")
                        .HasColumnType("nvarchar(36)")
                        .HasColumnName("ServiceSalonSpaId");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedAt");

                    b.Property<string>("SalonSpaId")
                        .IsRequired()
                        .HasColumnType("nvarchar(36)")
                        .HasColumnName("SalonSpaId");

                    b.Property<string>("ServiceId")
                        .IsRequired()
                        .HasColumnType("nvarchar(36)")
                        .HasColumnName("ServiceId");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedAt");

                    b.HasKey("ServiceSalonSpaId");

                    b.HasIndex("SalonSpaId");

                    b.HasIndex("ServiceId");

                    b.ToTable("ServiceSalonSpas");
                });

            modelBuilder.Entity("BookingSystem.Models.UserModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(36)")
                        .HasColumnName("UserId");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedAt");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("FirstName");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("LastName");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varchar(300)")
                        .HasColumnName("PasswordHash");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("PhoneNumber");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Role");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BookingSystem.Models.UserProfileModel", b =>
                {
                    b.Property<string>("UserProfileId")
                        .HasColumnType("nvarchar(36)")
                        .HasColumnName("UserProfileId");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(300)")
                        .HasColumnName("Address");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("City");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Country");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProfilePictureUrl")
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("ProfilePictureUrl");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("State");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(36)")
                        .HasColumnName("UserId");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("ZipCode");

                    b.HasKey("UserProfileId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserProfiles");
                });

            modelBuilder.Entity("BookingSystem.Models.AvailabilityModel", b =>
                {
                    b.HasOne("BookingSystem.Models.SalonSpaModel", "SalonSpa")
                        .WithMany("Availabilities")
                        .HasForeignKey("SalonSpaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SalonSpa");
                });

            modelBuilder.Entity("BookingSystem.Models.BookingModel", b =>
                {
                    b.HasOne("BookingSystem.Models.SalonSpaModel", "SalonSpa")
                        .WithMany("Bookings")
                        .HasForeignKey("SalonSpaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BookingSystem.Models.ServiceModel", "Service")
                        .WithMany("Bookings")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BookingSystem.Models.UserModel", "User")
                        .WithMany("Bookings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("SalonSpa");

                    b.Navigation("Service");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BookingSystem.Models.NotificationModel", b =>
                {
                    b.HasOne("BookingSystem.Models.UserModel", "User")
                        .WithMany("Notifications")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BookingSystem.Models.PaymentModel", b =>
                {
                    b.HasOne("BookingSystem.Models.BookingModel", "Booking")
                        .WithOne("Payment")
                        .HasForeignKey("BookingSystem.Models.PaymentModel", "BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");
                });

            modelBuilder.Entity("BookingSystem.Models.ReviewModel", b =>
                {
                    b.HasOne("BookingSystem.Models.SalonSpaModel", "SalonSpa")
                        .WithMany("Reviews")
                        .HasForeignKey("SalonSpaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BookingSystem.Models.UserModel", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("SalonSpa");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BookingSystem.Models.SalonSpaModel", b =>
                {
                    b.HasOne("BookingSystem.Models.UserModel", "User")
                        .WithMany()
                        .HasForeignKey("SalonOwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BookingSystem.Models.ServiceSalonSpaModel", b =>
                {
                    b.HasOne("BookingSystem.Models.SalonSpaModel", "SalonSpa")
                        .WithMany("ServiceSalonSpas")
                        .HasForeignKey("SalonSpaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookingSystem.Models.ServiceModel", "Service")
                        .WithMany("ServiceSalonSpas")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SalonSpa");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("BookingSystem.Models.UserProfileModel", b =>
                {
                    b.HasOne("BookingSystem.Models.UserModel", "User")
                        .WithOne("UserProfile")
                        .HasForeignKey("BookingSystem.Models.UserProfileModel", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BookingSystem.Models.BookingModel", b =>
                {
                    b.Navigation("Payment")
                        .IsRequired();
                });

            modelBuilder.Entity("BookingSystem.Models.SalonSpaModel", b =>
                {
                    b.Navigation("Availabilities");

                    b.Navigation("Bookings");

                    b.Navigation("Reviews");

                    b.Navigation("ServiceSalonSpas");
                });

            modelBuilder.Entity("BookingSystem.Models.ServiceModel", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("ServiceSalonSpas");
                });

            modelBuilder.Entity("BookingSystem.Models.UserModel", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("Notifications");

                    b.Navigation("Reviews");

                    b.Navigation("UserProfile")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
