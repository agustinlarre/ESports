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
    [Owned]
    public class FichaDeEquipo
    {
        public Equipo equipo { get; set;}
        public string Descripcion { get; set; }
    }
}
