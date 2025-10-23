using AppointSysWeb.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppointSysWeb.Data.Configurations;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
 public void Configure(EntityTypeBuilder<Employee> builder)
 {
 builder.HasKey(e => e.Id);

 builder.Property(e => e.Role)
 .HasMaxLength(50)
 .IsRequired(false);

 builder.Property(e => e.IsActive)
 .IsRequired();
 }
}
