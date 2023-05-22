using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.DTOs
{
    public class DoctorDto: DoctorCreationDto
    {
        public Guid Id { get; set; }
    }
    public class DoctorCreationDto
    {
        public string Name { get; set; }
        public string Specialization { get; set; }
    }
}
