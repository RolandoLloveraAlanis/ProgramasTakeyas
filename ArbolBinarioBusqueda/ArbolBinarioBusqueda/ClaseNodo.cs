using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinarioBusqueda
{
    class ClaseNodo<Tipo>
    {
        Tipo _objetoConDatos;
        ClaseNodo<Tipo> _HI;
        ClaseNodo<Tipo> _HD;

        public ClaseNodo<Tipo> HijoIzq
        {
            get { return _HI; }
            set { _HI = value; }
        }
        public ClaseNodo<Tipo> HijoDer
        {
            get { return _HD; }
            set { _HD = value; }
        }
        public Tipo ObjetoConDatos
        {
            get { return _objetoConDatos; }
            set { _objetoConDatos = value; }
        }

        public ClaseNodo(Tipo obj)
        {
            ObjetoConDatos = obj;
        }

        ~ClaseNodo()
        {

        }
    }
}
