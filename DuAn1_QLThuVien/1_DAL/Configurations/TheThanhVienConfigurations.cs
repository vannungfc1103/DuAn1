using _1_DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Configurations
{
    public class TheThanhVienConfigurations : IEntityTypeConfiguration<TheThanhVien>
    {
        public void Configure(EntityTypeBuilder<TheThanhVien> buider)
        {
            buider.ToTable("TheThanhVien");
            buider.HasKey(x => x.Id);

            buider.Property(p => p.TenThanhVien).HasColumnName("TenThanhVien").HasColumnType("nvarchar(100)").IsRequired();
            buider.Property(p => p.NgayDangKi).HasColumnName("NgayDangKi").HasColumnType("DateTime").IsRequired();
            buider.Property(p => p.NgayHetHan).HasColumnName("NgayHetHan").HasColumnType("DateTime").IsRequired();
            buider.Property(p => p.SDT).HasColumnName("SDT").HasColumnType("char(10)").IsRequired();
            buider.Property(p => p.DiaChi).HasColumnName("SDT").HasColumnType("nvarchar(100)").IsRequired();
            buider.Property(p => p.NgaySinh).HasColumnName("SDT").HasColumnType("DateTime").IsRequired();
            buider.Property(p => p.GhiChu).HasColumnName("SDT").HasColumnType("nvarchar(100)").IsRequired();
        }
    }
}
