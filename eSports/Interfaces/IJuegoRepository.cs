using eSports.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSports.Interfaces
{
    public interface IJuegoRepository : IRepository<Juego>
    {
        public void Add(Juego item);
        public void Update(Juego item);
        public void Delete(Juego item);
        public Juego GetById(int id);
        public IEnumerable<Juego> GetAll();
    }
}

