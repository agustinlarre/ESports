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
    public class Equipo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        [Required]
        public string Avatar { get; set; }

        public String Integrantes { get; set; }
        public FichaDeEquipo Ficha { get; set; }
    }
}
