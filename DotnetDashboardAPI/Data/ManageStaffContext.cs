using System;
using System.Collections.Generic;
using ManageStaff.Models;
using Microsoft.EntityFrameworkCore;

namespace ManageStaff.Data;

public partial class ManageStaffContext : DbContext
{
    public ManageStaffContext(DbContextOptions<ManageStaffContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Staff>? Staff { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Staff>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("staff");

            entity.Property(e => e.AccessLevel)
                .HasColumnType("enum('Admin','Manager','Employee')")
                .HasColumnName("access_level");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Contact)
                .HasMaxLength(20)
                .HasColumnName("contact");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("first_name");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("last_name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
