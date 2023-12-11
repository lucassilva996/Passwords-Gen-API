using Microsoft.AspNetCore.Mvc;
using Passwords_Gen.Domain.Interfaces;
using Passwords_Gen.Service.Services;

namespace Passwords_Gen.Controllers
{
    [ApiController]
    [Route("api/password-gen")]
    public class PasswordsController : ControllerBase
    {
        private readonly IPasswordService _passwordService;
        public PasswordsController(IPasswordService passwordService)
        {
            _passwordService = passwordService;
        }

        [HttpGet]
        public IActionResult GetPassword(int length)
        {
            var result = _passwordService.GenerateRandomPassword(length);
            return Ok(result);
        }
    }
}
