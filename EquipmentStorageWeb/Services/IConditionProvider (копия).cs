using System;
using EquipmentStorageWeb.Data.Models;
namespace EquipmentStorageWeb.Services
{
	public interface IConditionProvider
	{
		Task<List<ConditionDTO>> GetConditions();
    }
}

