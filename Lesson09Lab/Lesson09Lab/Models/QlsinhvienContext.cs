using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Lesson09Lab.Models;

public partial class QlsinhvienContext : DbContext
{
    public QlsinhvienContext()
    {
    }

    public QlsinhvienContext(DbContextOptions<QlsinhvienContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Ketqua> Ketquas { get; set; }

    public virtual DbSet<Khoa> Khoas { get; set; }

    public virtual DbSet<MonHoc> MonHocs { get; set; }

    public virtual DbSet<SinhVien> SinhViens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DELL;Database=QLSINHVIEN;uid=sa;pwd=123456;MultipleActiveResultSets=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ketqua>(entity =>
        {
            entity.HasKey(e => new { e.MaSv, e.MaMh }).HasName("Prk_MaSV_MAMH");

            entity.ToTable("Ketqua");

            entity.Property(e => e.MaSv)
                .HasMaxLength(3)
                .HasColumnName("MaSV");
            entity.Property(e => e.MaMh)
                .HasMaxLength(2)
                .HasColumnName("MaMH");

            entity.HasOne(d => d.MaMhNavigation).WithMany(p => p.Ketquas)
                .HasForeignKey(d => d.MaMh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Frk_KetQua_Mamh");

            entity.HasOne(d => d.MaSvNavigation).WithMany(p => p.Ketquas)
                .HasForeignKey(d => d.MaSv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Frk_KetQua_Makh");
        });

        modelBuilder.Entity<Khoa>(entity =>
        {
            entity.HasKey(e => e.MaKh).HasName("Prk_KHOA_khoa");

            entity.ToTable("Khoa");

            entity.Property(e => e.MaKh)
                .HasMaxLength(2)
                .HasColumnName("MaKH");
            entity.Property(e => e.TenKh)
                .HasMaxLength(50)
                .HasColumnName("TenKH");
        });

        modelBuilder.Entity<MonHoc>(entity =>
        {
            entity.HasKey(e => e.MaMh).HasName("Prk_MONHOC_MaMH");

            entity.ToTable("MonHoc");

            entity.Property(e => e.MaMh)
                .HasMaxLength(2)
                .HasColumnName("MaMH");
            entity.Property(e => e.TenMh)
                .HasMaxLength(50)
                .HasColumnName("TenMH");
        });

        modelBuilder.Entity<SinhVien>(entity =>
        {
            entity.HasKey(e => e.MaSv).HasName("Prk_SINHVIEN_MaSV");

            entity.ToTable("SinhVien");

            entity.Property(e => e.MaSv)
                .HasMaxLength(3)
                .HasColumnName("MaSV");
            entity.Property(e => e.HoSv)
                .HasMaxLength(15)
                .HasColumnName("HoSV");
            entity.Property(e => e.MaKh)
                .HasMaxLength(2)
                .HasColumnName("MaKH");
            entity.Property(e => e.NgaySinh).HasColumnType("smalldatetime");
            entity.Property(e => e.NoiSinh).HasMaxLength(100);
            entity.Property(e => e.TenSv)
                .HasMaxLength(7)
                .HasColumnName("TenSV");

            entity.HasOne(d => d.MaKhNavigation).WithMany(p => p.SinhViens)
                .HasForeignKey(d => d.MaKh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Frk_SINHVIEN_Makh");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
