using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_CarolinaBustamante.DTO;
using Assessment_CarolinaBustamante.Repositories;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Assessment_CarolinaBustamante.Controllers.V1.Appointments
{
    [ApiController]
    [Route("api/v1/appointments")]
    [Tags("appointments")]
    public class ApptPostController : ApptController
    {
        public ApptPostController(IAppointmentRepository repository) : base(repository)
        {
        }

        [HttpPost()]
        [SwaggerOperation(
            Summary = "Create appointment",
            Description = "Create an appointment in database"
        )]
        [SwaggerResponse(200, "Created: appointment registered successfully")]
        [SwaggerResponse(400, "Bad request")]
        public async Task<IActionResult> CreateAppt(AppointmentRequest newAppt)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var (isSuccess, message) = await _repository.CreateAppointment(newAppt);
            if (!isSuccess)
            {
                return BadRequest(message);
            }

            return Ok(message);
        }

    }
}