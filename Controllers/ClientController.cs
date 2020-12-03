using HotelTDD.Services.Client.Request;
using HotelTDD.Services.Interface;
using HotelTDD_New.Model;
using HotelTDD_New.Repository;
using HotelTDD_New.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace HotelTDD.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }


        [HttpPost]
        [Authorize(Roles = "manager")]
        public IActionResult Create([FromBody] ClientCreateRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Cliente inválido.");

                _clientService.Create(request);

                return Created(string.Empty, "Cliente criado com sucesso.");
            }
            catch (Exception ex)
            {
                return BadRequest($"Não foi possivel salvar o cliente: {ex}");
            }
        }

        [HttpGet]
        public IActionResult GetById([FromQuery] int id)
        {
            try
            {
               var response = _clientService.GetById(id);

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest($"Não foi possivel encontrar o cliente: {ex}");
            }
        }

        [HttpPost]
        [Route("login")]
        public ActionResult<dynamic> Authenticate([FromBody] User model)
        {
            // Recupera o usuário
            var user = UserRepository.Get(model.Username, model.Password);

            // Verifica se o usuário existe
            if (user.Username != model.Username || user.Password != model.Password)
                return NotFound(new { message = "Usuário ou senha inválidos" });

            // Gera o Token
            var token = TokenService.GenerateToken(user);

            // Oculta a senha
            user.Password = "";

            // Retorna os dados
            return new
            {
                user = user,
                token = token
            };
        }

        [HttpGet]
        [Route("anonymous")]
        [AllowAnonymous]
        public string Anonymous() => "Anônimo";

        [HttpGet]
        [Route("authenticated")]
        [Authorize]
        public string Authenticated() => String.Format("Autenticado - {0}", User.Identity.Name);

        [HttpGet]
        [Route("employee")]
        [Authorize(Roles = "employee,manager")]
        public string Employee() => "Funcionário";

        [HttpGet]
        [Route("manager")]
        [Authorize(Roles = "manager")]
        public string Manager() => "Gerente";
    }
}
