using eSports.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSport.AccesoDatos
{
    public class ESportContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Juego> Juegos { get; set; }
        public DbSet<Torneo> Torneos { get; set; }
        public DbSet<TorneoEliminatoria> TorneosEliminatorias { get; set; }
        public DbSet<TorneoPorGrupos> TorneosGrupos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string cadenaConexion =
                @"SERVER=(localdb)\MSsqlLocaldb;
                DATABASE=eSportManagerV2;
                INTEGRATED SECURITY=TRUE;
                ENCRYPT=False"; //Puede evitar problemas si no hay un certificado y se usa SSL
            optionsBuilder.UseSqlServer(cadenaConexion)
                .EnableDetailedErrors();
        }
    }
}
