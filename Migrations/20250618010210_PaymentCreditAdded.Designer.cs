﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlayStation.Models;

#nullable disable

namespace PlayStation.Migrations
{
    [DbContext(typeof(PSManagementDbContext))]
    [Migration("20250618010210_PaymentCreditAdded")]
    partial class PaymentCreditAdded
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PlayStation.Models.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("HourlyRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("HourlyRateForMulti")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK__Device__3214EC27833622CA");

                    b.HasIndex(new[] { "Name" }, "UQ__Device__737584F6D3A3D3A3")
                        .IsUnique();

                    b.ToTable("Device", (string)null);
                });

            modelBuilder.Entity("PlayStation.Models.Expense", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    b.HasKey("Id")
                        .HasName("PK__Expenses__3214EC27FCD90BB1");

                    b.HasIndex("UserId");

                    b.ToTable("Expenses");
                });

            modelBuilder.Entity("PlayStation.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<decimal>("Stock")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id")
                        .HasName("PK__Items__3214EC277D3552D0");

                    b.HasIndex(new[] { "Name" }, "UQ__Items__737584F6D3A3D3A3")
                        .IsUnique();

                    b.ToTable("Items");
                });

            modelBuilder.Entity("PlayStation.Models.LoginSession", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsLoggedOut")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LoginTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LogoutTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("LoginSessions");
                });

            modelBuilder.Entity("PlayStation.Models.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("ItemId")
                        .HasColumnType("int")
                        .HasColumnName("ItemID");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("SessionId")
                        .HasColumnType("int")
                        .HasColumnName("SessionId");

                    b.Property<decimal?>("TotalPrice")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("decimal(29, 0)")
                        .HasComputedColumnSql("([Quantity]*[UnitPrice])", true);

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18, 0)");

                    b.HasKey("Id")
                        .HasName("PK__OrderDet__3214EC278AE97305");

                    b.HasIndex("ItemId");

                    b.HasIndex("SessionId");

                    b.ToTable("OrderDetail", (string)null);
                });

            modelBuilder.Entity("PlayStation.Models.Session", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("AmountPaid")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DeviceId")
                        .HasColumnType("int")
                        .HasColumnName("DeviceID");

                    b.Property<decimal>("Duration")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsCredit")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("RemainingBalance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<decimal>("TotalCost")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK__Session__3214EC27A578C9FC");

                    b.HasIndex("DeviceId");

                    b.HasIndex("UserId");

                    b.ToTable("Session", (string)null);
                });

            modelBuilder.Entity("PlayStation.Models.SessionTypeChanges", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("ChangeTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("CostUntilChange")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("NewType")
                        .HasColumnType("int");

                    b.Property<int>("OldType")
                        .HasColumnType("int");

                    b.Property<int>("SessionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SessionId");

                    b.ToTable("SessionTypeChanges");
                });

            modelBuilder.Entity("PlayStation.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id")
                        .HasName("PK__User__3214EC274FC86FB1");

                    b.HasIndex(new[] { "Name" }, "UQ__User__737584F6D3A3D3A3")
                        .IsUnique();

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("PlayStation.Models.Expense", b =>
                {
                    b.HasOne("PlayStation.Models.User", "User")
                        .WithMany("Expenses")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Expenses_USer");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PlayStation.Models.LoginSession", b =>
                {
                    b.HasOne("PlayStation.Models.User", "User")
                        .WithMany("LoginSession")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PlayStation.Models.OrderDetail", b =>
                {
                    b.HasOne("PlayStation.Models.Item", "Item")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ItemId")
                        .IsRequired()
                        .HasConstraintName("FK_OrderDetails_Items");

                    b.HasOne("PlayStation.Models.Session", "Session")
                        .WithMany("OrderDetails")
                        .HasForeignKey("SessionId")
                        .IsRequired()
                        .HasConstraintName("FK_OrderDetails_Order");

                    b.Navigation("Item");

                    b.Navigation("Session");
                });

            modelBuilder.Entity("PlayStation.Models.Session", b =>
                {
                    b.HasOne("PlayStation.Models.Device", "Device")
                        .WithMany("Sessions")
                        .HasForeignKey("DeviceId")
                        .IsRequired()
                        .HasConstraintName("FK_Session_Console");

                    b.HasOne("PlayStation.Models.User", null)
                        .WithMany("Session")
                        .HasForeignKey("UserId");

                    b.Navigation("Device");
                });

            modelBuilder.Entity("PlayStation.Models.SessionTypeChanges", b =>
                {
                    b.HasOne("PlayStation.Models.Session", "Session")
                        .WithMany("SessionTypeChanges")
                        .HasForeignKey("SessionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Session");
                });

            modelBuilder.Entity("PlayStation.Models.Device", b =>
                {
                    b.Navigation("Sessions");
                });

            modelBuilder.Entity("PlayStation.Models.Item", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("PlayStation.Models.Session", b =>
                {
                    b.Navigation("OrderDetails");

                    b.Navigation("SessionTypeChanges");
                });

            modelBuilder.Entity("PlayStation.Models.User", b =>
                {
                    b.Navigation("Expenses");

                    b.Navigation("LoginSession");

                    b.Navigation("Session");
                });
#pragma warning restore 612, 618
        }
    }
}
