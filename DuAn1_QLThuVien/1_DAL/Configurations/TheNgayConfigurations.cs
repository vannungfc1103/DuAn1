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
    public class TheNgayConfigurations: IEntityTypeConfiguration<TheNgay>
    {
        public void Configure(EntityTypeBuilder<TheNgay> buider)
        {
            buider.ToTable("TheNgay");
            buider.HasKey(x => x.Id);

            buider.Property(p => p.IdNV).IsRequired();
            buider.Property(p => p.StartTime).HasColumnName("StartTime").HasColumnType("DateTime").IsRequired();
            buider.Property(p => p.EndTime).HasColumnName("EndTime").HasColumnType("DateTime").IsRequired();
            buider.Property(p => p.GhiChu).HasColumnName("GhiChu").HasColumnType("nvarchar(100)").IsRequired();

            buider.HasOne(p => p.NhanVien).WithMany().HasForeignKey(p => p.IdNV);
        }
    }
}
