using System;
using System.Net.Http.Json;
using EquipmentStorageWeb.Data.Models;

namespace EquipmentStorageWeb.Services
{
	public class RoleProvider:IRoleProvider
	{
        private HttpClient _client;
        public RoleProvider(HttpClient client)
        {
            _client = client;
        }

        public Task<Role> Add(Role item)
        {
            throw new NotImplementedException();
        }

        public async Task<Role> GetOne(int id)
        {
            return await _client.GetFromJsonAsync<Role>($"/api/role/{id}");
        }

        public async Task<List<Role>>? GetRoles()
        {
            return await _client.GetFromJsonAsync<List<Role>>($"/api/role");
        }
    }
}

