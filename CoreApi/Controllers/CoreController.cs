using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoreApi.Controllers
{

    public class CoreController(ILogger<Program> logger) : BaseApiController
    {
        [HttpGet("/")]
        public IActionResult Get()
        {
            return Ok("Welcome to the Core API of the project");
        }

        [HttpGet("/health")]
        public IActionResult HealthCheck()
        {
            logger.LogInformation("Health Check called");
            // Functions to check
            // DB Connection
            // Authentication
            // List available modules
            return Ok("Health Check ok");
        }
    }
}