using System;
using System.Net.Http.Json;
using EquipmentStorageWeb.Data.Models;
using Newtonsoft.Json;

namespace EquipmentStorageWeb.Services
{
	public class UserDataRegProvider : IUserDataRegProvider
	{

		private HttpClient _client;
		public UserDataRegProvider(HttpClient client)
		{
			_client = client;
		}

		public async Task<int?> AddAuthData(UserAuthDataReg dataReg)
		{
            string data = JsonConvert.SerializeObject(dataReg);
			StringContent httpContent = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
			var response = await _client.PostAsync($"api/UserAuth/registration", httpContent);
			if (response.Content is null)
				return -1;
            int? id = int.Parse(await response.Content.ReadAsStringAsync());
			return id;
		}

		
		public async Task<bool?> AddUserData(UserDescrDataReg dataReg)
		{
			string data = JsonConvert.SerializeObject(dataReg);
			StringContent httpContent = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
			var response = await _client.PostAsync($"api/UserDescription/registration", httpContent);
			bool? flag = bool.Parse(await response.Content.ReadAsStringAsync());
            return flag;
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

