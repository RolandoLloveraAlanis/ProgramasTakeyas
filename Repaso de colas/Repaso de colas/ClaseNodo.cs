using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_de_colas
{
    class ClaseNodo<Tipo>
    {
        ClaseNodo<Tipo> _siguiente;
        Tipo _objetoConDatos;

        public ClaseNodo<Tipo> Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }
        public Tipo ObjetoConDatos
        {
            get { return _objetoConDatos; }
            set { _objetoConDatos = value; }
        }
        ~ClaseNodo()
        {

        }
        public ClaseNodo()
        {

        }


    }
}
