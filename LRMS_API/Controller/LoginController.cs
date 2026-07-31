using LRMS_API.DTOs;
using LRMS_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace LRMS_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly LoginService _service;

        public LoginController(LoginService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginRequestDTO request)
        {
            var result = await _service.LoginAsync(request);

            if (result == null)
            {
                return Unauthorized(new
                {
                    Message = "Invalid Username or Password"
                });
            }

            return Ok(result);
        }
    }
}