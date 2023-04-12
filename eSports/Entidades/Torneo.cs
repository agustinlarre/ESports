using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSports.Entidades
{
    public abstract class Torneo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Juego Juego { get; set; }
        public List<Equipo> equipos { get; set; }
        public Equipo Ganador { get; set; }
        public Torneo() { }
    }
}
