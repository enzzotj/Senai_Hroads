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
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository { get; set; }

        public UsuarioController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_usuarioRepository.ListarTodas());
        }
        [HttpGet("{id}")]
        public IActionResult BuscarPeloId(int id)
        {
            return Ok(_usuarioRepository.BuscarPorId(id));
        }

        [HttpPost]
        [Authorize(Roles = "Administrador")]
        public IActionResult Postar(Usuario novoUsuario)
        {
            _usuarioRepository.Cadastrar(novoUsuario);

            return StatusCode(201);
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, Usuario UsuarioAtualizado)
        {
            _usuarioRepository.Atualizar(id, UsuarioAtualizado);

            return StatusCode(204);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _usuarioRepository.Deletar(id);

            return StatusCode(204);
        }

    }
}
