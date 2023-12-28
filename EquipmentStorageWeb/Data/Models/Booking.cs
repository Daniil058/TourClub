using System;

namespace EquipmentStorageWeb.Data.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime StartBookingDate { get; set; }
        public DateTime FinishBookingDate { get; set; }

        public UserDescription User { get; set; }
        public Equipment Equipment { get; set; }
        public StatusBooking StatusBooking { get; set; }
    }
}

