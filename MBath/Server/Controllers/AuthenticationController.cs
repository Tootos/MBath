using MBath.Shared.Models;
using MBath.Shared.Models.UserModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace MBath.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost("login")]
        public async Task<ActionResult<ServiceResponse<string>>> Login(UserLogin request)
        {
            var result = await _authenticationService.Login(request.Email,request.Password);

            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("register")]
        public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegister request)
        {
            var response = await _authenticationService.Register(
                new User
                {
                    Email = request.Email
                    
                }, request.Password);

            if(response.Success)
                return Ok(response);
            else
                return BadRequest(response);
        }

        [HttpPost("change-password"), Authorize]
        public async Task<ActionResult<ServiceResponse<bool>>> ChangePassword([FromBody]string newPassword)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var response = await _authenticationService.ChangePassword(int.Parse(userId), newPassword);

            if(response.Success)
                return Ok(response);
            return BadRequest(response);
        }

    }
}
