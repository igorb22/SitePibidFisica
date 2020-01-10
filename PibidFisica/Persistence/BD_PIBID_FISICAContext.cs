using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Persistence
{
    public partial class BD_PIBID_FISICAContext : DbContext
    {
        public BD_PIBID_FISICAContext()
        {
        }

        public BD_PIBID_FISICAContext(DbContextOptions<BD_PIBID_FISICAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Evento> Evento { get; set; }
        public virtual DbSet<Galeria> Galeria { get; set; }
        public virtual DbSet<Trabalho> Trabalho { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=igorb95;database=BD_PIBID_FISICA");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Evento>(entity =>
            {
                entity.HasKey(e => e.IdEvento);

                entity.ToTable("evento", "bd_pibid_fisica");

                entity.Property(e => e.IdEvento)
                    .HasColumnName("idEvento")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasColumnName("categoria")
                    .HasColumnType("enum('EXPERIMENTOTECA','MINICURSO','SIMPOSIO','PALESTRA','OFICINA','MESA REDONDA')");

                entity.Property(e => e.Cidade)
                    .IsRequired()
                    .HasColumnName("cidade")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DataFim).HasColumnName("dataFim");

                entity.Property(e => e.DataInicio).HasColumnName("dataInicio");

                entity.Property(e => e.Programa)
                    .IsRequired()
                    .HasColumnName("programa")
                    .HasColumnType("enum('PIBID','FISICA SHOW','GAEF')");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasColumnName("titulo")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Galeria>(entity =>
            {
                entity.HasKey(e => e.IdGaleria);

                entity.ToTable("galeria", "bd_pibid_fisica");

                entity.HasIndex(e => e.IdEvento)
                    .HasName("fk_Galeria_Evento_idx");

                entity.Property(e => e.IdGaleria)
                    .HasColumnName("idGaleria")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdEvento)
                    .HasColumnName("idEvento")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasColumnName("link")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEventoNavigation)
                    .WithMany(p => p.Galeria)
                    .HasForeignKey(d => d.IdEvento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Galeria_Evento");
            });

            modelBuilder.Entity<Trabalho>(entity =>
            {
                entity.HasKey(e => e.IdTrabalho);

                entity.ToTable("trabalho", "bd_pibid_fisica");

                entity.HasIndex(e => e.IdEvento)
                    .HasName("fk_Trabalhos_Evento1_idx");

                entity.Property(e => e.IdTrabalho)
                    .HasColumnName("idTrabalho")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Autores)
                    .IsRequired()
                    .HasColumnName("autores")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.IdEvento)
                    .HasColumnName("idEvento")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasColumnName("link")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasColumnName("titulo")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEventoNavigation)
                    .WithMany(p => p.Trabalho)
                    .HasForeignKey(d => d.IdEvento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Trabalhos_Evento1");
            });
        }
    }
}
