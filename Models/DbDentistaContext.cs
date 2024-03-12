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

    public virtual DbSet<Paciente> Pacientes { get; set; }

    public virtual DbSet<Practica1> Practicas { get; set; }

    public virtual DbSet<PracticasApro> PracticasApros { get; set; }

    public virtual DbSet<PracticasRealizada> PracticasRealizadas { get; set; }

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

        modelBuilder.Entity<Paciente>(entity =>
        {
            entity.Property(e => e.Apellido)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.Celular)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Domicilio)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.FechaDeAlta).HasColumnType("date");
            entity.Property(e => e.FechaDeNacimiento).HasColumnType("date");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.NumeroAfiliado)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.ObraSocial)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Observaciones)
                .HasMaxLength(1000)
                .IsFixedLength();
            entity.Property(e => e.PlanDeObraSocial)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.Titular)
                .HasMaxLength(20)
                .IsFixedLength();
        });

        modelBuilder.Entity<Practica1>(entity =>
        {
            entity.Property(e => e.Practica)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("Practica");
        });

        modelBuilder.Entity<PracticasApro>(entity =>
        {
            entity.Property(e => e.Practica)
                .HasMaxLength(30)
                .IsFixedLength();
        });

        modelBuilder.Entity<PracticasRealizada>(entity =>
        {
            entity.Property(e => e.Fecha).HasColumnType("date");
            entity.Property(e => e.ObraSocial)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.Odontologo)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Paciente)
                .HasMaxLength(30)
                .IsFixedLength();
            entity.Property(e => e.Practica)
                .HasMaxLength(30)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
