using Microsoft.EntityFrameworkCore;
using Senai.Hroads.Contexts;
using Senai.Hroads.Domains;
using Senai.Hroads.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Hroads.Repositories
{
    public class ClasseRepository : IClasseRepository
    {
   
        HroadsContext hctx = new HroadsContext();

        public void Atualizar(int id, Classe classeAtualizada)
        {
            Classe classeBuscada = hctx.Classes.Find(id);

            if (classeAtualizada.TipoClasse != null)
            {

                classeBuscada.TipoClasse = classeAtualizada.TipoClasse;

                hctx.Classes.Update(classeBuscada);
                hctx.SaveChanges();
            }
        }

        public Classe BuscarPorId(int id)
        {
            return hctx.Classes.FirstOrDefault(c => c.IdClasse == id);
        }

        public void Cadastrar(Classe novaClasse)
        {
            {
                hctx.Classes.Add(novaClasse);
                hctx.SaveChanges();
            }
        }

        public void Deletar(int id)
        {
            Classe classeBuscada = BuscarPorId(id);
            hctx.Classes.Remove(classeBuscada);
            hctx.SaveChanges();
        }

        public List<Classe> ListarComPersonagens()
        {
            return hctx.Classes.Include(c => c.Personagems).ToList();
        }

        public List<Classe> ListarTodas()
        {
            return hctx.Classes.ToList();
        }
    }
}
