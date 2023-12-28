using System;

namespace EquipmentStorageWeb.Data.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<UserAuth>? Users { get; set; }
    }
}

