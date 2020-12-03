using HotelTDD.Services.Interface;
using HotelTDD.Services.TypeRoom.Request;
using HotelTDD.Services.TypeRoom.Response;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace HotelTDD.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class TypeRoomController : ControllerBase
    {
        private readonly ITypeRoomService _typeRoomService;

        public TypeRoomController(ITypeRoomService typeRoomService)
        {
            _typeRoomService = typeRoomService;
        }

        [HttpPost] 
        public IActionResult Create([FromBody] TypeRoomCreateRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Tipo de quarto inválido.");

                _typeRoomService.Create(request);

                return Created(string.Empty, "Tipo de quarto criado com sucesso.");

            }
            catch (Exception ex)
            {
                return BadRequest($"Não foi possivel salvar o tipo do quarto: {ex}");
            }
        }

        [HttpGet]
        public IActionResult GetById([FromQuery] int id)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Id inválido.");

               var response = _typeRoomService.GetById(id);

                return Ok(response);

            }
            catch (Exception ex)
            {
                return BadRequest($"Não foi possivel encontrar o tipo do quarto: {ex}");
            }
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var response = _typeRoomService.GetAll();

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest($"Não foi possivel encontrar o tipo do quarto: {ex}");
            }
        }
    }
}
