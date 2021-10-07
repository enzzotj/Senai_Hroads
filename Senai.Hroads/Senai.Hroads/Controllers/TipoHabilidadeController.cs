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
    public class TipoHabilidadeController : ControllerBase
    {
        private ITipoHabilidadeRepository _tipoHabilidadeRepository { get; set; }

        public TipoHabilidadeController()
        {
            _tipoHabilidadeRepository = new TipoHabilidadeRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_tipoHabilidadeRepository.ListarTodas());
        }

        [HttpGet("{id}")]
        public IActionResult BuscarPeloId(int id)
        {
            return Ok(_tipoHabilidadeRepository.BuscarPorId(id));
        }

        [HttpPost]
        [Authorize(Roles = "Administrador")]
        public IActionResult Postar(TipoHabilidade novoTipoHabilidade)
        {
            _tipoHabilidadeRepository.Cadastrar(novoTipoHabilidade);

            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, TipoHabilidade TipoHabilidadeAtualizado)
        {
            _tipoHabilidadeRepository.Atualizar(id, TipoHabilidadeAtualizado);

            return StatusCode(204);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _tipoHabilidadeRepository.Deletar(id);

            return StatusCode(204);
        }


    }
}
