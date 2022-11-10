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
    public class SachConfigurations:IEntityTypeConfiguration<Sach>
    {
        public void Configure(EntityTypeBuilder<Sach> buider)
        {
            buider.ToTable("Sach");
            buider.HasKey(x => x.Id);

            buider.Property(p => p.Name).HasColumnName("TenSach").HasColumnType("nvarchar(100)").IsRequired();
            buider.Property(p => p.TL).HasColumnName("TheLoai").HasColumnType("nvarchar(100)").IsRequired();
            buider.Property(p => p.NXB).HasColumnName("NXB").HasColumnType("nvarchar(100)").IsRequired();
            buider.Property(p => p.TG).HasColumnName("TacGia").HasColumnType("nvarchar(100)").IsRequired();
            buider.Property(p => p.SoLuong).HasColumnName("SoLuong").HasColumnType("int").IsRequired();
            buider.Property(p => p.GiaTien).HasColumnName("GiaTien").HasColumnType("money").IsRequired();
            buider.Property(p => p.GhiChu).HasColumnName("GhiChu").HasColumnType("nvarchar(100)").IsRequired();
        }
    }
}
