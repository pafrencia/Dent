using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Dent.Models;

public partial class DbDentistaContext : DbContext
{
    public DbDentistaContext()
    {
    }

    public DbDentistaContext(DbContextOptions<DbDentistaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Login> Logins { get; set; }

    public virtual DbSet<Practica1> Practicas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-S5MA4R8; Database=DbDentista; Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Login>(entity =>
        {
            entity.ToTable("Login");

            entity.Property(e => e.Contraseña)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Usuario)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<Practica1>(entity =>
        {
            entity.Property(e => e.Practica)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("Practica");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
