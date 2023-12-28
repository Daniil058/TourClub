using System;
using EquipmentStorage.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EquipmentStorage.Data.Services
{
    public class BookingService
    {
        private EquipmentStorageContext _context;
        public BookingService(EquipmentStorageContext context)
        {
            _context = context;
        }

        public async Task<List<Booking>> GetBookings()
        {
            var result = await _context.Booking.Include(b => b.Equipment).Include(b => b.User).Include(b => b.StatusBooking).ToListAsync();
            return await Task.FromResult(result);
        }

        public async Task<List<BookingDTOGet>> GetBooking(int id)
        {
            List<Booking> result = await _context.Booking.Include(b => b.Equipment).Include(b => b.User).Include(b => b.StatusBooking).ToListAsync();

            List<BookingDTOGet> bookings = new List<BookingDTOGet>();

            result.ForEach(r => bookings.Add(new BookingDTOGet()
            {
                FinishBookingDate = DateOnly.FromDateTime(r.FinishBookingDate),
                StartBookingDate = DateOnly.FromDateTime(r.StartBookingDate),
                EquipmentName = r.Equipment.Name,
                EquipmentNumber = r.Equipment.InventoryNumber,
                EquipmentType = r.Equipment.CategoryEquipment.Type
            }));

            return await Task.FromResult(bookings);
        }

        public async Task<Booking> AddBooking(BookingDTO booking)
        {
            Booking booking1 = new Booking()
            {
                StartBookingDate = booking.StartBookingDate,
                FinishBookingDate = booking.FinishBookingDate,
                RequestDate = booking.RequestDate,
                StatusBooking = _context.StatusBooking.FirstOrDefault(s => s.Id == 1),
                Equipment = _context.Equipment.FirstOrDefault(e => e.Id == booking.EquipmentId),
                User = _context.UserDescriptions.FirstOrDefault(u => u.UserId == booking.UserId)
            };
            var result = _context.Booking.Add(booking1);
            await _context.SaveChangesAsync();
            return await Task.FromResult(result.Entity);
        }
    }
}

