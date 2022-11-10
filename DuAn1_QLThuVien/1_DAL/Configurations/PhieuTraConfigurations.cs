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
    public class PhieuTraConfigurations:IEntityTypeConfiguration<PhieuTra>
    {
        public void Configure(EntityTypeBuilder<PhieuTra> buider)
        {
            buider.ToTable("PhieuTra");
            buider.HasKey(x => x.Id);

            buider.Property(p => p.IdPM).IsRequired();

            buider.Property(p => p.NgayTra).HasColumnName("NgayTra").HasColumnType("DateTime").IsRequired();
            buider.Property(p => p.GhiChu).HasColumnName("GhiChu").HasColumnType("nvarchar(100)").IsRequired();

            buider.HasOne(p => p.PhieuMuon).WithMany().HasForeignKey(p => p.IdPM);
        }
    }
}
