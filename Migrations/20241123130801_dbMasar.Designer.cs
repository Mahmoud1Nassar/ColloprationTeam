﻿// <auto-generated />
using System;
using MASAR.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MASAR.Migrations
{
    [DbContext(typeof(MASARDBContext))]
    [Migration("20241123130801_dbMasar")]
    partial class dbMasar
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MASAR.Model.Announcement", b =>
                {
                    b.Property<string>("AnnouncementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AdminId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Audience")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AnnouncementId");

                    b.HasIndex("AdminId");

                    b.ToTable("Announcement");
                });

            modelBuilder.Entity("MASAR.Model.ApplicationUser", b =>
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

                    b.Property<string>("Roles")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("MASAR.Model.Bus", b =>
                {
                    b.Property<string>("BusId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CapacityNumber")
                        .HasColumnType("int");

                    b.Property<string>("CurrentLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LicenseExpiry")
                        .HasColumnType("datetime2");

                    b.Property<int>("PlateNumber")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("BusId");

                    b.ToTable("Bus");
                });

            modelBuilder.Entity("MASAR.Model.BusLocation", b =>
                {
                    b.Property<string>("BusLocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BusId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<double?>("PreviuseLatitude")
                        .HasColumnType("float");

                    b.Property<double?>("PreviuseLongitude")
                        .HasColumnType("float");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.HasKey("BusLocationId");

                    b.HasIndex("BusId")
                        .IsUnique();

                    b.ToTable("BusLocation");
                });

            modelBuilder.Entity("MASAR.Model.DriverProfile", b =>
                {
                    b.Property<string>("DriverProfileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BusId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DriverId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("LicenseNumber")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DriverProfileId");

                    b.HasIndex("BusId")
                        .IsUnique();

                    b.HasIndex("DriverId")
                        .IsUnique();

                    b.ToTable("DriverProfile");
                });

            modelBuilder.Entity("MASAR.Model.FavoriteRoute", b =>
                {
                    b.Property<int>("FavoriteRouteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FavoriteRouteId"));

                    b.Property<string>("RoutingId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("StudentId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("FavoriteRouteId");

                    b.HasIndex("RoutingId");

                    b.HasIndex("StudentId");

                    b.ToTable("FavoriteRoute");
                });

            modelBuilder.Entity("MASAR.Model.Maintenance", b =>
                {
                    b.Property<string>("MaintenanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BusId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DriverId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ExpectedMaintenanceDays")
                        .HasColumnType("int");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaintenanceId");

                    b.HasIndex("BusId");

                    b.HasIndex("DriverId");

                    b.ToTable("Maintenance");
                });

            modelBuilder.Entity("MASAR.Model.Routing", b =>
                {
                    b.Property<string>("RoutingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EndPoint")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("EstimatedTime")
                        .HasColumnType("time");

                    b.Property<string>("RouteName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartPoint")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TotalDistance")
                        .HasColumnType("float");

                    b.HasKey("RoutingId");

                    b.ToTable("Routing");

                    b.HasData(
                        new
                        {
                            RoutingId = "4ccdea06-f510-4023-ab3f-cc48b8dad810",
                            EndPoint = "Khalda",
                            EstimatedTime = new TimeSpan(0, 1, 0, 0, 0),
                            RouteName = "Khalda",
                            StartPoint = "LTUC",
                            TotalDistance = 15.5
                        },
                        new
                        {
                            RoutingId = "2a26bc3b-51da-4821-9546-0f81b53a9eb2",
                            EndPoint = "Al-Shmesaani",
                            EstimatedTime = new TimeSpan(0, 1, 0, 0, 0),
                            RouteName = "Al-Shmesaani",
                            StartPoint = "LTUC",
                            TotalDistance = 20.300000000000001
                        },
                        new
                        {
                            RoutingId = "194cfe42-e751-4c4e-aff3-5efc30260035",
                            EndPoint = "Al-Ashrafiyah",
                            EstimatedTime = new TimeSpan(0, 1, 0, 0, 0),
                            RouteName = "Al-Ashrafiyah",
                            StartPoint = "LTUC",
                            TotalDistance = 25.0
                        });
                });

            modelBuilder.Entity("MASAR.Model.Schedule", b =>
                {
                    b.Property<string>("ScheduleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DriverId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EstimatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("RoutingId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ScheduleId");

                    b.HasIndex("DriverId");

                    b.HasIndex("RoutingId");

                    b.ToTable("Schedule");
                });

            modelBuilder.Entity("MASAR.Model.StopPoint", b =>
                {
                    b.Property<int>("StopPointId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StopPointId"));

                    b.Property<TimeSpan>("EstimatedTime")
                        .HasColumnType("time");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoutingId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("StopPointId");

                    b.HasIndex("RoutingId");

                    b.ToTable("StopPoints");

                    b.HasData(
                        new
                        {
                            StopPointId = 1,
                            EstimatedTime = new TimeSpan(0, 0, 20, 0, 0),
                            Name = "Airport St",
                            RoutingId = "4ccdea06-f510-4023-ab3f-cc48b8dad810"
                        },
                        new
                        {
                            StopPointId = 2,
                            EstimatedTime = new TimeSpan(0, 0, 25, 0, 0),
                            Name = "7th Circle",
                            RoutingId = "4ccdea06-f510-4023-ab3f-cc48b8dad810"
                        },
                        new
                        {
                            StopPointId = 3,
                            EstimatedTime = new TimeSpan(0, 0, 15, 0, 0),
                            Name = "Mecca St",
                            RoutingId = "4ccdea06-f510-4023-ab3f-cc48b8dad810"
                        },
                        new
                        {
                            StopPointId = 4,
                            EstimatedTime = new TimeSpan(0, 0, 10, 0, 0),
                            Name = "Khalda",
                            RoutingId = "4ccdea06-f510-4023-ab3f-cc48b8dad810"
                        },
                        new
                        {
                            StopPointId = 5,
                            EstimatedTime = new TimeSpan(0, 0, 12, 0, 0),
                            Name = "Airport St",
                            RoutingId = "2a26bc3b-51da-4821-9546-0f81b53a9eb2"
                        },
                        new
                        {
                            StopPointId = 6,
                            EstimatedTime = new TimeSpan(0, 0, 16, 0, 0),
                            Name = "Abdoun",
                            RoutingId = "2a26bc3b-51da-4821-9546-0f81b53a9eb2"
                        },
                        new
                        {
                            StopPointId = 7,
                            EstimatedTime = new TimeSpan(0, 0, 20, 0, 0),
                            Name = "Um Uthaina",
                            RoutingId = "2a26bc3b-51da-4821-9546-0f81b53a9eb2"
                        },
                        new
                        {
                            StopPointId = 8,
                            EstimatedTime = new TimeSpan(0, 0, 20, 0, 0),
                            Name = "Al-Rabiya",
                            RoutingId = "2a26bc3b-51da-4821-9546-0f81b53a9eb2"
                        },
                        new
                        {
                            StopPointId = 9,
                            EstimatedTime = new TimeSpan(0, 0, 20, 0, 0),
                            Name = "Al-Shmesaani",
                            RoutingId = "2a26bc3b-51da-4821-9546-0f81b53a9eb2"
                        },
                        new
                        {
                            StopPointId = 10,
                            EstimatedTime = new TimeSpan(0, 0, 25, 0, 0),
                            Name = "Al-Quds St",
                            RoutingId = "194cfe42-e751-4c4e-aff3-5efc30260035"
                        },
                        new
                        {
                            StopPointId = 11,
                            EstimatedTime = new TimeSpan(0, 0, 15, 0, 0),
                            Name = "Al-Muqabalain",
                            RoutingId = "194cfe42-e751-4c4e-aff3-5efc30260035"
                        },
                        new
                        {
                            StopPointId = 12,
                            EstimatedTime = new TimeSpan(0, 0, 15, 0, 0),
                            Name = "Hai Nazaal",
                            RoutingId = "194cfe42-e751-4c4e-aff3-5efc30260035"
                        },
                        new
                        {
                            StopPointId = 13,
                            EstimatedTime = new TimeSpan(0, 0, 20, 0, 0),
                            Name = "Al-Ashrafiyah",
                            RoutingId = "194cfe42-e751-4c4e-aff3-5efc30260035"
                        });
                });

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

                    b.HasData(
                        new
                        {
                            Id = "admin",
                            ConcurrencyStamp = "483ea611-f1ba-4f34-98c3-7a2302dd52c0",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "driver",
                            ConcurrencyStamp = "5cf38f86-70a7-490a-8cb4-c9a1812ddb0b",
                            Name = "Driver",
                            NormalizedName = "DRIVER"
                        },
                        new
                        {
                            Id = "student",
                            ConcurrencyStamp = "ec037015-af0f-4f23-a2cf-ba03044bf22a",
                            Name = "Student",
                            NormalizedName = "STUDENT"
                        },
                        new
                        {
                            Id = "user",
                            ConcurrencyStamp = "5d3ea3ef-e8eb-492f-8424-112606137e47",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

                    b.HasData(
                        new
                        {
                            Id = -551999624,
                            ClaimType = "permission",
                            ClaimValue = "create",
                            RoleId = "admin"
                        },
                        new
                        {
                            Id = -408381390,
                            ClaimType = "permission",
                            ClaimValue = "update",
                            RoleId = "admin"
                        },
                        new
                        {
                            Id = 1362574069,
                            ClaimType = "permission",
                            ClaimValue = "delete",
                            RoleId = "admin"
                        },
                        new
                        {
                            Id = 1041763754,
                            ClaimType = "permission",
                            ClaimValue = "read",
                            RoleId = "admin"
                        },
                        new
                        {
                            Id = -1742857321,
                            ClaimType = "permission",
                            ClaimValue = "update",
                            RoleId = "driver"
                        },
                        new
                        {
                            Id = 1080902927,
                            ClaimType = "permission",
                            ClaimValue = "read",
                            RoleId = "driver"
                        },
                        new
                        {
                            Id = 794019726,
                            ClaimType = "permission",
                            ClaimValue = "update",
                            RoleId = "student"
                        },
                        new
                        {
                            Id = 1708460071,
                            ClaimType = "permission",
                            ClaimValue = "read",
                            RoleId = "student"
                        },
                        new
                        {
                            Id = -1284749112,
                            ClaimType = "permission",
                            ClaimValue = "update",
                            RoleId = "user"
                        },
                        new
                        {
                            Id = -967882180,
                            ClaimType = "permission",
                            ClaimValue = "read",
                            RoleId = "user"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

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
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MASAR.Model.Announcement", b =>
                {
                    b.HasOne("MASAR.Model.ApplicationUser", "User")
                        .WithMany("Announcements")
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MASAR.Model.BusLocation", b =>
                {
                    b.HasOne("MASAR.Model.Bus", "Bus")
                        .WithOne("BusLocations")
                        .HasForeignKey("MASAR.Model.BusLocation", "BusId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Bus");
                });

            modelBuilder.Entity("MASAR.Model.DriverProfile", b =>
                {
                    b.HasOne("MASAR.Model.Bus", "Bus")
                        .WithOne("DriverProfiles")
                        .HasForeignKey("MASAR.Model.DriverProfile", "BusId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MASAR.Model.ApplicationUser", "User")
                        .WithOne("DriverProfiles")
                        .HasForeignKey("MASAR.Model.DriverProfile", "DriverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bus");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MASAR.Model.FavoriteRoute", b =>
                {
                    b.HasOne("MASAR.Model.Routing", "Routing")
                        .WithMany("FavoriteRoute")
                        .HasForeignKey("RoutingId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MASAR.Model.ApplicationUser", "User")
                        .WithMany("FavoriteRoute")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Routing");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MASAR.Model.Maintenance", b =>
                {
                    b.HasOne("MASAR.Model.Bus", "Bus")
                        .WithMany("Maintenances")
                        .HasForeignKey("BusId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MASAR.Model.DriverProfile", "DriverProfile")
                        .WithMany("Maintenances")
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Bus");

                    b.Navigation("DriverProfile");
                });

            modelBuilder.Entity("MASAR.Model.Schedule", b =>
                {
                    b.HasOne("MASAR.Model.ApplicationUser", "User")
                        .WithMany("Schedules")
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MASAR.Model.Routing", "Routing")
                        .WithMany("Schedules")
                        .HasForeignKey("RoutingId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Routing");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MASAR.Model.StopPoint", b =>
                {
                    b.HasOne("MASAR.Model.Routing", "Routing")
                        .WithMany("StopPoints")
                        .HasForeignKey("RoutingId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Routing");
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
                    b.HasOne("MASAR.Model.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MASAR.Model.ApplicationUser", null)
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

                    b.HasOne("MASAR.Model.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MASAR.Model.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MASAR.Model.ApplicationUser", b =>
                {
                    b.Navigation("Announcements");

                    b.Navigation("DriverProfiles")
                        .IsRequired();

                    b.Navigation("FavoriteRoute");

                    b.Navigation("Schedules");
                });

            modelBuilder.Entity("MASAR.Model.Bus", b =>
                {
                    b.Navigation("BusLocations")
                        .IsRequired();

                    b.Navigation("DriverProfiles")
                        .IsRequired();

                    b.Navigation("Maintenances");
                });

            modelBuilder.Entity("MASAR.Model.DriverProfile", b =>
                {
                    b.Navigation("Maintenances");
                });

            modelBuilder.Entity("MASAR.Model.Routing", b =>
                {
                    b.Navigation("FavoriteRoute");

                    b.Navigation("Schedules");

                    b.Navigation("StopPoints");
                });
#pragma warning restore 612, 618
        }
    }
}
