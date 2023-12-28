using System;

namespace EquipmentStorageWeb.Data.Models
{
	public class Condition
	{
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<Equipment>? Equipments { get; set; }
    }
}

