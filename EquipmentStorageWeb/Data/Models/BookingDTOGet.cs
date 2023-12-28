using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EquipmentStorageWeb.Data.Models
{
    public class BookingDTOGet
    {
        public DateOnly StartBookingDate { get; set; }
        public DateOnly FinishBookingDate { get; set; }
        public int EquipmentNumber { get; set; }
        public string EquipmentType { get; set; }
        public string EquipmentName { get; set; }
    }
}

