using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;
using Parlez.ViewModels;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Parlez.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private IConfiguration _config;
        private IServiceProvider _serviceProvider;

        public AuthController(SignInManager<IdentityUser> signInManager,
                                UserManager<IdentityUser> userManager,
                                IConfiguration config,
                                IServiceProvider serviceProvider)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _config = config;
            _serviceProvider = serviceProvider;
        }


        [HttpPost("Register")]
        public async Task<JsonResult> RegisterAsync([FromBody] RegisterVM registerVM)
        {
            if (ModelState.IsValid)
            {
                //will need to implement email or turn off email verification
                var user = new IdentityUser { UserName = registerVM.Email, Email = registerVM.Email, EmailConfirmed = true };
                var result = await _userManager.CreateAsync(user, registerVM.Password);
                if (result.Succeeded)
                {
                    return await SignInAsync(new LoginVM() { Email = registerVM.Email, Password = registerVM.Password });
                }
            }
            dynamic jsonResponse = new JObject();
            jsonResponse.token = "";
            jsonResponse.status = "Registration Failed";
            return Json(jsonResponse);
        }

        string GenerateJSONWebToken(IdentityUser user)
        {
            var securityKey
                = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JWT_SITEKEY"]));
            var credentials
                = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new List<Claim> {
                            new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                            new Claim(JwtRegisteredClaimNames.Jti,
                                        Guid.NewGuid().ToString()),
                            new Claim(ClaimTypes.NameIdentifier, user.Id)
             };

            var token = new JwtSecurityToken(
                    _config["JWT_ISSUER"],
                    _config["JWT_ISSUER"],
                    claims,
                    expires: DateTime.Now.AddMinutes(120),
                    signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }
}
