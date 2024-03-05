using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities
{
    public class Patient
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public List<Appointment> Appointments { get; private set; }

        public Patient(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
            Appointments = new List<Appointment>();

        }
        // Methods to manipulate the Patient entity, including adding appointments
        public void AddAppointment(Appointment appointment)
        {
            Appointments.Add(appointment);
        }
    }

}
