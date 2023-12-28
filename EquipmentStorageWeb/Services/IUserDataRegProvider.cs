using System;
using EquipmentStorageWeb.Data.Models;
namespace EquipmentStorageWeb.Services
{
	public interface IUserDataRegProvider
    {
        Task<int?> AddAuthData(UserAuthDataReg dataReg);

        Task<bool?> AddUserData(UserDescrDataReg dataReg);
    }
}

