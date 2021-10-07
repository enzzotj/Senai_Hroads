using Senai.Hroads.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Hroads.Interfaces
{
    interface IUsuarioRepository
    {
        List<Usuario> ListarTodas();
        Usuario BuscarPorId(int id);
        void Cadastrar(Usuario novoUsuario);
        void Atualizar(int id, Usuario UsuarioAtualizado);
        void Deletar(int id);
        Usuario Logar(string email, string senha);
    }
}
