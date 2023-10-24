

using Acessi_api.Interfaces.User;
using Acessi_api.Models.User;
using Microsoft.AspNetCore.Mvc;

namespace Acessi_api.Controllers.User
{

    public class UserController: ControllerBase
    {


        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> RegisterUser([FromBody] UserModel user)
        {
            if (user == null)
                return BadRequest("Dados de usuário inválidos");


            // Validações adicionais, como verificar se o e-mail já existe, podem ser feitas aqui.

            UserModel createdUser = await _userService.CreateUserAsync(user);
            return CreatedAtAction("GetUser", new { id = createdUser.Id }, createdUser);
        }
    }
}
