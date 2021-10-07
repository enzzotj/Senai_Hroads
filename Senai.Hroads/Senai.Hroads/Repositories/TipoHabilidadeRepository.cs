using Senai.Hroads.Contexts;
using Senai.Hroads.Domains;
using Senai.Hroads.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Hroads.Repositories
{
    public class TipoHabilidadeRepository : ITipoHabilidadeRepository
    {
        HroadsContext hctx = new HroadsContext();

        public void Atualizar(int id, TipoHabilidade TipoHabilidadeAtualizado)
        {
            TipoHabilidade TipoHabilidadeBuscado = hctx.TipoHabilidades.Find(id);

            if (TipoHabilidadeBuscado.TipoHab != null)
            {

                TipoHabilidadeBuscado.TipoHab = TipoHabilidadeAtualizado.TipoHab;

                hctx.TipoHabilidades.Update(TipoHabilidadeBuscado);

                hctx.SaveChanges();
            }
        }

        public TipoHabilidade BuscarPorId(int id)
        {
            return hctx.TipoHabilidades.FirstOrDefault(t => t.IdTipoHab == id);
        }

        public void Cadastrar(TipoHabilidade novoTipoHabilidade)
        {
            hctx.TipoHabilidades.Add(novoTipoHabilidade);

            hctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            hctx.TipoHabilidades.Remove(BuscarPorId(id));

            hctx.SaveChanges();
        }

        public List<TipoHabilidade> ListarTodas()
        {
            return hctx.TipoHabilidades.ToList();
        }
    }
}
