using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSports.Entidades
{
    [PrimaryKey(nameof(Nombre), nameof(JugadoresPorEquipo))]
    public class Juego
    {
        public string Nombre { get; set; }
        [Column("Jugadores por equipo")]
        public int JugadoresPorEquipo { get; set; }
    }
}
