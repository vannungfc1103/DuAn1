using _1_DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Configurations
{
    public class PhieuMuonConfigurations : IEntityTypeConfiguration<PhieuMuon>
    {
        public void Configure(EntityTypeBuilder<PhieuMuon> buider)
        {
            buider.ToTable("PhieuMuon");
            buider.HasKey(x => x.Id);

            buider.Property(p => p.IdTheTV).IsRequired();
            buider.Property(p => p.IdNV).IsRequired();

            buider.Property(p => p.NgayMuon).HasColumnName("NgayMuon").HasColumnType("DateTime").IsRequired();
            buider.Property(p => p.NgayTra).HasColumnName("NgayTra").HasColumnType("DateTime").IsRequired();
            buider.Property(p => p.GhiChu).HasColumnName("GhiChu").HasColumnType("nvarchar(100)").IsRequired();

            buider.HasOne(p => p.NhanVien).WithMany().HasForeignKey(p => p.IdNV);
            buider.HasOne(p => p.TheThanhVien).WithMany().HasForeignKey(p => p.IdTheTV);
        }
    }
}
