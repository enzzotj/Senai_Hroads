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
    public class ClasseController : ControllerBase
    {
        private IClasseRepository _classeRepository { get; set; }

        public ClasseController()
        {
            _classeRepository = new ClasseRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<Classe> listaClasse = _classeRepository.ListarTodas();

            return Ok(listaClasse);
        }
        [HttpGet("{id}")]
        public IActionResult BuscarPeloId(int id)
        {
            return Ok(_classeRepository.BuscarPorId(id));
        }

        [HttpDelete]
        [HttpPost]
        [Authorize(Roles = "Administrador")]
        public IActionResult Postar(Classe novaClasse)
        {
            _classeRepository.Cadastrar(novaClasse);
            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Classe classeAtualizada)
        {
            _classeRepository.Atualizar(id, classeAtualizada);

            return StatusCode(204);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _classeRepository.Deletar(id);
            return StatusCode(204);
        }

        [HttpGet("personagem")]
        public IActionResult ListarComPersonagem()
        {
            return Ok(_classeRepository.ListarComPersonagens());
        }
    }
}
