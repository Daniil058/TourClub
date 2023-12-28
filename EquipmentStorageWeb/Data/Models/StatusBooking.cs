using System;

namespace EquipmentStorageWeb.Data.Models
{
	public class StatusBooking
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<Booking>? Bookings { get; set; } 
    }
}

