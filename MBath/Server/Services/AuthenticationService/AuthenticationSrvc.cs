using MBath.Shared.Models;
using MBath.Shared.Models.UserModels;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Security.Cryptography;

namespace MBath.Server.Services.AuthenticationServices
{
    public class AuthenticationSrvc : IAuthenticationSrvc
    {
        private readonly DataContext _context;
        private readonly IConfiguration _confirguration;

        public AuthenticationSrvc(DataContext context, IConfiguration confirguration)
        {
            _context = context;
            _confirguration = confirguration;
        }

        public async Task<ServiceResponse<int>> Register(User user, string password)
        {
            if (await UserExists(user.Email))
            {
                return new ServiceResponse<int> { 
                    Message= "Email already in use.",
                    Success = false };
            }

            

            CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);

            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            _context.Users.Add(user);

            await _context.SaveChangesAsync();

            return new ServiceResponse<int>
            {
                Data = user.Id,
                Message = "Your account was registered Successfully"
            };


        }
        public async Task<ServiceResponse<string>> Login(string email, string password)
        {
            var response = new ServiceResponse<string>();

            var user= await _context.
                Users.FirstOrDefaultAsync(u=>u.Email.ToLower().Equals(email.ToLower()));

            if (user== null || !VerifyPasswordHash(password, user.PasswordHash,user.PasswordSalt))
            {
                response.Success = false;
                response.Message = "Email or Password wrong";
                return response;
            }

            response.Data = CreateToken(user);

            return response;

        }

        

        public async Task<ServiceResponse<bool>> ChangePassword(int userId, string newPassword)
        {
            var user = await _context.Users.FindAsync(userId);

            if (user == null)
            {
                return new ServiceResponse<bool>
                {
                    Success=false,
                    Message= "Email was not found."

                };               
            }

            CreatePasswordHash(newPassword, out byte[] passwordHash, out byte[] passwordSalt);

            user.PasswordHash=passwordHash;
            user.PasswordSalt=passwordSalt;

            await _context.SaveChangesAsync();

            return new ServiceResponse<bool> { Data = true, Message="Password succesfully changed." };
        }

        private string? CreateToken(User user)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier,user.Id.ToString()),
                new Claim(ClaimTypes.Name,user.Email)
            };

            var key = new SymmetricSecurityKey(System.Text
                .Encoding.UTF8.GetBytes(_confirguration.GetSection("AppSettings:Token").Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds
                );

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash,out byte[] passwordSalt)
        {
            using(var hmac= new HMACSHA512())
            {
                passwordSalt = hmac.Key;

                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        private async Task<bool> UserExists(string email)
        {
            if(await _context.Users.AnyAsync(u=>u.Email.ToLower().Equals(email.ToLower()))) 
                return true;

            return false;
        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using(var hmac= new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return passwordHash.SequenceEqual(computedHash);
            }
        }
    }
}
