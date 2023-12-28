using System;
using System.Net.Http.Json;
using EquipmentStorageWeb.Data.Models;
using Newtonsoft.Json;

namespace EquipmentStorageWeb.Services
{
	public class UserAuthProvider:IUserAuthProvider
	{

        private HttpClient _client;
        public UserAuthProvider(HttpClient client)
        {
            _client = client;
        }

        public async Task<UserDescription>? GetAutorization(UserAuthLogPasDTO logPasDTO)
		{
            string data = JsonConvert.SerializeObject(logPasDTO);
            StringContent httpContent = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            var response = await _client.PostAsync($"/logging", httpContent);
            UserDescription user = await response.Content.ReadFromJsonAsync<UserDescription>();
            return await Task.FromResult(user);
        }

  

    }
}

