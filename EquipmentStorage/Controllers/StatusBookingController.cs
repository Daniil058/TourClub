using System;
using EquipmentStorage.Data.Models;
using EquipmentStorage.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace EquipmentStorage.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class StatusBookingController : ControllerBase
    {
        private readonly StatusBookingService _context;

        public StatusBookingController(StatusBookingService context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<StatusBooking>>> GetStatusBookings()
        {
            return await _context.GetStatusBookings();
        }

        [HttpPost]
        public async Task<ActionResult<StatusBooking>> PostStatusBooking([FromBody] StatusBooking statusBooking)
        {
            var result = await _context.AddStatusBooking(statusBooking);
            if (result == null)
            {
                BadRequest();
            }

            return Ok(result);
        }
    }

}

