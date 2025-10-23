// C#
namespace AppointSysWeb.Data.Entities
{
    public class Shift
    {
        public int Id { get; private set; }
        public string Number { get; private set; } = null!;
        public DateTime RequestDate { get; private set; }
        public DateTime DateAttention { get; private set; }

        public int StatusId { get; private set; }
        public Status? Status { get; private set; }

        public int TypesOfServiceId { get; private set; }
        public TypeOfService? TypesOfService { get; private set; }

        public int AffiliateId { get; private set; }
        public Affiliate? Affiliate { get; private set; }

        public int? BoxId { get; private set; }
        public Box? Box { get; private set; }

        public int? ServedByEmployeeId { get; private set; }
        public Employee? ServedByEmployee { get; private set; }

        // Constructor requerido por EF Core
        protected Shift() { }

        // Constructor de dominio: solo propiedades mapeables (escalars)
        public Shift(int id, string number, DateTime requestDate, DateTime dateAttention,
            int statusId, int typesOfServiceId, int affiliateId)
        {
            Id = id;
            Number = number;
            RequestDate = requestDate;
            DateAttention = dateAttention;
            StatusId = statusId;
            TypesOfServiceId = typesOfServiceId;
            AffiliateId = affiliateId;
        }
    }
}