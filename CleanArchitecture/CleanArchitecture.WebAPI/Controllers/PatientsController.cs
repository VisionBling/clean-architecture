using CleanArchitecture.Application.DTOs;
using CleanArchitecture.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using CleanArchitecture.Application.Interfaces.Services;
namespace CleanArchitecture.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private readonly IPatientService _patientService;

        public PatientsController(IPatientService patientService)
        {
            _patientService = patientService;
        }

       

        /// <summary>
        ///add 
        /// </summary>
        /// <param name="patientDto"></param>
        /// <returns></returns>

        [HttpPost]
        public async Task<IActionResult> AddPatient([FromBody] PatientCreationDto patientDto)
        {
            var createdPatient = await _patientService.AddPatientAsync(patientDto);
            return CreatedAtAction(nameof(AddPatient), new { id = createdPatient.Id }, createdPatient);
        }

      
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var patients = await _patientService.GetAllPatientsAsync();
            return Ok(patients);
        }
    }
}
