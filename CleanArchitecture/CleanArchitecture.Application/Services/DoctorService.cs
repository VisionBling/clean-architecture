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
    public class DoctorService : IDoctorService
    {
        private readonly IDoctorRepository _doctorRepository;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="doctorRepository"></param>
        
        public DoctorService(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="doctorDto"></param>
        /// <returns></returns>
        public async Task<DoctorDto> AddDoctorAsync(DoctorCreationDto doctorDto)
        {
            var doctor = new Doctor(doctorDto.Name, doctorDto.Specialization);
            await _doctorRepository.AddAsync(doctor);
            await _doctorRepository.SaveChangesAsync();
            return new DoctorDto { Id = doctor.Id, Name = doctor.Name, Specialization = doctor.Specialization };
        }
       
        public async Task<IEnumerable<DoctorDto>> GetAllDoctorsAsync()
        {
            var doctors = await _doctorRepository.GetAllAsync();
            return doctors.Select(d => new DoctorDto { Id = d.Id, Name = d.Name, Specialization = d.Specialization }).ToList();
        }
    }

}
