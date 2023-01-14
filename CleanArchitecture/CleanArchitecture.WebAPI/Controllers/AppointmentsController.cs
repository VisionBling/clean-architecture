using CleanArchitecture.Application.DTOs;
using CleanArchitecture.Application.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;
>
        public AppointmentsController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

       
        [HttpPost]
        public async Task<ActionResult<AppointmentDto>> ScheduleAppointment([FromBody] AppointmentCreationDto appointmentDto)
        {
            var scheduledAppointment = await _appointmentService.ScheduleAppointmentAsync(appointmentDto);
            return CreatedAtAction(nameof(ScheduleAppointment), new { id = scheduledAppointment.Id }, scheduledAppointment);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppointmentDto>>> GetAll()
        {
            var appointments = await _appointmentService.GetAllAppointmentsAsync();
            return Ok(appointments);
        }
    }
}
