using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Examen.Model;

public partial class VlasenkoDemoExContext : DbContext
{
    public VlasenkoDemoExContext()
    {
    }

    public VlasenkoDemoExContext(DbContextOptions<VlasenkoDemoExContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cartum> Carta { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Comnatum> Comnata { get; set; }

    public virtual DbSet<Dogovor> Dogovors { get; set; }

    public virtual DbSet<Oboznachenie> Oboznachenies { get; set; }

    public virtual DbSet<TipNomera> TipNomeras { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=hqvla3302s01\\KITP;Initial Catalog=Vlasenko_DemoEx;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cartum>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.ToTable("Client");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Cvartira).HasMaxLength(255);
            entity.Property(e => e.DataRozdeniya).HasColumnType("datetime");
            entity.Property(e => e.Dom).HasMaxLength(255);
            entity.Property(e => e.Familiya).HasMaxLength(255);
            entity.Property(e => e.Gorod).HasMaxLength(255);
            entity.Property(e => e.IdCarta).HasColumnName("ID_Carta");
            entity.Property(e => e.IdTipNomera).HasColumnName("ID_TipNomera");
            entity.Property(e => e.Imya).HasMaxLength(255);
            entity.Property(e => e.Otchestvo).HasMaxLength(255);
            entity.Property(e => e.Pol).HasMaxLength(255);
            entity.Property(e => e.Ylica).HasMaxLength(255);

            entity.HasOne(d => d.IdCartaNavigation).WithMany(p => p.Clients)
                .HasForeignKey(d => d.IdCarta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Client_Carta");

            entity.HasOne(d => d.IdTipNomeraNavigation).WithMany(p => p.Clients)
                .HasForeignKey(d => d.IdTipNomera)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Client_TipNomera");
        });

        modelBuilder.Entity<Comnatum>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Cena).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Idoboznachenie).HasColumnName("IDOboznachenie");
            entity.Property(e => e.IdtipNomera).HasColumnName("IDTipNomera");

            entity.HasOne(d => d.IdoboznachenieNavigation).WithMany(p => p.Comnata)
                .HasForeignKey(d => d.Idoboznachenie)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Comnata_Oboznachenie");

            entity.HasOne(d => d.IdtipNomeraNavigation).WithMany(p => p.Comnata)
                .HasForeignKey(d => d.IdtipNomera)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Comnata_TipNomera");
        });

        modelBuilder.Entity<Dogovor>(entity =>
        {
            entity.ToTable("Dogovor");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataBiezda).HasColumnType("datetime");
            entity.Property(e => e.DataDogovora).HasColumnType("datetime");
            entity.Property(e => e.DataZaezda).HasColumnType("datetime");
            entity.Property(e => e.SymmaOplati).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<Oboznachenie>(entity =>
        {
            entity.ToTable("Oboznachenie");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<TipNomera>(entity =>
        {
            entity.ToTable("TipNomera");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
