using eSports.Entidades;
using eSports.Excepciones;
using eSports.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSport.AccesoDatos.Repositorios
{
    public class SqlJuegoRepositorio : IJuegoRepository
    {
        public ESportContext context { get; set; }
        public SqlJuegoRepositorio()
        {
            context = new ESportContext();
        }

        public void Add(Juego item)
        {
            try
            {
                context.Juegos.Add(item);
                context.SaveChanges();
            }
            catch (Exception)
            {

                throw new JuegoException("ERROR: No debe repetir ambos valores");
            }
            
        }

        public void Delete(Juego item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Juego> GetAll()
        {
            return context.Juegos;
        }

        public Juego GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Juego item)
        {
            throw new NotImplementedException();
        }
    }
}
