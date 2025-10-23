namespace AppointSysWeb.Data.Entities;

public class Box
{
 public int Id { get; set; }
 public string Name { get; set; } = string.Empty;
 public bool IsOpen { get; set; } // Indicates if the box is currently open
    public int? AssignedEmployeeId { get; set; }
 public Employee? AssignedEmployee { get; set; }
}
