using System;

namespace EquipmentStorage.Data.Models
{
    public class UserAuthDataReg
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
    }
    
}

