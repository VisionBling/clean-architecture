using CleanArchitecture.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Interfaces.Services
{
    public interface IAppointmentService
    {
        Task<AppointmentDto> ScheduleAppointmentAsync(AppointmentCreationDto appointmentDto);
        Task<IEnumerable<AppointmentDto>> GetAllAppointmentsAsync();
    }
}
