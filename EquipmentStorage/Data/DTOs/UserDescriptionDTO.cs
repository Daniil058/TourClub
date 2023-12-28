using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EquipmentStorage.Data.Models
{
	public class UserDescriptionDTO
	{
		
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? Patronymic { get; set; }
        public DateTime? Birthday { get; set; }
        public int[] Interests { get; set; }
        
    }
}

