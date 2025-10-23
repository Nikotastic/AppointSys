using System.ComponentModel.DataAnnotations;

namespace AppointSysWeb.Data.Entities;

public class TypeOfService
{
    public int Id { get; set; }

    [Required(ErrorMessage = "The name is required")]
    [MinLength(4, ErrorMessage = "The name must be at least 4 characters long")]
    public string Name { get; set; } = string.Empty;
}
