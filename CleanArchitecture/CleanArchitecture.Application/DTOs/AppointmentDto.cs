using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.DTOs
{
    public class AppointmentCreationDto
    {
        public Guid PatientId { get; set; }
        public Guid DoctorId { get; set; }
        public DateTime AppointmentDate { get; set; }
    }

    public class AppointmentDto: AppointmentCreationDto
    {
        public Guid Id { get; set; }
       
    }

}
