using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace штвн.Server
{
    public partial class СайтдлякомпьютерногоклубаContext : DbContext
    {
        public СайтдлякомпьютерногоклубаContext()
        {
        }

        public СайтдлякомпьютерногоклубаContext(DbContextOptions<СайтдлякомпьютерногоклубаContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Аренда> Аренда { get; set; }
        public virtual DbSet<ДополнительныеУслуги> ДополнительныеУслуги { get; set; }
        public virtual DbSet<Оплата> Оплата { get; set; }
        public virtual DbSet<Покупатель> Покупатель { get; set; }
        public virtual DbSet<РасположениеКлуба> РасположениеКлуба { get; set; }
        public virtual DbSet<Услуга> Услуга { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=Lab116-p;Database=Сайт для компьютерного клуба;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Аренда>(entity =>
            {
                entity.HasKey(e => e.ArendaId);

                entity.Property(e => e.ArendaId)
                    .HasColumnName("arenda_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.UslugaId).HasColumnName("usluga_id");

                entity.Property(e => e.ВремяАренды).HasColumnName("Время аренды");

                entity.Property(e => e.ВремяИДатаАренды).HasColumnName("Время и дата аренды");

                entity.Property(e => e.НомерКомпьютера).HasColumnName("Номер компьютера");

                entity.HasOne(d => d.Usluga)
                    .WithMany(p => p.Аренда)
                    .HasForeignKey(d => d.UslugaId)
                    .HasConstraintName("FK_Аренда_Услуга");
            });

            modelBuilder.Entity<ДополнительныеУслуги>(entity =>
            {
                entity.HasKey(e => e.ExtraId);

                entity.ToTable("Дополнительные услуги");

                entity.Property(e => e.ExtraId)
                    .HasColumnName("extra_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.UslugaId).HasColumnName("usluga_id");

                entity.Property(e => e.ВыделятьОтдельнуюКомнату)
                    .HasColumnName("Выделять отдельную комнату?")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.СколькоМониторовНужно).HasColumnName("Сколько мониторов нужно?");

                entity.HasOne(d => d.Usluga)
                    .WithMany(p => p.ДополнительныеУслуги)
                    .HasForeignKey(d => d.UslugaId)
                    .HasConstraintName("FK_Дополнительные услуги_Услуга");
            });

            modelBuilder.Entity<Оплата>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ClubId).HasColumnName("club_id");

                entity.Property(e => e.ExtraId).HasColumnName("extra_id");

                entity.Property(e => e.НомерКарты).HasColumnName("Номер карты");

                entity.Property(e => e.НомерТелефона).HasColumnName("Номер телефона");

                entity.HasOne(d => d.Club)
                    .WithMany()
                    .HasForeignKey(d => d.ClubId)
                    .HasConstraintName("FK_Оплата_Расположение клуба");

                entity.HasOne(d => d.Extra)
                    .WithMany()
                    .HasForeignKey(d => d.ExtraId)
                    .HasConstraintName("FK_Оплата_Дополнительные услуги");
            });

            modelBuilder.Entity<Покупатель>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ДеньРожденияСегодня)
                    .HasColumnName("День рождения сегодня?")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Имя)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Фамилия)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<РасположениеКлуба>(entity =>
            {
                entity.HasKey(e => e.ClubId);

                entity.ToTable("Расположение клуба");

                entity.Property(e => e.ClubId)
                    .HasColumnName("club_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArendaId).HasColumnName("arenda_id");

                entity.Property(e => e.Адрес)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Arenda)
                    .WithMany(p => p.РасположениеКлуба)
                    .HasForeignKey(d => d.ArendaId)
                    .HasConstraintName("FK_Расположение клуба_Аренда");
            });

            modelBuilder.Entity<Услуга>(entity =>
            {
                entity.HasKey(e => e.UslugaId);

                entity.Property(e => e.UslugaId)
                    .HasColumnName("usluga_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArendaId).HasColumnName("arenda_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.Услуга)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_Услуга_Покупатель");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
