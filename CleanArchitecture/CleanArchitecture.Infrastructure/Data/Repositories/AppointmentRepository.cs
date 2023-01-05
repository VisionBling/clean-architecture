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
    public class AppointmentRepository : GenericRepository<Appointment>, IAppointmentRepository
    {
        public AppointmentRepository(ApplicationDbContext context) : base(context)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="doctorId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Appointment>> GetAppointmentsByDoctorIdAsync(Guid doctorId)
        {
            return await _context.Appointments
                                 .Where(a => a.DoctorId == doctorId)
                                 .ToListAsync();
        }
    }

}
