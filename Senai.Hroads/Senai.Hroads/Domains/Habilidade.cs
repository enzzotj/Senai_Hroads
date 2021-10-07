using System;
using System.Collections.Generic;

#nullable disable

namespace Senai.Hroads.Domains
{
    public partial class Habilidade
    {
        public int IdHabilidade { get; set; }
        public int? IdTipoHab { get; set; }
        public string Nome { get; set; }

        public virtual TipoHabilidade IdTipoHabNavigation { get; set; }
    }
}
