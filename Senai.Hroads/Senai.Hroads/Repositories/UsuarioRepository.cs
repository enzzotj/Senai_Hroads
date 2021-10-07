﻿using Microsoft.EntityFrameworkCore;
using Senai.Hroads.Contexts;
using Senai.Hroads.Domains;
using Senai.Hroads.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Hroads.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        HroadsContext hctx = new HroadsContext();

        public void Atualizar(int id, Usuario UsuarioAtualizado)
        {
            Usuario UsuarioBuscado = hctx.Usuarios.Find(id);

            if (UsuarioBuscado.Email != null)
            {

                UsuarioBuscado.Email = UsuarioAtualizado.Email;

                hctx.Usuarios.Update(UsuarioBuscado);

                hctx.SaveChanges();
            }
        }

        public Usuario BuscarPorId(int id)
        {
            return hctx.Usuarios.FirstOrDefault(u => u.IdUsuario == id);
        }

        public void Cadastrar(Usuario novoUsuario)
        {
            hctx.Usuarios.Add(novoUsuario);

            hctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            hctx.Usuarios.Remove(BuscarPorId(id));

            hctx.SaveChanges();
        }

        public List<Usuario> ListarTodas()
        {
            return hctx.Usuarios.ToList();
        }

        public Usuario Logar(string email, string senha)
        {
            return hctx.Usuarios.Include(u => u.IdTipoUsuarioNavigation).FirstOrDefault(u => u.Email == email && u.Senha == senha);

        }
    }
}
