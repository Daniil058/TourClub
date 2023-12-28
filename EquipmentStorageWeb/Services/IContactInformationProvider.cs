using System;
using EquipmentStorageWeb.Data.Models;
namespace EquipmentStorageWeb.Services
{
    public interface IContactInformationProvider
    {
        public Task<ContactInformation> GetContactInformation(int id);
    }
        
}

