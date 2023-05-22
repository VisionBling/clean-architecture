using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities
{
    public class Doctor
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Specialization { get; private set; }
        public List<Appointment> Appointments { get; private set; }

        public Doctor(string name, string specialization)
        {
            Id = Guid.NewGuid();
            Name = name;
            Specialization = specialization;
            Appointments = new List<Appointment>();

        }
    }

}
