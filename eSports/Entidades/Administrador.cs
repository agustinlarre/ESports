using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSports.Entidades
{
    public class Administrador : Usuario
    {
        public string Nombre { get; set; }
        public string Password { get; set; }
        public Administrador() { }

    }
}
