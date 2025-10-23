namespace AppointSysWeb.Models;

public abstract class Person(
    int id,
    string firstName,
    string lastName,
    string email,
    string phone,
    string document,
    string photo)
{
    public int Id { get; set; } = id;
    public string FirstName { get; set; } = firstName.ToLower().Trim();
    public string LastName { get; set; } = lastName.ToLower().Trim();
    public string Email { get; set; } = email.ToLower().Trim();
    public string Phone { get; set; } = phone.ToLower().Trim();
    public string Document { get; set; } = document;
    public string Photo { get; set; } = photo;
}