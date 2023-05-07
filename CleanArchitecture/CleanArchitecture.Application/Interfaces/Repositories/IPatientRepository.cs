using CleanArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Interfaces.Repositories
{
    public interface IPatientRepository: IGenericRepository<Patient>
    {
        Task<Patient> GetPatientWithAppointmentsAsync(Guid patientId);

    }
}
