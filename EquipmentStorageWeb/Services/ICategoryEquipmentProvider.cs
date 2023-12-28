using System;
using EquipmentStorageWeb.Data.Models;
namespace EquipmentStorageWeb.Services
{
	public interface ICategoryEquipmentProvider
    {
		Task<List<CategoryEquipmentDTO>> GetCategoriesEquipment();
    }
}

