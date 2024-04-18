using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Models.Entities;

public partial class DatabaseCarRentalSystemContext : DbContext
{
    public DatabaseCarRentalSystemContext()
    {
    }

    public DatabaseCarRentalSystemContext(DbContextOptions<DatabaseCarRentalSystemContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Booking> Bookings { get; set; }

    public virtual DbSet<Car> Cars { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Taken\\Desktop\\Group5.DataStructures\\CarRental\\CarRental\\CarRental\\DatabaseCarRentalSystem.mdf;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Booking>(entity =>
        {
            entity.HasKey(e => e.BookingId).HasName("PK__Bookings__73951ACD8FF4EAEA");

            entity.Property(e => e.BookingId).HasColumnName("BookingID");
            entity.Property(e => e.CarId).HasColumnName("CarID");
            entity.Property(e => e.PickupDate).HasColumnType("datetime");
            entity.Property(e => e.PickupLocation)
                .IsRequired()
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.ReturnDate).HasColumnType("datetime");
            entity.Property(e => e.ReturnLocation)
                .IsRequired()
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Car).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.CarId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Bookings_ToTableCars");

            entity.HasOne(d => d.User).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Bookings_ToTableUsers");
        });

        modelBuilder.Entity<Car>(entity =>
        {
            entity.HasKey(e => e.CarId).HasName("PK__Cars__68A0340E62363C36");

            entity.Property(e => e.CarId).HasColumnName("CarID");
            entity.Property(e => e.CarColor)
                .IsRequired()
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.CarMake)
                .IsRequired()
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.CarModel)
                .IsRequired()
                .HasMaxLength(20)
                .IsFixedLength();
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CCACC189F1FE");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Address)
                .IsRequired()
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(30)
                .IsFixedLength();
            entity.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(30)
                .IsFixedLength();
            entity.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.Role)
                .IsRequired()
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.UserName)
                .IsRequired()
                .HasMaxLength(20)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
