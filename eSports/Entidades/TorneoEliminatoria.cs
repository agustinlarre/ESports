using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSports.Entidades
{
    public class TorneoEliminatoria : Torneo
    {
        [Column("Con empate")]
        public bool ConEmpate { get; set; }
    }
}
