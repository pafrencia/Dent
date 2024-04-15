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

    public virtual DbSet<HistoriaClinica> HistoriaClinicas { get; set; }

    public virtual DbSet<Imprimir> Imprimirs { get; set; }

    public virtual DbSet<Login> Logins { get; set; }

    public virtual DbSet<Odontograma> Odontogramas { get; set; }

    public virtual DbSet<OdontrogramaNiño> OdontrogramaNiños { get; set; }

    public virtual DbSet<Paciente> Pacientes { get; set; }

    public virtual DbSet<Practica1> Practicas { get; set; }

    public virtual DbSet<PracticasApro> PracticasApros { get; set; }

    public virtual DbSet<PracticasOdontograma> PracticasOdontogramas { get; set; }

    public virtual DbSet<PracticasRealizada> PracticasRealizadas { get; set; }

    public virtual DbSet<Turno> Turnos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-S5MA4R8; Database=DbDentista; Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<HistoriaClinica>(entity =>
        {
            entity.ToTable("HistoriaClinica");

            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsFixedLength();
        });

        modelBuilder.Entity<Imprimir>(entity =>
        {
            entity.ToTable("Imprimir");
        });

        modelBuilder.Entity<Login>(entity =>
        {
            entity.ToTable("Login");

            entity.Property(e => e.Contraseña)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Rol)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Usuario)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<Odontograma>(entity =>
        {
            entity.ToTable("Odontograma");

            entity.Property(e => e.Abajo11)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo12)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo13)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo14)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo15)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo16)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo17)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo18)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo21)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo22)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo23)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo24)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo25)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo26)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo27)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo28)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo31)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo32)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo33)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo34)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo35)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo36)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo37)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo38)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo41)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo42)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo43)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo44)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo45)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo46)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo47)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo48)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba11)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba12)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba13)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba14)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba15)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba16)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba17)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba18)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba21)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba22)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba23)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba24)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba25)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba26)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba27)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba28)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba31)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba32)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba33)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba34)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba35)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba36)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba37)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba38)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba41)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba42)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba43)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba44)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba45)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba46)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba47)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba48)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro11)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro12)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro13)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro14)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro15)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro16)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro17)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro18)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro21)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro22)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro23)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro24)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro25)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro26)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro27)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro28)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro31)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro32)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro33)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro34)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro35)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro36)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro37)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro38)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro41)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro42)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro43)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro44)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro45)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro46)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro47)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro48)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color11)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color12)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color13)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color14)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color15)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color16)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color17)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color18)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color21)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color22)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color23)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color24)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color25)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color26)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color27)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color28)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color31)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color32)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color33)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color34)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color35)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color36)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color37)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color38)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color41)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color42)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color43)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color44)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color45)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color46)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color47)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color48)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha11)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha12)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha13)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha14)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha15)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha16)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha17)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha18)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha21)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha22)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha23)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha24)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha25)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha26)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha27)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha28)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha31)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha32)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha33)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha34)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha35)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha36)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha37)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha38)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha41)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha42)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha43)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha44)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha45)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha46)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha47)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha48)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado11)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado12)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado13)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado14)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado15)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado16)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado17)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado18)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado21)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado22)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado23)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado24)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado25)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado26)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado27)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado28)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado31)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado32)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado33)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado34)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado35)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado36)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado37)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado38)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado41)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado42)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado43)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado44)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado45)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado46)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado47)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado48)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda11)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda12)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda13)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda14)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda15)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda16)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda17)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda18)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda21)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda22)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda23)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda24)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda25)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda26)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda27)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda28)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda31)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda32)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda33)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda34)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda35)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda36)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda37)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda38)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda41)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda42)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda43)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda44)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda45)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda46)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda47)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda48)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<OdontrogramaNiño>(entity =>
        {
            entity.ToTable("OdontrogramaNiño");

            entity.Property(e => e.Abajo51)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo52)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo53)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo54)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo55)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo61)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo62)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo63)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo64)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo65)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo71)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo72)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo73)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo74)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo75)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo81)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo82)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo83)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo84)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Abajo85)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba51)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba52)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba53)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba54)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba55)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba61)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba62)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba63)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba64)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba65)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba71)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba72)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba73)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba74)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba75)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba81)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba82)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba83)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba84)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Arriba85)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro51)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro52)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro53)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro54)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro55)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro61)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro62)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro63)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro64)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro65)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro71)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro72)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro73)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro74)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro75)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro81)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro82)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro83)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro84)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Centro85)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color51)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color52)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color53)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color54)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color55)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color61)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color62)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color63)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color64)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color65)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color71)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color72)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color73)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color74)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color75)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color81)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color82)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color83)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color84)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color85)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha51)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha52)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha53)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha54)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha55)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha61)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha62)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha63)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha64)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha65)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha71)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha72)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha73)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha74)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha75)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha81)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha82)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha83)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha84)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Derecha85)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado51)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado52)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado53)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado54)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado55)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado61)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado62)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado63)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado64)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado65)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado71)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado72)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado73)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado74)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado75)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado81)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado82)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado83)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado84)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Estado85)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda51)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda52)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda53)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda54)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda55)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda61)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda62)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda63)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda64)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda65)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda71)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda72)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda73)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda74)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda75)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda81)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda82)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda83)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda84)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Izquierda85)
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
            entity.Property(e => e.Dni)
                .HasMaxLength(8)
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
                .HasMaxLength(40)
                .IsFixedLength()
                .HasColumnName("Practica");
        });

        modelBuilder.Entity<PracticasApro>(entity =>
        {
            entity.Property(e => e.Practica)
                .HasMaxLength(30)
                .IsFixedLength();
        });

        modelBuilder.Entity<PracticasOdontograma>(entity =>
        {
            entity.ToTable("PracticasOdontograma");

            entity.Property(e => e.Color)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Practica)
                .HasMaxLength(20)
                .IsFixedLength();
        });

        modelBuilder.Entity<PracticasRealizada>(entity =>
        {
            entity.Property(e => e.Fecha).HasColumnType("date");
            entity.Property(e => e.ObraSocial)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsFixedLength();
            entity.Property(e => e.Odontologo)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Paciente)
                .HasMaxLength(30)
                .IsFixedLength();
            entity.Property(e => e.Practica)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<Turno>(entity =>
        {
            entity.Property(e => e.DiaMesAño).HasColumnType("date");
            entity.Property(e => e.Hora).HasPrecision(0);
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsFixedLength();
            entity.Property(e => e.Practica)
                .HasMaxLength(40)
                .IsFixedLength();
            entity.Property(e => e.Sobreturno)
                .HasMaxLength(2)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
