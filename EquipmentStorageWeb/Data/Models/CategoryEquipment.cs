using System;

namespace EquipmentStorageWeb.Data.Models
{
	public class CategoryEquipment
	{
        public int Id { get; set; }
        public string Orientation { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }

        public IEnumerable<Equipment> Equipments { get; set; }
	}
}

