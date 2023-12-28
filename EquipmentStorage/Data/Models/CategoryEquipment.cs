using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EquipmentStorage.Data.Models
{
	public class CategoryEquipment
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int Id { get; set; }
        public string Orientation { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }

        public IEnumerable<Equipment>? Equipments { get; set; }
	}
}

