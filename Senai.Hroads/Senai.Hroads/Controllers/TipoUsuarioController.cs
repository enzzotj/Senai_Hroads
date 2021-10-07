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
    public class TipoUsuarioController : ControllerBase
    {
        private ITipoUsuarioRepository _tipoUsuarioRepository { get; set; }

        public TipoUsuarioController()
        {
            _tipoUsuarioRepository = new TipoUsuarioRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_tipoUsuarioRepository.ListarTodas());
        }

        [HttpGet("{id}")]
        public IActionResult BuscarPeloId(int id)
        {
            return Ok(_tipoUsuarioRepository.BuscarPorId(id));
        }

        [HttpPost]
        [Authorize(Roles = "Administrador")]
        public IActionResult Postar(TipoUsuario novoTipoUsu)
        {
            _tipoUsuarioRepository.Cadastrar(novoTipoUsu);

            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, TipoUsuario TipoUsuAtualizado)
        {
            _tipoUsuarioRepository.Atualizar(id, TipoUsuAtualizado);

            return StatusCode(204);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _tipoUsuarioRepository.Deletar(id);

            return StatusCode(204);
        }

    }
}