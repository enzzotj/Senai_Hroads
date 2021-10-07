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
    public class HabilidadeController : ControllerBase
    {
        private IHabilidadeRepository _habilidadeRepository { get; set; }

        public HabilidadeController()
        {
            _habilidadeRepository = new HabilidadeRepository();
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_habilidadeRepository.ListarTodas());
        }
        [HttpGet("{id}")]
        public IActionResult BuscarPeloId(int id)
        {
            return Ok(_habilidadeRepository.BuscarPorId(id));
        }
        [HttpPost]
        [Authorize(Roles = "Administrador")]
        public IActionResult Postar(Habilidade novaHabilidade)
        {
            _habilidadeRepository.Cadastrar(novaHabilidade);

            return StatusCode(201);
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, Habilidade HabilidadeAtualizada)
        {
            _habilidadeRepository.Atualizar(id, HabilidadeAtualizada);

            return StatusCode(204);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _habilidadeRepository.Deletar(id);

            return StatusCode(204);
        }

    }
}
