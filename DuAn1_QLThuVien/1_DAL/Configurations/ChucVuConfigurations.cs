using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _1_DAL.Configurations
{
    public class ChucVuConfigurations: IEntityTypeConfiguration<ChucVu>
    {
        public void Configure(EntityTypeBuilder<ChucVu> buider)
        {
            buider.ToTable("ChucVu");
            buider.HasKey(x => x.Id);
            buider.Property(p => p.Name).HasColumnName("TenCV").HasColumnType("nvarchar(100)").IsRequired();
        }
    }
}
