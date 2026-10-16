using ClinicManagementSystem.Services.Base;
using Microsoft.AspNetCore.Mvc;

namespace ClinicManagementSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController(IDoctorServices doctorServices) : ControllerBase
    {
        private readonly IDoctorServices _doctorServices = doctorServices;

        [HttpGet("GetAllUsers")]
        public IActionResult GetAllUsers()
        {
            // Logic to retrieve all users from the database
            var users = new List<object>
            {
                new { Id = 1, Name = "John Doe", Email = "john.doe@example.com" }
            };
            return Ok(new { message = "Get all users", users });
        }


        [HttpGet("GetAllEmployees")]
        public async Task<IActionResult> GetAllEmployees()
        {
            var employees = await _doctorServices.GetAllDoctorsAsync();

            return Ok(new { message = "Get all employees", employees });
        }
    }
}
