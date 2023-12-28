using System;

namespace EquipmentStorageWeb.Data.Models
{
	public class UserDescrDataReg
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? Patronymic { get; set; }
        public DateTime? Birthday { get; set; }
        public List<int> Interests { get; set; }
    }
}

