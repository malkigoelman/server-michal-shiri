using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using smr.Core.Services;
using smr.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IConfiguration _configuration;
    private readonly IuserService _userService;

    public AuthController(IConfiguration configuration, IuserService userService)
    {
        _configuration = configuration;
        _userService = userService;
    }

    [HttpPost]
    public async Task<IActionResult> Login([FromBody] LoginModel loginModel)
    {
        var user = await _userService.GetUserByCredentialsAsync(
            loginModel.Id, loginModel.UserName, loginModel.Password);

        if (user != null)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.Role, user.Role.ToString())
            };

            var secretKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(_configuration["JWT:Key"]));
            var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

            var tokenOptions = new JwtSecurityToken(
                issuer: _configuration["JWT:Issuer"],
                audience: _configuration["JWT:Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(350),
                signingCredentials: signinCredentials
            );

            var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

            return Ok(new { Token = tokenString, user });
        }

        return Unauthorized("Invalid ID, username or password.");
    }
}
