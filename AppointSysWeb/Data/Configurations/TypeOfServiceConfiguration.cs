using AppointSysWeb.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppointSysWeb.Data.Configurations;

public class TypeOfServiceConfiguration : IEntityTypeConfiguration<TypeOfService>
{
    public void Configure(EntityTypeBuilder<TypeOfService> builder)
    {
        builder.HasKey(s => s.Id);
        
        builder.Property(s => s.Name)
            .HasMaxLength(100)
            .IsRequired();
    }
    
}