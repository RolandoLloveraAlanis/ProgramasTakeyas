using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinarioBusqueda
{
    class ClaseABB<Tipo> where Tipo : IComparable<Tipo>, IEquatable<Tipo>
    {
        ClaseNodo<Tipo> _raiz;


        public ClaseNodo<Tipo> Raiz
        {
            get { return _raiz; }
            set { _raiz = value; }
        }



        public ClaseABB()
        {
            Raiz = null;
        }
        //INSERTAR
        public void InsertarNodo(Tipo Objeto)
        {

            ClaseNodo<Tipo> hoja = new ClaseNodo<Tipo>(Objeto);
            if (Vacia)
            {
                Raiz = hoja;
            }
            else
            {
                ClaseNodo<Tipo> current = Raiz;
                bool noInsertado = true;
                while (noInsertado)
                {
                    if (Objeto.CompareTo(current.ObjetoConDatos) == -1)
                    {
                        if (current.HijoIzq == null)
                        {
                            current.HijoIzq= hoja;
                            noInsertado = false;
                        }
                        else
                        {
                            current = current.HijoIzq;
                        }
                    }
                    else if (Objeto.CompareTo(current.ObjetoConDatos) == 1)
                    {
                        if (current.HijoDer == null)
                        {
                            current.HijoDer = hoja;
                            noInsertado = false;
                        }
                        else
                        {
                            current = current.HijoDer;
                        }
                    }
                    else
                    {
                        throw new Exception("No es posible registrar, el dato ya existe");
                    }
                }
            }
        }
        //ELIMINAR
        //  public Tipo EliminarNodo(Tipo objeto) {}

        //BUSCAR
        //public Tipo BuscarNodo(Tipo objeto) { }

        //VACIAR
        public void Vaciar() { Raiz = null; }

        //VACIO
        public bool Vacia 
        {
            get
            {
                return Raiz == null;
            }
        }


        private IEnumerable<Tipo> MPRecorrerPreOrden(ClaseNodo<Tipo> nodoActual)
        {
            if (nodoActual != null)
            {
                yield return nodoActual.ObjetoConDatos;

                foreach (Tipo t in MPRecorrerPreOrden(nodoActual.HijoIzq))
                {
                    yield return t;
                }
                foreach (Tipo t in MPRecorrerPreOrden(nodoActual.HijoDer))
                {
                    yield return t;
                }
            }
        }
        private IEnumerable<Tipo> MPRecorrerPostOrden(ClaseNodo<Tipo> nodoActual)
        {
            if (nodoActual != null)
            {
                foreach (Tipo t in MPRecorrerPostOrden(nodoActual.HijoIzq))
                {
                    yield return t;
                }
                foreach (Tipo t in MPRecorrerPostOrden(nodoActual.HijoDer))
                {
                    yield return t;
                }
                yield return nodoActual.ObjetoConDatos;
            }
        }
        private IEnumerable<Tipo> MPRecorrerInOrden(ClaseNodo<Tipo> nodoActual)
        {
            if (nodoActual != null)
            {
                foreach (Tipo t in MPRecorrerInOrden(nodoActual.HijoIzq))
                {
                    yield return t;
                }
                yield return nodoActual.ObjetoConDatos;
                foreach (Tipo t in MPRecorrerInOrden(nodoActual.HijoDer))
                {
                    yield return t;
                }
            }
        }


        public IEnumerable<Tipo> RecorrerPreOrden()
        {
            return this.MPRecorrerPreOrden(Raiz);
        }
        public IEnumerable<Tipo> RecorrerPostOrden()
        {
            return this.MPRecorrerPostOrden(Raiz);
        }
        public IEnumerable<Tipo> RecorrerInOrden()
        {
            return this.MPRecorrerInOrden(Raiz);
        }

        public IEnumerable<Tipo> Iterador(Sorting sorting)
        {
            switch (sorting)
            {
                case Sorting.PreOrden:
                    return MPRecorrerPreOrden(Raiz);
                case Sorting.PostOrden:
                    return MPRecorrerPostOrden(Raiz);
                case Sorting.InOrden:
                    return MPRecorrerInOrden(Raiz);
            }
            throw new Exception("Iterador no encontrado");
        }

        public enum Sorting
        {
            PreOrden, PostOrden, InOrden
        }
        ~ClaseABB()
        {

        }
    }
}
