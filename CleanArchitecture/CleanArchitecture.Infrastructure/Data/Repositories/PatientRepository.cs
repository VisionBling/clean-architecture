using CleanArchitecture.Application.Interfaces.Repositories;
using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Data.Repositories
{
    public class PatientRepository : GenericRepository<Patient>, IPatientRepository
    {

        public PatientRepository(ApplicationDbContext context) : base(context)
        {
        }

        // Get 
        public async Task<Patient> GetPatientWithAppointmentsAsync(Guid patientId)
        {
            return await _context.Patients
                                 .Include(p => p.Appointments)
                                 .FirstOrDefaultAsync(p => p.Id == patientId);
        }
    }

}
