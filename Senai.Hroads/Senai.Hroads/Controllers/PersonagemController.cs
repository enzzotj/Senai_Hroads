using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Senai.Hroads.Domains;
using Senai.Hroads.Interfaces;
using Senai.Hroads.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Hroads.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]

    [ApiController]
    public class PersonagemController : ControllerBase
    {
        private IPersonagemRepository _personagemRepository { get; set; }

        public PersonagemController()
        {
            _personagemRepository = new PersonagemRepository();
        }
        [HttpGet]
        [Authorize(Roles = "Jogador,Administrador")]
        public IActionResult Get()
        {
            return Ok(_personagemRepository.ListarTodas());
        }

        [HttpGet("{id}")]
        public IActionResult BuscarPeloId(int id)
        {
            return Ok(_personagemRepository.BuscarPorId(id));
        }

        [HttpPost]
        [Authorize(Roles = "Jogador")]
        public IActionResult Postar(Personagem novoPersonagem)
        {
            _personagemRepository.Cadastrar(novoPersonagem);

            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Personagem PersonagemAtualizado)
        {
            _personagemRepository.Atualizar(id, PersonagemAtualizado);

            return StatusCode(204);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _personagemRepository.Deletar(id);

            return StatusCode(204);
        }


    }
}