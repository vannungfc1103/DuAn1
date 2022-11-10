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
    public class PhieuTraChiTietConfigurations : IEntityTypeConfiguration<PhieuTraChiTiet>
    {
        public void Configure(EntityTypeBuilder<PhieuTraChiTiet> buider)
        {
            buider.ToTable("PhieuTraChiTiet");
            buider.HasKey(x => x.Id);

            buider.Property(p => p.IdPT).IsRequired();
            buider.Property(p => p.IdSach).IsRequired();

            buider.Property(p => p.SoLuong).HasColumnName("SoLuong").HasColumnType("nvarchar(100)").IsRequired();
            buider.Property(p => p.TinhTrang).HasColumnName("TinhTrang").HasColumnType("int").IsRequired();
            buider.Property(p => p.GhiChu).HasColumnName("GhiChu").HasColumnType("nvarchar(100)").IsRequired();

            buider.HasOne(p => p.Sach).WithMany().HasForeignKey(p => p.IdSach);
            buider.HasOne(p => p.PhieuTra).WithMany().HasForeignKey(p => p.IdPT);
        }

    }
}
