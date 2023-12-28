using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EquipmentStorage.Data.Models
{
	public class UserDescription
	{
		
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? Patronymic { get; set; }
        public DateTime? Birthday { get; set; }
        public Role Role { get; set; }
        public List<Interest>? Interests { get; set; }
        public IEnumerable<Booking>? Bookings { get; set; }
    }
}

