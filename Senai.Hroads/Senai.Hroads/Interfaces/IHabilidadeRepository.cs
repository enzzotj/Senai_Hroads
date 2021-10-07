using Senai.Hroads.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Hroads.Interfaces
{
    interface IHabilidadeRepository
    {
        List<Habilidade> ListarTodas();
        Habilidade BuscarPorId(int id);
        void Cadastrar(Habilidade novaHabilidade);
        void Atualizar(int id, Habilidade HabilidadeAtualizada);
        void Deletar(int id);

    }
}
