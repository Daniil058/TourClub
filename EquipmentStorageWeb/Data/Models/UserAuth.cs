using System;

namespace EquipmentStorageWeb.Data.Models
{
    public class UserAuth
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public Role Role { get; set; }

    }
    
}

