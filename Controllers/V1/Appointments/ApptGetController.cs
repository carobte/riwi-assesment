using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_CarolinaBustamante.Repositories;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Assessment_CarolinaBustamante.Controllers.V1.Appointments
{
    [ApiController]
    [Route("api/v1/appointments")]
    [Tags("appointments")]
    public class ApptGetController : ApptController
    {
        public ApptGetController(IAppointmentRepository repository) : base(repository)
        {
        }
                
        [HttpGet]
        [SwaggerOperation(
          Summary = "Get appointments",
          Description = "Returns all the appointments in database")]
        [SwaggerResponse(200, "Ok: returns all the appointments in database")]
        [SwaggerResponse(204, "No Content: there are not appointments in the database")]

        public async Task<IActionResult> GetAll()
        {
            var appointments = await _repository.GetAppointments();

            if (appointments == null || !appointments.Any())
            {
                return NoContent();
            }

            return Ok(appointments);
        }
    }
}