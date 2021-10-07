using Senai.Hroads.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Hroads.Interfaces
{
    interface ITipoUsuarioRepository
    {
        List<TipoUsuario> ListarTodas();
        TipoUsuario BuscarPorId(int id);
        void Cadastrar(TipoUsuario novoTipoUsu);
        void Atualizar(int id, TipoUsuario TipoUsuAtualizado);
        void Deletar(int id);
    }
}
