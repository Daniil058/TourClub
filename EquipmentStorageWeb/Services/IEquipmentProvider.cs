using System;
using EquipmentStorageWeb.Data.Models;
namespace EquipmentStorageWeb.Services
{
	public interface IEquipmentProvider
	{
		Task<List<EquipmentDTO>> GetEquipments();

        Task<EquipmentMoreDTO>? GetEquipment(int id);

        Task<List<EquipmentDTO>>? GetEquipmentsWithConditionId(int id);

        Task<List<EquipmentDTO>>? GetEquipmentsWithCategoryId(int id);

        Task<List<EquipmentDTO>>? GetEquipmentsWithOrientationName(string orientation);

        Task<List<EquipmentDTO>>? GetEquipmentsWithCategoryName(string category);

        Task<List<EquipmentDTO>>? GetEquipmentsByName(string name);

        Task<Equipment> GetOne(int id);

        Task<Equipment> Add(Equipment item);
    }
}

