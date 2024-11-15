using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_CarolinaBustamante.DTO;
using Assessment_CarolinaBustamante.Repositories;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Assessment_CarolinaBustamante.Controllers.V1.Auth
{
    [ApiController]
    [Route("api/v1/users")]
    public class AuthController : ControllerBase
    {
        protected readonly IUserRepository _repository;

        public AuthController(IUserRepository repository)
        {
            _repository = repository;
        }

        [HttpPost("register")]
        [SwaggerOperation(
            Summary = "Create user",
            Description = "Register user in database"
        )]
        [SwaggerResponse(200, "Created: User registered successfully")]
        [SwaggerResponse(400, "Bad request")]

        public async Task<IActionResult> Register(UserRegistrationDTO newUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _repository.Register(newUser);
            return Ok("User was registered successfully" ); 
        }
    }
}