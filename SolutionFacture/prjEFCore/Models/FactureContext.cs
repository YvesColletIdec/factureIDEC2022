using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace prjEFCore.Models
{
    public partial class FactureContext : DbContext
    {
        public FactureContext()
        {
        }

        public FactureContext(DbContextOptions<FactureContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Categorie> Categories { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Facture> Factures { get; set; }
        public virtual DbSet<LigneFacture> LigneFactures { get; set; }
        public virtual DbSet<Utilisateur> Utilisateurs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Article>(entity =>
            {
                entity.ToTable("Article");

                entity.Property(e => e.Commentaire)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Designation)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EstActif)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Prix).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.Categorie)
                    .WithMany(p => p.Articles)
                    .HasForeignKey(d => d.CategorieId)
                    .HasConstraintName("FK_Article_Categorie");
            });

            modelBuilder.Entity<Categorie>(entity =>
            {
                entity.ToTable("Categorie");

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("Client");

                entity.Property(e => e.Adresse)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Localite)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("localite");

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Npa)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("npa");

                entity.Property(e => e.Prenom)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Facture>(entity =>
            {
                entity.ToTable("Facture");

                entity.Property(e => e.DateFacture).HasColumnType("datetime");

                entity.Property(e => e.NumFacture)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Factures)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("Facture_fk0");
            });

            modelBuilder.Entity<LigneFacture>(entity =>
            {
                entity.ToTable("LigneFacture");

                entity.Property(e => e.PrixUntaire).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.Article)
                    .WithMany(p => p.LigneFactures)
                    .HasForeignKey(d => d.ArticleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("LigneFacture_fk1");

                entity.HasOne(d => d.Facture)
                    .WithMany(p => p.LigneFactures)
                    .HasForeignKey(d => d.FactureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("LigneFacture_fk0");
            });

            modelBuilder.Entity<Utilisateur>(entity =>
            {
                entity.ToTable("Utilisateur");

                entity.Property(e => e.EstActif)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MotDePasse)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumEmploye)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
