using System.ComponentModel.DataAnnotations;

namespace AppointSysWeb.Data.Entities;

public sealed class Shift(
    int id,
    string number,
    DateTime requestDate,
    DateTime dateAttention,
    int statusId,
    Status status,
    int typesOfServiceId,
    TypeOfService typesOfService,
    int affiliateId,
    Affiliate affiliate)
{
    public int Id { get; set; } = id;
    public string Number { get; set; } = number;
    public DateTime RequestDate { get; set; } = requestDate;
    public DateTime DateAttention { get; set; } = dateAttention;
    public int StatusId { get; set; } = statusId;
    public Status Status { get; set; } = status;
    public int TypesOfServiceId { get; set; } = typesOfServiceId;
    public TypeOfService TypesOfService { get; set; } = typesOfService;
    public int AffiliateId { get; set; } = affiliateId;
    public Affiliate Affiliate { get; set; } = affiliate;

    // Indicates whether the shift has been archived during a reset operation
    public bool IsArchived { get; set; } = false;

    // Box (service desk/counter) where the shift will be attended
    public int? BoxId { get; set; }
    public Box? Box { get; set; }

    // Employee who served this shift (optional)
    public int? ServedByEmployeeId { get; set; }
    public Employee? ServedByEmployee { get; set; }

    public override string ToString()
    {
        return $"Turno N°{Number} - Servicio: {TypesOfService} - Estado: {Status}";
    }

}

