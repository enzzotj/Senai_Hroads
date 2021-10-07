using Senai.Hroads.Contexts;
using Senai.Hroads.Domains;
using Senai.Hroads.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Hroads.Repositories
{
    public class PersonagemRepository : IPersonagemRepository
    {
        HroadsContext hctx = new HroadsContext();

        public void Atualizar(int id, Personagem PersonagemAtualizado)
        {
            Personagem personagemBuscada = hctx.Personagems.Find(id);

            if (personagemBuscada.NomePer != null)
            {

                personagemBuscada.NomePer = PersonagemAtualizado.NomePer;

                hctx.Personagems.Update(personagemBuscada);

                hctx.SaveChanges();
            }
        }

        public Personagem BuscarPorId(int id)
        {
            return hctx.Personagems.FirstOrDefault(p => p.IdPersonagem == id);
        }

        public void Cadastrar(Personagem novoPersonagem)
        {
            hctx.Personagems.Add(novoPersonagem);

            hctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            hctx.Personagems.Remove(BuscarPorId(id));

            hctx.SaveChanges();
        }

        public List<Personagem> ListarTodas()
        {
            return hctx.Personagems.ToList();
        }
    }
}
