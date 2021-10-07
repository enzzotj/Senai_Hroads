﻿using Senai.Hroads.Contexts;
using Senai.Hroads.Domains;
using Senai.Hroads.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Hroads.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        HroadsContext hctx = new HroadsContext();
        public void Atualizar(int id, TipoUsuario TipoUsuAtualizado)
        {
            TipoUsuario TipoUsuBuscada = hctx.TipoUsuarios.Find(id);

            if (TipoUsuBuscada.Permissao != null)
            {

                TipoUsuBuscada.Permissao = TipoUsuAtualizado.Permissao;

                hctx.TipoUsuarios.Update(TipoUsuBuscada);

                hctx.SaveChanges();
            }
        }

        public TipoUsuario BuscarPorId(int id)
        {
            return hctx.TipoUsuarios.FirstOrDefault(t => t.IdTipoUsuario == id);
        }

        public void Cadastrar(TipoUsuario novoTipoUsu)
        {
            hctx.TipoUsuarios.Add(novoTipoUsu);

            hctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            hctx.TipoUsuarios.Remove(BuscarPorId(id));

            hctx.SaveChanges();
        }

        public List<TipoUsuario> ListarTodas()
        {
            return hctx.TipoUsuarios.ToList();
        }
    }
}