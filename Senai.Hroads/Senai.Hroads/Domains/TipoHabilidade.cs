using System;
using System.Collections.Generic;

#nullable disable

namespace Senai.Hroads.Domains
{
    public partial class TipoHabilidade
    {
        public TipoHabilidade()
        {
            Habilidades = new HashSet<Habilidade>();
        }

        public int IdTipoHab { get; set; }
        public string TipoHab { get; set; }

        public virtual ICollection<Habilidade> Habilidades { get; set; }
    }
}
