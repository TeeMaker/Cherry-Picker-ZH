using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ZH_AMRIGW.Model;

public partial class vasarlasContext : DbContext
{
    public vasarlasContext()
    {
    }

    public vasarlasContext(DbContextOptions<vasarlasContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Egyseg> Egyseg { get; set; }

    public virtual DbSet<Tetel> Tetel { get; set; }

    public virtual DbSet<Vasarlas> Vasarlas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\amrigw\\source\\repos\\ZH_AMRIGW\\ZH_AMRIGW\\vasarlasDb.mdf;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Egyseg>(entity =>
        {
            entity.HasKey(e => e.EgysegId).HasName("PK_Egysegek");

            entity.ToTable("egyseg");

            entity.Property(e => e.Nev).HasMaxLength(30);
        });

        modelBuilder.Entity<Tetel>(entity =>
        {
            entity.HasKey(e => e.TetelId).HasName("PK_Tetelek");

            entity.ToTable("tetel");

            entity.Property(e => e.EgysegFk).HasColumnName("EgysegFK");
            entity.Property(e => e.Nev).HasMaxLength(30);

            entity.HasOne(d => d.EgysegFkNavigation).WithMany(p => p.Tetel)
                .HasForeignKey(d => d.EgysegFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tetel__EgysegFK__38996AB5");
        });

        modelBuilder.Entity<Vasarlas>(entity =>
        {
            entity.HasKey(e => e.VasarlasId).HasName("PK__vasarlas__D89D1A09FB009C53");

            entity.ToTable("vasarlas");

            entity.Property(e => e.Datum).HasColumnType("date");
            entity.Property(e => e.TetelFk).HasColumnName("TetelFK");

            entity.HasOne(d => d.TetelFkNavigation).WithMany(p => p.Vasarlas)
                .HasForeignKey(d => d.TetelFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__vasarlas__TetelF__3B75D760");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
