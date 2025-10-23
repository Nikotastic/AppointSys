using AppointSysWeb.Models;

namespace AppointSysWeb.Data.Entities;

public class Affiliate(
    int id,
    string firstName,
    string lastName,
    string email,
    string phone,
    string document,
    string photo) : Person(id, firstName, lastName, email, phone, document, photo)
{
    
}