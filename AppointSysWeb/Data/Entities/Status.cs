using System.ComponentModel.DataAnnotations;

namespace AppointSysWeb.Data.Entities;

public class Status
{
    public int Id { get; set; }
    public enum State
    {
        [Display(Name = "Pending")]
        Pending,

        [Display(Name = "Attended")]
        Attended,

        [Display(Name = "Cancelled")]
        Cancelled
    }
}