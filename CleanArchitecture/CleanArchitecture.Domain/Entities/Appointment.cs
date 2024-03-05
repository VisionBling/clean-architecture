using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities
{
    public class Appointment
    {
        public Guid Id { get; private set; }
        public Guid PatientId { get; private set; }
        public Patient Patient { get; private set; }
        public Guid DoctorId { get; private set; }
        public Doctor Doctor { get; private set; }

        public DateTime AppointmentDate { get; private set; }

        public Appointment(Guid patientId, Guid doctorId, DateTime appointmentDate)
        {
            Id = Guid.NewGuid();
            PatientId = patientId;
            DoctorId = doctorId;
            AppointmentDate = appointmentDate;
        }
    }

}
