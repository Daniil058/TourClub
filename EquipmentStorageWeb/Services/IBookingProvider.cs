using System;
using EquipmentStorageWeb.Data.Models;
namespace EquipmentStorageWeb.Services
{
	public interface IBookingProvider
    {
		Task<bool?> AddBooking(BookingDTO booking);

        Task<List<BookingDTOGet>> GetBooking(int userID);
    }
}

