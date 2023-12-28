using System;

namespace EquipmentStorageWeb.Data.Models
{
	public class Equipment
	{
        public int Id { get; set; }
        public CategoryEquipment CategoryEquipment { get; set; }
        public string Name { get; set; }
        public int InventoryNumber { get; set; }
        public string? Color { get; set; }
        public string? Property1 { get; set; }
        public string? Property2 { get; set; }
        public string? PhotoPath { get; set; }
        public string? Producer { get; set; }
        public float? Weight { get; set; }
        public float? Cost { get; set; }
        public float? Cost_rent { get; set; }
        public DateTime? ProductionDate { get; set; }
        public string? Description { get; set; }
        public Condition Condition { get; set; }
        public string? Problems { get; set; }
        public string StorageLocation { get; set; }

    }
}

