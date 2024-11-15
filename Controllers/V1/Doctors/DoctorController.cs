using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_CarolinaBustamante.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment_CarolinaBustamante.Controllers.V1.Doctors
{
    [ApiController]
    [Route("api/v1/doctors")]
    public class DoctorController : ControllerBase
    {
         protected readonly IUserRepository _repository;

        public DoctorController(IUserRepository repository)
        {
            _repository = repository;
        }

        
    }
}