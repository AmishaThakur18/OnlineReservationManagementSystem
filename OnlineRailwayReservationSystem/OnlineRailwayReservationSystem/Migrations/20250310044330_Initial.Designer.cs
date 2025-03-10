﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineRailwayReservationSystem.Models;

#nullable disable

namespace OnlineRailwayReservationSystem.Migrations
{
    [DbContext(typeof(OnlineRailwayReservationSystemDbContext))]
    [Migration("20250310044330_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OnlineRailwayReservationSystem.Models.Class", b =>
                {
                    b.Property<string>("ClassId")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<int>("AvailableSeats")
                        .HasColumnType("int");

                    b.Property<string>("ClassName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("ClassType")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.HasKey("ClassId")
                        .HasName("PK__Class__CB1927C0BCB3919E");

                    b.ToTable("Class", (string)null);
                });

            modelBuilder.Entity("OnlineRailwayReservationSystem.Models.Coach", b =>
                {
                    b.Property<string>("CoachId")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("ClassId")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("CoachNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.HasKey("CoachId")
                        .HasName("PK__Coach__F411D9413E6153BE");

                    b.HasIndex("ClassId");

                    b.ToTable("Coach", (string)null);
                });

            modelBuilder.Entity("OnlineRailwayReservationSystem.Models.Fare", b =>
                {
                    b.Property<string>("FareId")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<double>("BaseFare")
                        .HasColumnType("float");

                    b.Property<double>("CancelCharge12hrs")
                        .HasColumnType("float")
                        .HasColumnName("CancelCharge_12hrs");

                    b.Property<double>("CancelCharge48hrs")
                        .HasColumnType("float")
                        .HasColumnName("CancelCharge_48hrs");

                    b.Property<double>("CancelCharge4hrs")
                        .HasColumnType("float")
                        .HasColumnName("CancelCharge_4hrs");

                    b.Property<double>("ChargePerKm")
                        .HasColumnType("float");

                    b.Property<string>("ClassId")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<double>("ReservationCharge")
                        .HasColumnType("float");

                    b.HasKey("FareId")
                        .HasName("PK__Fare__1261FA16B3B77025");

                    b.HasIndex("ClassId");

                    b.ToTable("Fare", (string)null);
                });

            modelBuilder.Entity("OnlineRailwayReservationSystem.Models.Payment", b =>
                {
                    b.Property<string>("PaymentId")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<DateOnly>("PaymentDate")
                        .HasColumnType("date");

                    b.Property<string>("PaymentMode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("TicketId")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.HasKey("PaymentId")
                        .HasName("PK__Payment__9B556A388522AC9F");

                    b.HasIndex("TicketId");

                    b.HasIndex("UserId");

                    b.ToTable("Payment", (string)null);
                });

            modelBuilder.Entity("OnlineRailwayReservationSystem.Models.Query", b =>
                {
                    b.Property<string>("QueryId")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Keywords")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("QueryId")
                        .HasName("PK__Query__5967F7DB7C989E8C");

                    b.ToTable("Query", (string)null);
                });

            modelBuilder.Entity("OnlineRailwayReservationSystem.Models.QueryList", b =>
                {
                    b.Property<string>("QueryListId")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("QueryDescription")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("QueryId")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.HasKey("QueryListId")
                        .HasName("PK__QueryLis__ACD72B5F3B79442A");

                    b.HasIndex("QueryId");

                    b.ToTable("QueryList", (string)null);
                });

            modelBuilder.Entity("OnlineRailwayReservationSystem.Models.Quotum", b =>
                {
                    b.Property<string>("QuotaId")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<int>("AgeLimit")
                        .HasColumnType("int");

                    b.Property<string>("QuotaType")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.HasKey("QuotaId")
                        .HasName("PK__Quota__AE96C9C26F31BF70");

                    b.ToTable("Quota");
                });

            modelBuilder.Entity("OnlineRailwayReservationSystem.Models.ReservationDetail", b =>
                {
                    b.Property<string>("ReservationId")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("PaymentId")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("TicketId")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.HasKey("ReservationId")
                        .HasName("PK__Reservat__B7EE5F24F86E0AA9");

                    b.HasIndex("PaymentId");

                    b.HasIndex("TicketId");

                    b.HasIndex("UserId");

                    b.ToTable("ReservationDetails");
                });

            modelBuilder.Entity("OnlineRailwayReservationSystem.Models.Role", b =>
                {
                    b.Property<string>("RoleId")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.HasKey("RoleId")
                        .HasName("PK__Roles__8AFACE1AE95D23F0");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("OnlineRailwayReservationSystem.Models.Route", b =>
                {
                    b.Property<string>("RouteId")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("RouteID");

                    b.Property<TimeOnly?>("Arrival")
                        .HasColumnType("time");

                    b.Property<TimeOnly?>("Departure")
                        .HasColumnType("time");

                    b.Property<string>("Destination")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<int>("Distance")
                        .HasColumnType("int");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Source")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.HasKey("RouteId")
                        .HasName("PK__Route__80979AADC56E975F");

                    b.ToTable("Route", (string)null);
                });

            modelBuilder.Entity("OnlineRailwayReservationSystem.Models.Seat", b =>
                {
                    b.Property<string>("SeatId")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<bool?>("AvailabilityStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("CoachId")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<int?>("SeatNumber")
                        .HasColumnType("int");

                    b.HasKey("SeatId")
                        .HasName("PK__Seat__311713F3614ADD1A");

                    b.HasIndex("CoachId");

                    b.ToTable("Seat", (string)null);
                });

            modelBuilder.Entity("OnlineRailwayReservationSystem.Models.Support", b =>
                {
                    b.Property<string>("SupportId")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("QueryListId")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("QueryText")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Status")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("UserId")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.HasKey("SupportId")
                        .HasName("PK__Support__D82DBC8C9E990C14");

                    b.HasIndex("QueryListId");

                    b.HasIndex("UserId");

                    b.ToTable("Support", (string)null);
                });

            modelBuilder.Entity("OnlineRailwayReservationSystem.Models.Ticket", b =>
                {
                    b.Property<string>("TicketId")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("ClassName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Coach")
                        .IsRequired()
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("varchar(5)");

                    b.Property<string>("DestinationStation")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<TimeOnly>("Duration")
                        .HasColumnType("time");

                    b.Property<DateTime>("JourneyEndDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("JourneyStartDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Pnr")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("PNR");

                    b.Property<string>("SeatNumber")
                        .IsRequired()
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("varchar(5)");

                    b.Property<string>("SourceStation")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("TicketStatus")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<double>("TotalFare")
                        .HasColumnType("float");

                    b.Property<string>("TrainId")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("UserId")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.HasKey("TicketId")
                        .HasName("PK__Ticket__712CC607F8C8E4B0");

                    b.HasIndex("TrainId");

                    b.HasIndex("UserId");

                    b.ToTable("Ticket", (string)null);
                });

            modelBuilder.Entity("OnlineRailwayReservationSystem.Models.Train", b =>
                {
                    b.Property<string>("TrainId")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Route")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("RunningDay")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<int>("TotalSeats")
                        .HasColumnType("int");

                    b.Property<string>("TrainName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("TrainNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.HasKey("TrainId")
                        .HasName("PK__Train__8ED2723A765E2A95");

                    b.ToTable("Train", (string)null);
                });

            modelBuilder.Entity("OnlineRailwayReservationSystem.Models.TrainClass", b =>
                {
                    b.Property<string>("ClassId")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("TrainId")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.HasIndex("ClassId");

                    b.HasIndex("TrainId");

                    b.ToTable("TrainClass", (string)null);
                });

            modelBuilder.Entity("OnlineRailwayReservationSystem.Models.TrainQuotum", b =>
                {
                    b.Property<string>("QuotaId")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("TrainId")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.HasIndex("QuotaId");

                    b.HasIndex("TrainId");

                    b.ToTable("TrainQuota");
                });

            modelBuilder.Entity("OnlineRailwayReservationSystem.Models.User", b =>
                {
                    b.Property<string>("UserId")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.HasKey("UserId")
                        .HasName("PK__Users__1788CC4C4BACA676");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("OnlineRailwayReservationSystem.Models.UserRole", b =>
                {
                    b.Property<string>("UserId")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("RoleId")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.HasKey("UserId")
                        .HasName("PK__UserRole__1788CC4C1BD7CA60");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("OnlineRailwayReservationSystem.Models.Coach", b =>
                {
                    b.HasOne("OnlineRailwayReservationSystem.Models.Class", "Class")
                        .WithMany("Coaches")
                        .HasForeignKey("ClassId")
                        .HasConstraintName("FK__Coach__ClassId__3C69FB99");

                    b.Navigation("Class");
                });

            modelBuilder.Entity("OnlineRailwayReservationSystem.Models.Fare", b =>
                {
                    b.HasOne("OnlineRailwayReservationSystem.Models.Class", "Class")
                        .WithMany("Fares")
                        .HasForeignKey("ClassId")
                        .HasConstraintName("FK__Fare__ClassId__47DBAE45");

                    b.Navigation("Class");
                });

            modelBuilder.Entity("OnlineRailwayReservationSystem.Models.Payment", b =>
                {
                    b.HasOne("OnlineRailwayReservationSystem.Models.Ticket", "Ticket")
                        .WithMany("Payments")
                        .HasForeignKey("TicketId")
                        .IsRequired()
                        .HasConstraintName("FK__Payment__TicketI__4BAC3F29");

                    b.HasOne("OnlineRailwayReservationSystem.Models.User", "User")
                        .WithMany("Payments")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK__Payment__UserId__4AB81AF0");

                    b.Navigation("Ticket");

                    b.Navigation("User");
                });

            modelBuilder.Entity("OnlineRailwayReservationSystem.Models.QueryList", b =>
                {
                    b.HasOne("OnlineRailwayReservationSystem.Models.Query", "Query")
                        .WithMany("QueryLists")
                        .HasForeignKey("QueryId")
                        .HasConstraintName("FK__QueryList__Query__5812160E");

                    b.Navigation("Query");
                });

            modelBuilder.Entity("OnlineRailwayReservationSystem.Models.ReservationDetail", b =>
                {
                    b.HasOne("OnlineRailwayReservationSystem.Models.Payment", "Payment")
                        .WithMany("ReservationDetails")
                        .HasForeignKey("PaymentId")
                        .IsRequired()
                        .HasConstraintName("FK__Reservati__Payme__534D60F1");

                    b.HasOne("OnlineRailwayReservationSystem.Models.Ticket", "Ticket")
                        .WithMany("ReservationDetails")
                        .HasForeignKey("TicketId")
                        .IsRequired()
                        .HasConstraintName("FK__Reservati__Ticke__5070F446");

                    b.HasOne("OnlineRailwayReservationSystem.Models.User", "User")
                        .WithMany("ReservationDetails")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK__Reservati__UserI__5165187F");

                    b.Navigation("Payment");

                    b.Navigation("Ticket");

                    b.Navigation("User");
                });

            modelBuilder.Entity("OnlineRailwayReservationSystem.Models.Seat", b =>
                {
                    b.HasOne("OnlineRailwayReservationSystem.Models.Coach", "Coach")
                        .WithMany("Seats")
                        .HasForeignKey("CoachId")
                        .HasConstraintName("FK__Seat__CoachId__403A8C7D");

                    b.Navigation("Coach");
                });

            modelBuilder.Entity("OnlineRailwayReservationSystem.Models.Support", b =>
                {
                    b.HasOne("OnlineRailwayReservationSystem.Models.QueryList", "QueryList")
                        .WithMany("Supports")
                        .HasForeignKey("QueryListId")
                        .HasConstraintName("FK__Support__QueryLi__5BE2A6F2");

                    b.HasOne("OnlineRailwayReservationSystem.Models.User", "User")
                        .WithMany("Supports")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__Support__UserId__5AEE82B9");

                    b.Navigation("QueryList");

                    b.Navigation("User");
                });

            modelBuilder.Entity("OnlineRailwayReservationSystem.Models.Ticket", b =>
                {
                    b.HasOne("OnlineRailwayReservationSystem.Models.Train", "Train")
                        .WithMany("Tickets")
                        .HasForeignKey("TrainId")
                        .HasConstraintName("FK__Ticket__TrainId__440B1D61");

                    b.HasOne("OnlineRailwayReservationSystem.Models.User", "User")
                        .WithMany("Tickets")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__Ticket__UserId__4316F928");

                    b.Navigation("Train");

                    b.Navigation("User");
                });

            modelBuilder.Entity("OnlineRailwayReservationSystem.Models.TrainClass", b =>
                {
                    b.HasOne("OnlineRailwayReservationSystem.Models.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId")
                        .IsRequired()
                        .HasConstraintName("FK__TrainClas__Class__38996AB5");

                    b.HasOne("OnlineRailwayReservationSystem.Models.Train", "Train")
                        .WithMany()
                        .HasForeignKey("TrainId")
                        .IsRequired()
                        .HasConstraintName("FK__TrainClas__Train__398D8EEE");

                    b.Navigation("Class");

                    b.Navigation("Train");
                });

            modelBuilder.Entity("OnlineRailwayReservationSystem.Models.TrainQuotum", b =>
                {
                    b.HasOne("OnlineRailwayReservationSystem.Models.Quotum", "Quota")
                        .WithMany()
                        .HasForeignKey("QuotaId")
                        .IsRequired()
                        .HasConstraintName("FK__TrainQout__Quota__31EC6D26");

                    b.HasOne("OnlineRailwayReservationSystem.Models.Train", "Train")
                        .WithMany()
                        .HasForeignKey("TrainId")
                        .IsRequired()
                        .HasConstraintName("FK__TrainQout__Train__32E0915F");

                    b.Navigation("Quota");

                    b.Navigation("Train");
                });

            modelBuilder.Entity("OnlineRailwayReservationSystem.Models.UserRole", b =>
                {
                    b.HasOne("OnlineRailwayReservationSystem.Models.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK__UserRoles__RoleI__29572725");

                    b.HasOne("OnlineRailwayReservationSystem.Models.User", "User")
                        .WithOne("UserRole")
                        .HasForeignKey("OnlineRailwayReservationSystem.Models.UserRole", "UserId")
                        .IsRequired()
                        .HasConstraintName("FK__UserRoles__UserI__286302EC");

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("OnlineRailwayReservationSystem.Models.Class", b =>
                {
                    b.Navigation("Coaches");

                    b.Navigation("Fares");
                });

            modelBuilder.Entity("OnlineRailwayReservationSystem.Models.Coach", b =>
                {
                    b.Navigation("Seats");
                });

            modelBuilder.Entity("OnlineRailwayReservationSystem.Models.Payment", b =>
                {
                    b.Navigation("ReservationDetails");
                });

            modelBuilder.Entity("OnlineRailwayReservationSystem.Models.Query", b =>
                {
                    b.Navigation("QueryLists");
                });

            modelBuilder.Entity("OnlineRailwayReservationSystem.Models.QueryList", b =>
                {
                    b.Navigation("Supports");
                });

            modelBuilder.Entity("OnlineRailwayReservationSystem.Models.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("OnlineRailwayReservationSystem.Models.Ticket", b =>
                {
                    b.Navigation("Payments");

                    b.Navigation("ReservationDetails");
                });

            modelBuilder.Entity("OnlineRailwayReservationSystem.Models.Train", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("OnlineRailwayReservationSystem.Models.User", b =>
                {
                    b.Navigation("Payments");

                    b.Navigation("ReservationDetails");

                    b.Navigation("Supports");

                    b.Navigation("Tickets");

                    b.Navigation("UserRole");
                });
#pragma warning restore 612, 618
        }
    }
}
