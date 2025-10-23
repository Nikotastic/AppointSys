using AppointSysWeb.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppointSysWeb.Data.Configurations;

public class ShiftConfiguration : IEntityTypeConfiguration<Shift>
{
    public void Configure(EntityTypeBuilder<Shift> builder)
    {
        builder.HasKey(s => s.Id);
        
        builder.Property(s => s.Number)
            .HasMaxLength(50)
            .IsRequired();
        
        builder.Property(s => s.RequestDate)
            .IsRequired();
        
        builder.Property(s => s.DateAttention)
            .IsRequired(false);
        
        builder.HasOne(s => s.Status)
            .WithMany()
            .HasForeignKey(s => s.StatusId);
        
        builder.HasOne(s => s.TypesOfService)
            .WithMany()
            .HasForeignKey(s => s.TypesOfServiceId);
        
        builder.HasOne(s => s.Affiliate)
            .WithMany()
            .HasForeignKey(s => s.AffiliateId);
    }
}