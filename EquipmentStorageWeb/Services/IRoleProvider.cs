using System;
using EquipmentStorageWeb.Data.Models;
namespace EquipmentStorageWeb.Services
{
	public interface IRoleProvider
	{
		Task<List<Role>> GetRoles();

		Task<Role> GetOne(int id);

        Task<Role> Add(Role item);
    }
}

