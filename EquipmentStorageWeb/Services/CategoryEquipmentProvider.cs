using System;
using System.Net.Http.Json;
using EquipmentStorageWeb.Data.Models;
namespace EquipmentStorageWeb.Services
{
	public class CategoryEquipmentProvider: ICategoryEquipmentProvider
    {
        private HttpClient _client;
        public CategoryEquipmentProvider(HttpClient client)
        {
            _client = client;
        }

       

        public async Task<List<CategoryEquipmentDTO>>? GetCategoriesEquipment()
        {
            return await _client.GetFromJsonAsync<List<CategoryEquipmentDTO>>($"/api/categoryequipment/dto");
        }
    }
}

