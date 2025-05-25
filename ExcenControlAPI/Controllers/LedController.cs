using ExcenControlAPI.Models;
using ExcenControlAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExcenControlAPI.Controllers
{
    [Route("api/led")]
    [ApiController]
    public class LedController : ControllerBase
    {
        private readonly ILedService _ledService;

        public LedController(ILedService ledService)
        {
            _ledService = ledService;
        }

        [HttpGet("status")]
        public IActionResult GetStatus()
        {
            return Ok(_ledService.GetStatus());
        }

        [HttpPost("set")]
        public IActionResult SetStatusFromBody([FromBody] LedStatusDto dto)
        {
            _ledService.SetStatus(dto.IsOn);
            return Ok(new { success = true, currentStatus = dto.IsOn });
        }
    }
}
