using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EquipmentStorage.Data.Models
{
	public class UserInterest
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int Id { get; set; }
		public int UserId { get; set; }
        public IEnumerable<Interest>? Interest { get; set; }

	}
}

