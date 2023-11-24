using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenV3.Clases
{
    public class Nodo
    {
        private Gato Gato;
        private Nodo Siguiente;

        public Gato _gato;
        public Nodo _siguiente;

        public Nodo(Gato gatito1)
        {
            _gato = gatito1;
            _siguiente = null;
        }

        public Nodo(Gato gatito1, Nodo siguiente)
        {
            _gato = gatito1;
            _siguiente = siguiente;
        }

    }
}
