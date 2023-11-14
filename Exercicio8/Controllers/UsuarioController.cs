using Exercicio8.Models;
using Exercicio8.Repository;
using Exercicio8.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Exercicio8.Controllers
{
    [Route("api/usuario")]
    public class UsuarioController : ControllerBase
    {
        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> Authenticate([FromBody] Usuario usuario)
        {
            var user = UserRepository.Get(usuario.Username, usuario.Password);

            if (user == null)
                return NotFound(new { message = "Usuário ou senha inválidos" });

            var token = TokenService.GenerateToken(user);

            
            return new
            {
                user = new
                {
                    user.Id,
                    user.Username,
                    user.Role
                },
                token
            };
        }
    }
}
