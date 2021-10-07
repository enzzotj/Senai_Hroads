using Senai.Hroads.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Hroads.Interfaces
{
    interface IPersonagemRepository
    {
        List<Personagem> ListarTodas();
        Personagem BuscarPorId(int id);
        void Cadastrar(Personagem novoPersonagem);
        void Atualizar(int id, Personagem PersonagemAtualizado);
        void Deletar(int id);
    }
}
