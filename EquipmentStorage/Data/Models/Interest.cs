using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EquipmentStorage.Data.Models
{
	public class Interest
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int Id { get; set; }
		public string Name { get; set; }

        public IEnumerable<UserDescription> Users { get; set; }
	}
}

