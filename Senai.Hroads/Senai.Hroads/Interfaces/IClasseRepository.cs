using Senai.Hroads.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Hroads.Interfaces
{
    interface IClasseRepository
    {
        List<Classe> ListarTodas();
        Classe BuscarPorId(int id);
        void Cadastrar(Classe novaClasse);
        void Atualizar(int id, Classe classeAtualizada);
        void Deletar(int id);
        List<Classe> ListarComPersonagens();
    }
}
