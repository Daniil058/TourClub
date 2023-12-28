using System;
using System.Net.Http.Json;
using EquipmentStorageWeb.Data.Models;
using Newtonsoft.Json;

namespace EquipmentStorageWeb.Services
{
    public class BookingProvider : IBookingProvider
    {

        private HttpClient _client;
        public BookingProvider(HttpClient client)
        {
            _client = client;
        }

        public async Task<bool?> AddBooking(BookingDTO booking)
        {
            string data = JsonConvert.SerializeObject(booking);
            StringContent httpContent = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            var response = await _client.PostAsync($"api/Booking/", httpContent);
            bool? flag = bool.Parse(await response.Content.ReadAsStringAsync());
            return flag;
        }

        public async Task<List<BookingDTOGet>> GetBooking(int userID)
        {
            return await _client.GetFromJsonAsync<List<BookingDTOGet>>($"/api/Booking/{userID}");
        }

    }

}

