using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EquipmentStorage.Data.Models
{
    public class Booking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int Id { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime StartBookingDate { get; set; }
        public DateTime FinishBookingDate { get; set; }

        public UserDescription User { get; set; }
        public Equipment Equipment { get; set; }
        public StatusBooking StatusBooking { get; set; }
    }
}

