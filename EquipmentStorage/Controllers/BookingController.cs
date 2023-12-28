using System;
using EquipmentStorage.Data.Models;
using EquipmentStorage.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EquipmentStorage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly BookingService _context;

        public BookingController(BookingService context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Booking>>> GetBookings()
        {
            return await _context.GetBookings();
        }

        [HttpGet("{userId}")]
        public async Task<ActionResult<List<BookingDTOGet>>> GetBooking(int userId)
        {
            return await _context.GetBooking(userId);
        }

        [HttpPost]
        public async Task<ActionResult<bool?>> PostBooking([FromBody] BookingDTO bookingDTO)
        {
            var result = await _context.AddBooking(bookingDTO);
            if (result == null)
            {
                return false;
            }

            return true;
        }
    }

    
}

