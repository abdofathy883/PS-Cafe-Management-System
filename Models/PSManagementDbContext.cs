using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PlayStation.Models;

public partial class PSManagementDbContext : DbContext
{
    public PSManagementDbContext()
    {
    }

    public PSManagementDbContext(DbContextOptions<PSManagementDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Device> Devices { get; set; }

    public virtual DbSet<Expense> Expenses { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<Session> Sessions { get; set; }
    public virtual DbSet<LoginSession> LoginSessions { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=PSManagementSystem;Trusted_Connection=True;Encrypt=False;");

            //note use this ya abdo and comment the above line 
            //optionsBuilder.UseSqlServer("Server=.;Database=PSManagementSystemNeww;Trusted_Connection=True;Encrypt=False;");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Device>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Device__3214EC27833622CA");
            entity.HasIndex(e => e.Name, "UQ__Device__737584F6D3A3D3A3").IsUnique();
            entity.ToTable("Device");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(30);
            entity.Property(e => e.Type).HasMaxLength(30);
        });

        modelBuilder.Entity<Expense>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Expenses__3214EC27FCD90BB1");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.Expenses)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Expenses_USer");
        });

        modelBuilder.Entity<Item>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Items__3214EC277D3552D0");
            entity.HasIndex(e => e.Name, "UQ__Items__737584F6D3A3D3A3").IsUnique();
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(30);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OrderDet__3214EC278AE97305");

            entity.ToTable("OrderDetail");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.SessionId).HasColumnName("SessionId");
            entity.Property(e => e.TotalPrice)
                .HasComputedColumnSql("([Quantity]*[UnitPrice])", true)
                .HasColumnType("decimal(29, 0)");
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.Item).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderDetails_Items");

            entity.HasOne(d => d.Session).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.SessionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderDetails_Order");
        });

        modelBuilder.Entity<Session>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Session__3214EC27A578C9FC");

            entity.ToTable("Session");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DeviceId).HasColumnName("DeviceID");
            entity.Property(e => e.Duration).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.Device).WithMany(p => p.Sessions)
                .HasForeignKey(d => d.DeviceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Session_Console");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__User__3214EC274FC86FB1");
            entity.HasIndex(e => e.Name, "UQ__User__737584F6D3A3D3A3").IsUnique();
            entity.ToTable("User");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(15);
            entity.Property(e => e.Role).HasMaxLength(15);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
