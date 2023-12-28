using System;
using System.ComponentModel.DataAnnotations.Schema;
using EquipmentStorage.Data.Models;
namespace EquipmentStorage.Data.DTOs
{
	public class IncompleteEquipmentDTO
	{
        
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string? PhotoPath { get; set; }
        public float? Cost_rent { get; set; }
        
    }
}

