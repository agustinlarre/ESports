using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSports.Excepciones
{
    public class JuegoException : Exception
    {
        public JuegoException() { }
        public JuegoException(string message) : base(message) { }
        public JuegoException(string message, Exception e) : base(message, e) { }
    }
}
