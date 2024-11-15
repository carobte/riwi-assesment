using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_CarolinaBustamante.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment_CarolinaBustamante.Controllers.V1.Appointments
{
    [ApiController]
    [Route("api/v1/appointments/")]


    public class ApptController : ControllerBase
    {
        protected readonly IAppointmentRepository _repository;

        public ApptController(IAppointmentRepository repository)
        {
            _repository = repository;
        }

    }
}