using Exercicio8.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Exercicio8.Services
{
    public static class TokenService
    {

        public static string GenerateToken(Usuario usuario)
        {
            // Gerador de token
            var tokenHandler = new JwtSecurityTokenHandler();
            // pega a chave secreta definida pelo usuario e converte em bytes
            var key = Encoding.ASCII.GetBytes(Settings.Secret);

            // Gerador de token
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                // Classe para criar o token
                Subject = new ClaimsIdentity(new Claim[]
                {
                    // pega o usuario ou seja o atributo do username 
                    new Claim(ClaimTypes.Name, usuario.Username.ToString()),
                    // define o tipo de usuario do sistema
                    new Claim(ClaimTypes.Role, usuario.Role.ToString())
                }),
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new SigningCredentials( new SymmetricSecurityKey(key),SecurityAlgorithms.HmacSha256Signature)
            };
           var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
