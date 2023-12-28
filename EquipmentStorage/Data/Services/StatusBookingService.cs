using System;
using EquipmentStorage.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EquipmentStorage.Data.Services
{
	public class StatusBookingService
	{
        private EquipmentStorageContext _context;
        public StatusBookingService(EquipmentStorageContext context)
        {
            _context = context;
        }

        public async Task<List<StatusBooking>> GetStatusBookings()
        {
            var result = await _context.StatusBooking.ToListAsync();
            return await Task.FromResult(result);
        }

        public async Task<StatusBooking?> AddStatusBooking(StatusBooking statusBooking)
        {
            StatusBooking nstatusBooking = new StatusBooking
            {
                Name = statusBooking.Name,
            };
            var result = _context.StatusBooking.Add(nstatusBooking);
            await _context.SaveChangesAsync();
            return await Task.FromResult(result.Entity);
        }
    }
}

