using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace штвн.Server
{
    public partial class _20ПИ32ДПолярушОлегContext : DbContext
    {
        public _20ПИ32ДПолярушОлегContext()
        {
        }

        public _20ПИ32ДПолярушОлегContext(DbContextOptions<_20ПИ32ДПолярушОлегContext> options)
            : base(options)
        {
        }

        public virtual DbSet<InformationAboutDonation> InformationAboutDonation { get; set; }
        public virtual DbSet<ИнформацияОИгре> ИнформацияОИгре { get; set; }
        public virtual DbSet<ИнформацияОКомпании> ИнформацияОКомпании { get; set; }
        public virtual DbSet<ИнформацияОСборе> ИнформацияОСборе { get; set; }
        public virtual DbSet<ПрофильПользователя> ПрофильПользователя { get; set; }
        public virtual DbSet<ПрофильПользователя1> ПрофильПользователя1 { get; set; }
        public virtual DbSet<РегистрацияНаСайте> РегистрацияНаСайте { get; set; }
        public virtual DbSet<РегистрацияНаСайте1> РегистрацияНаСайте1 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=Lab116-p;Database=20ПИ3-2Д Поляруш Олег;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InformationAboutDonation>(entity =>
            {
                entity.HasKey(e => e.InfId);

                entity.ToTable("Information about donation");

                entity.Property(e => e.InfId)
                    .HasColumnName("inf_id")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.HeadSOfCompany)
                    .HasColumnName("[Head(s) of company")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ИнформацияОИгре>(entity =>
            {
                entity.HasKey(e => e.InfId);

                entity.ToTable("Информация о игре");

                entity.Property(e => e.InfId)
                    .HasColumnName("inf_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Жанр)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.КраткоеОписаниеИгры)
                    .HasColumnName("Краткое описание игры")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Название)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Теги)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Inf)
                    .WithOne(p => p.ИнформацияОИгре)
                    .HasForeignKey<ИнформацияОИгре>(d => d.InfId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Информация о игре_Информация о компании");
            });

            modelBuilder.Entity<ИнформацияОКомпании>(entity =>
            {
                entity.HasKey(e => e.InfId);

                entity.ToTable("Информация о компании");

                entity.Property(e => e.InfId)
                    .HasColumnName("inf_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ГлаваЫСтудии)
                    .HasColumnName("Глава(ы) студии")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ДатаОснования)
                    .HasColumnName("Дата основания")
                    .HasColumnType("date");

                entity.Property(e => e.КоличествоСотрудников).HasColumnName("Количество сотрудников");

                entity.Property(e => e.Название)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Страна)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ИнформацияОСборе>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Информация о сборе");

                entity.Property(e => e.MoneyId).HasColumnName("money_id");

                entity.Property(e => e.БонусыПриПревышенииНужнойСуммы)
                    .HasColumnName("Бонусы при превышении нужной суммы")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.НужнаяСумма).HasColumnName("Нужная сумма");

                entity.HasOne(d => d.Money)
                    .WithMany()
                    .HasForeignKey(d => d.MoneyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Информация о сборе_Информация о игре");
            });

            modelBuilder.Entity<ПрофильПользователя>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Профиль пользователя");

                entity.Property(e => e.RegId).HasColumnName("reg.id");

                entity.Property(e => e.Ник)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ФотоПрофиля)
                    .HasColumnName("Фото профиля")
                    .HasColumnType("image");
            });

            modelBuilder.Entity<ПрофильПользователя1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Профиль пользователя.");

                entity.Property(e => e.RegId).HasColumnName("reg_id");

                entity.Property(e => e.ФотоПрофиля)
                    .HasColumnName("Фото профиля")
                    .HasColumnType("image");

                entity.HasOne(d => d.Reg)
                    .WithMany()
                    .HasForeignKey(d => d.RegId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Профиль пользователя._Регистрация на сайте.");
            });

            modelBuilder.Entity<РегистрацияНаСайте>(entity =>
            {
                entity.HasKey(e => e.RegId);

                entity.ToTable("Регистрация на сайте");

                entity.Property(e => e.RegId)
                    .HasColumnName("reg_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Имя)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Ник)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<РегистрацияНаСайте1>(entity =>
            {
                entity.HasKey(e => e.RegId);

                entity.ToTable("Регистрация на сайте.");

                entity.Property(e => e.RegId)
                    .HasColumnName("reg_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EMailИлиТелефон).HasColumnName("e-mail или телефон");

                entity.Property(e => e.ВашаСтудия)
                    .HasColumnName("Ваша студия")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Имя)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ник)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Пароль)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ПодтверждениеПароля)
                    .IsRequired()
                    .HasColumnName("Подтверждение пароля")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Фамилия)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
