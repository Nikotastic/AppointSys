using AppointSysWeb.Models;

namespace AppointSysWeb.Data.Entities;

public class Employee(
 int id,
 string firstName,
 string lastName,
 string email,
 string phone,
 string document,
 string photo,
 string role,
 bool isActive = true) : Person(id, firstName, lastName, email, phone, document, photo)
{
 public string Role { get; set; } = role;
 public bool IsActive { get; set; } = isActive;
}
