using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSports.Entidades
{
    public class TorneoPorGrupos : Torneo
    {
        [Column("Cantidad de grupos")]
        public int CantidadGrupos { get; set; }
    }
}
