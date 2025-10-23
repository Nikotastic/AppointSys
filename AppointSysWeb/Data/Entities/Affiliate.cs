using System;
using System.Collections.Generic;
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
    // Membership card fields
    public string CardNumber { get; set; } = Guid.NewGuid().ToString("N").ToUpper();
    public string CardQrCode { get; set; } = string.Empty; // store QR payload or image path
    public DateTime CardIssuedAt { get; set; } = DateTime.UtcNow;
    public bool IsActive { get; set; } = true;

    // Additional profile fields
    public DateTime? DateOfBirth { get; set; }
    public string Address { get; set; } = string.Empty;

    // Navigation
    public ICollection<Shift> Shifts { get; set; } = new List<Shift>();
}