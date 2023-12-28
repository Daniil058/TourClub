using System;

namespace EquipmentStorageWeb.Data.Models
{
	public class UserDescription
	{
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? Patronymic { get; set; }
        public DateTime? Birthday { get; set; }
        public Role? Role { get; set; }
        public List<Interest>? Interests { get; set; }
        public IEnumerable<Booking>? Bookings { get; set; }

    }
}

