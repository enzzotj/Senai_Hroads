﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Senai.Hroads.Domains
{
    public partial class Classe
    {
        public Classe()
        {
            Personagems = new HashSet<Personagem>();
        }

        public int IdClasse { get; set; }
        public string TipoClasse { get; set; }

        public virtual ICollection<Personagem> Personagems { get; set; }
    }
}
