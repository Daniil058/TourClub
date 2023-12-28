using System;

namespace EquipmentStorageWeb.Data.Models
{
	public class EquipmentDTO
	{
        public int Id { get; set; }
        public string Orientation { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string? PhotoPath { get; set; }
        public float? Cost_rent { get; set; }
        public string Condition { get; set; }
    }
}

