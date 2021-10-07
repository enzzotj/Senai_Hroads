using Senai.Hroads.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Hroads.Interfaces
{
    interface ITipoHabilidadeRepository
    {
        List<TipoHabilidade> ListarTodas();
        TipoHabilidade BuscarPorId(int id);
        void Cadastrar(TipoHabilidade novoTipoHabilidade);
        void Atualizar(int id, TipoHabilidade TipoHabilidadeAtualizado);
        void Deletar(int id);
    }
}
