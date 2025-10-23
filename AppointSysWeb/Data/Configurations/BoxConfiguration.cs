using AppointSysWeb.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppointSysWeb.Data.Configurations;

public class BoxConfiguration : IEntityTypeConfiguration<Box>
{
 public void Configure(EntityTypeBuilder<Box> builder)
 {
 builder.HasKey(b => b.Id);

 builder.Property(b => b.Name)
 .IsRequired()
 .HasMaxLength(100);

 builder.HasOne(b => b.AssignedEmployee)
 .WithMany()
 .HasForeignKey(b => b.AssignedEmployeeId)
 .OnDelete(DeleteBehavior.SetNull);
 }
}
