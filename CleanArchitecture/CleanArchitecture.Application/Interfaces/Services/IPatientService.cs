using CleanArchitecture.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Interfaces.Services
{
    public interface IPatientService
    {
        Task<PatientDto> AddPatientAsync(PatientCreationDto patientDto);
        Task<IEnumerable<PatientDto>> GetAllPatientsAsync();
    }
}
