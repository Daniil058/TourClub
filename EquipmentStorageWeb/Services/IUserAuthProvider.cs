using System;
using EquipmentStorageWeb.Data.Models;
namespace EquipmentStorageWeb.Services
{
	public interface IUserAuthProvider
	{


        Task<UserDescription>? GetAutorization(UserAuthLogPasDTO logPasDTO);

    }
}

