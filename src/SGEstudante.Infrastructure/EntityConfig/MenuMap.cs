using Microsoft.EntityFrameworkCore;
using SGEstudante.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGEstudante.Infrastructure.EntityConfig
{
    public class MenuMap : IEntityTypeConfiguration<Menu>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Menu> builder)
        {
            builder
               .HasMany(m => m.SubMenu)
               .WithOne()
               .HasForeignKey(m => m.MenuId);
        }
    }
}
