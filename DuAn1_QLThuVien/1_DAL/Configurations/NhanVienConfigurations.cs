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
    public class NhanVienConfigurations : IEntityTypeConfiguration<NhanVien>
    {
        public void Configure(EntityTypeBuilder<NhanVien> buider)
        {
            buider.ToTable("NhanVien");
            buider.HasKey(x => x.Id);

            buider.Property(p=>p.IdCV).IsRequired();
            buider.Property(p => p.Name).HasColumnName("TenNhanVien").HasColumnType("nvarchar(100)").IsRequired();
            buider.Property(p => p.DiaChi).HasColumnName("DiaChi").HasColumnType("nvarchar(100)").IsRequired();
            buider.Property(p => p.SDT).HasColumnName("SDT").HasColumnType("char(10)").IsRequired();
            buider.Property(p => p.NgaySinh).HasColumnName("NgaySinh").HasColumnType("DateTime").IsRequired();

            buider.HasOne(p => p.ChucVu).WithMany().HasForeignKey(p=>p.IdCV);
        }
    }
}
