using System;
using System.Net.Http.Json;
using EquipmentStorageWeb.Data.Models;
using EquipmentStorageWeb.Services;
namespace EquipmentStorageWeb.Services
{
	public class ContactInformationProvider: IContactInformationProvider
    {

        private HttpClient _client;
        public ContactInformationProvider(HttpClient client)
        {
            _client = client;
        }


        public async Task<ContactInformation>? GetContactInformation(int id)
        {
            return await _client.GetFromJsonAsync<ContactInformation>($"/userauth/{id}");
        }
    }
}

