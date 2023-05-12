using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.DTOs
{
    public class PatientDto: PatientCreationDto
    {
        public Guid Id { get; set; }
    }
    public class PatientCreationDto
    {
        public string Name { get; set; }
    }

}
