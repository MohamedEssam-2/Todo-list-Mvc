using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer.Models;
using Data_Access_Layer.Models.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data_Access_Layer.Data.Configurations
{
    public class TodoConfiguration : IEntityTypeConfiguration<Todo>
    {
        public void Configure(EntityTypeBuilder<Todo> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Title)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(t => t.Status)
                   .HasConversion<string>()
                   .HasDefaultValue(Status.Pending);

            builder.Property(t => t.Priority)
                   .HasConversion<string>();

            builder.Property(t => t.CreatedDate)
                   .HasDefaultValueSql("GETUTCDATE()");

            builder.HasIndex(t => t.Status);
        }
    }
}
