using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_CarolinaBustamante.Repositories;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Assessment_CarolinaBustamante.Controllers.V1.Doctors
{
    [ApiController]
    [Route("api/v1/doctors")]
    [Tags("doctors")]
    public class DoctorGetController : DoctorController
    {
        public DoctorGetController(IUserRepository repository) : base(repository)
        {
        }

        [HttpGet]
        [SwaggerOperation(
          Summary = "Get doctors",
          Description = "Returns all the doctors in database")]
        [SwaggerResponse(200, "Ok: returns all the doctors in database")]
        [SwaggerResponse(204, "No Content: there are not doctors in the database")]

        public async Task<IActionResult> GetAll()
        {
            var doctors = await _repository.GetDoctors();

            if (doctors == null || !doctors.Any())
            {
                return NoContent();
            }

            return Ok(doctors);
        }

    }
}