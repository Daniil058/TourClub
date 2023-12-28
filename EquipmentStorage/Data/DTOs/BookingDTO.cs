using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EquipmentStorage.Data.Models
{
    public class BookingDTO
    {
        public DateTime RequestDate { get; set; }
        public DateTime StartBookingDate { get; set; }
        public DateTime FinishBookingDate { get; set; }

        public int UserId { get; set; }
        public int EquipmentId { get; set; }
    }
}

