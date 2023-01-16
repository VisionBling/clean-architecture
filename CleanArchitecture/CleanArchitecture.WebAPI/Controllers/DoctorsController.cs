using CleanArchitecture.Application.DTOs;
using CleanArchitecture.Application.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly IDoctorService _doctorService;

        public DoctorsController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }

        /// <summary>
        /// add doctor
        /// </summary>
        /// <param name="doctorDto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<DoctorDto>> AddDoctor([FromBody] DoctorCreationDto doctorDto)
        {
            var createdDoctor = await _doctorService.AddDoctorAsync(doctorDto);
            return CreatedAtAction(nameof(AddDoctor), new { id = createdDoctor.Id }, createdDoctor);
        }

      /// <summary>
      /// get all doctors
      /// </summary>
      /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DoctorDto>>> GetAll()
        {
            var doctors = await _doctorService.GetAllDoctorsAsync();
            return Ok(doctors);
        }
    }
}
