using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rosticeria1
{
    class ClaseNodo<Rosticeria>
    {
        private Rosticeria _objetoConDatos;
        private ClaseNodo<Rosticeria> _siguiente;
      
        public Rosticeria ObjetoConDatos
        {
            get { return _objetoConDatos; }
            set { _objetoConDatos = value; }
        }
        public ClaseNodo<Rosticeria> Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }
        ~ ClaseNodo()
        {

        }

    }
}
