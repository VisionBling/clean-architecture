using CleanArchitecture.Application.DTOs;
using CleanArchitecture.Application.Interfaces.Repositories;
using CleanArchitecture.Application.Interfaces.Services;
using CleanArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepository _appointmentRepository;

        public AppointmentService(IAppointmentRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }
  
        /// <summary>
        /// se=chedul appointment 
        /// </summary>
        /// <param name="appointmentDto"></param>
        /// <returns></returns>
        public async Task<AppointmentDto> ScheduleAppointmentAsync(AppointmentCreationDto appointmentDto)
        {
            var appointment = new Appointment(appointmentDto.PatientId, appointmentDto.DoctorId, appointmentDto.AppointmentDate);          
            await _appointmentRepository.AddAsync(appointment);
            await _appointmentRepository.SaveChangesAsync();
            return new AppointmentDto { Id = appointment.Id, PatientId = appointment.PatientId, DoctorId = appointment.DoctorId, AppointmentDate = appointment.AppointmentDate };
        }

       /// <summary>
       /// Get All Appointmemt
       /// </summary>
       /// <returns></returns>
        public async Task<IEnumerable<AppointmentDto>> GetAllAppointmentsAsync()
        {
            var appointments = await _appointmentRepository.GetAllAsync();
            return appointments.Select(a => new AppointmentDto { Id = a.Id, PatientId = a.PatientId, DoctorId = a.DoctorId, AppointmentDate = a.AppointmentDate }).ToList();
        }
    }
}
