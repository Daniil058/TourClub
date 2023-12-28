using System;
using System.Net.Http.Json;
using EquipmentStorageWeb.Data.Models;
namespace EquipmentStorageWeb.Services
{
	public class ConditionProvider:IConditionProvider
	{
        private HttpClient _client;
        public ConditionProvider(HttpClient client)
        {
            _client = client;
        }

       

        public async Task<List<ConditionDTO>>? GetConditions()
        {
            return await _client.GetFromJsonAsync<List<ConditionDTO>>($"/api/condition/dto");
        }
    }
}

