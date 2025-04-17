using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using PatikaIdentityDataProtection.Context;
using PatikaIdentityDataProtection.Dto;
using PatikaIdentityDataProtection.Entities;

namespace PatikaIdentityDataProtection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IdentityDataProtectionDbContext _context;
        private readonly IDataProtector _protector;

        public AuthController(IdentityDataProtectionDbContext context, IDataProtectionProvider provider)
        {
            _context = context;
            _protector = provider.CreateProtector("UserPasswordProtector");
        }

        [HttpPost("register")]
        public IActionResult Register(UserRegisterDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = new User
            {
                Email = dto.Email,
                Password = _protector.Protect(dto.Password) // Şifrelenmiş şekilde saklanıyor
            };

            _context.Users.Add(user);
            _context.SaveChanges();

            return Ok("User added successfully");
        }
    }
}