﻿using Senai.Hroads.Contexts;
using Senai.Hroads.Domains;
using Senai.Hroads.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Hroads.Repositories
{
    public class HabilidadeRepository : IHabilidadeRepository
    {
        HroadsContext hctx = new HroadsContext();

        public void Atualizar(int id, Habilidade HabilidadeAtualizada)
        {
            Habilidade habilidadeBuscada = hctx.Habilidades.Find(id);

            if (habilidadeBuscada.Nome != null)
            {

                habilidadeBuscada.Nome = HabilidadeAtualizada.Nome;

                hctx.Habilidades.Update(habilidadeBuscada);

                hctx.SaveChanges();
            }
        }

        public Habilidade BuscarPorId(int id)
        {
            return hctx.Habilidades.FirstOrDefault(h => h.IdHabilidade == id);
        }

        public void Cadastrar(Habilidade novaHabilidade)
        {
            hctx.Habilidades.Add(novaHabilidade);

            hctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            hctx.Habilidades.Remove(BuscarPorId(id));

            hctx.SaveChanges();
        }

        public List<Habilidade> ListarTodas()
        {
            return hctx.Habilidades.ToList();
        }
    }
}
