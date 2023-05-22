using CleanArchitecture.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Interfaces.Services
{
    public interface IDoctorService
    {
        Task<DoctorDto> AddDoctorAsync(DoctorCreationDto doctorDto);
        Task<IEnumerable<DoctorDto>> GetAllDoctorsAsync();
    }
}
