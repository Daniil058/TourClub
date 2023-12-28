using System;
using System.Net.Http.Json;
using EquipmentStorageWeb.Data.Models;
namespace EquipmentStorageWeb.Services
{
	public class EquipmentProvider:IEquipmentProvider
	{
        private HttpClient _client;
        public EquipmentProvider(HttpClient client)
        {
            _client = client;
        }

        public Task<Equipment> Add(Equipment item)
        {
            throw new NotImplementedException();
        }

        public async Task<Equipment>? GetOne(int id)
        {
            return await _client.GetFromJsonAsync<Equipment>($"/api/equipment/{id}");
        }

        public async Task<List<EquipmentDTO>>? GetEquipments()
        {
            return await _client.GetFromJsonAsync<List<EquipmentDTO>>($"/api/equipment");
        }

        public async Task<EquipmentMoreDTO>? GetEquipment(int id)
        {
            return await _client.GetFromJsonAsync<EquipmentMoreDTO>($"/api/equipment/one/{id}");
        }

            public async Task<List<EquipmentDTO>>? GetEquipmentsWithConditionId(int id)
        {
            return await _client.GetFromJsonAsync<List<EquipmentDTO>>($"/api/equipment/condition/{id}");
        }

        public async Task<List<EquipmentDTO>>? GetEquipmentsWithCategoryId(int id)
        {
            return await _client.GetFromJsonAsync<List<EquipmentDTO>>($"/api/equipment/category/{id}");
        }

        public async Task<List<EquipmentDTO>>? GetEquipmentsWithOrientationName(string orientation)
        {
            return await _client.GetFromJsonAsync<List<EquipmentDTO>>($"/api/equipment/category/orientation/{orientation}");
        }
        public async Task<List<EquipmentDTO>>? GetEquipmentsWithCategoryName(string category)
        {
            return await _client.GetFromJsonAsync<List<EquipmentDTO>>($"/api/equipment/category/category/{category}");
        }
        public async Task<List<EquipmentDTO>>? GetEquipmentsByName(string name)
        {
            return await _client.GetFromJsonAsync<List<EquipmentDTO>>($"/api/equipment/{name}");
        }



    }
}

