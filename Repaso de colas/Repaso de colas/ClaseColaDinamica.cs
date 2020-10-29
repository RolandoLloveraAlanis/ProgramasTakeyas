using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_de_colas
{
    class ClaseColaDinamica<Tipo> where Tipo : IEquatable<Tipo>
    {
        ClaseNodo<Tipo> _Final;
        ClaseNodo<Tipo> _Frente;
        public ClaseNodo<Tipo> Frente
        {
            get { return _Frente; }
            set { _Frente = value; }
        }
        public ClaseNodo<Tipo> Final
        {
            get { return _Final; }
            set { _Final = value; }
        }

        public ClaseColaDinamica()
        {
            Frente = null;
            Final = null;
        }
        public bool Vacia
        {
            get
            {
                if (this.Frente == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        public void InsertarNodo(Tipo objeto)
        {
            ClaseNodo<Tipo> nuevoNodo = new ClaseNodo<Tipo>();
            nuevoNodo.ObjetoConDatos = objeto;

            if (Vacia)
            {
                Final = nuevoNodo;
                Frente = nuevoNodo;
            }
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoPrevio = new ClaseNodo<Tipo>();
                nodoActual = Frente;
                do
                {
                    if (objeto.Equals(nodoActual.ObjetoConDatos))
                    {
                        throw new Exception("Imposible insertar, dato en existencia");
                    }
                    else
                    {
                        nodoPrevio = nodoActual;
                        nodoActual = nodoActual.Siguiente;
                    }
                } while (nodoActual != null);
                nodoPrevio.Siguiente = nuevoNodo;
                Final = nuevoNodo;
            }
        }
        public Tipo Eliminar()
        {
            if (Vacia)
            {
                throw new Exception("No se encuentra la rosticeria que desea eliminar");
            }
            else
            {
                ClaseNodo<Tipo> nodoAux = Frente;
                Tipo objetoEliminado = nodoAux.ObjetoConDatos;
                Frente = Frente.Siguiente;
                nodoAux = null;
                return objetoEliminado;
            }
        }
        public Tipo EliminarNodo(Tipo objeto)
        {
            if (Vacia)
            {
                throw new Exception("La lista esta vacia");
            }
            else
            {
                ClaseNodo<Tipo> aux = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> prev = new ClaseNodo<Tipo>();
                aux = Frente;
                prev = null;
                do
                {
                    if (objeto.Equals(aux.ObjetoConDatos))
                    {
                        if (prev == null)
                        {
                            return Eliminar();
                        }
                        else
                        {
                            Tipo objetoRetorno = aux.ObjetoConDatos;
                            if (aux == Final)
                            {
                                Final = prev;
                            }
                            else
                            {
                                prev.Siguiente = aux.Siguiente;
                                return objetoRetorno;
                            }
                        }

                    }
                } while (aux != null);
                throw new Exception("No se encontro la rosticeria que se desea eliminar");
            }
        }
        public Tipo BuscarNodo(Tipo objeto)
        {
            if (Vacia)
            {
                throw new Exception("La lista esta vacia");
            }
            else
            {
                ClaseNodo<Tipo> nodoActual = Frente;
                do
                {
                    nodoActual = nodoActual.Siguiente;
                } while (nodoActual != null);
                throw new Exception("No se encontro la rosticeria");
            }
        }
        public IEnumerator<Tipo> GetEnumerator()
        {
            ClaseNodo<Tipo> nodoActual = Frente;
            while (nodoActual != null)
            {
                yield return nodoActual.ObjetoConDatos;
                nodoActual = nodoActual.Siguiente;
            }
            yield break;
        }
        public void Vaciar()
        {
            if (Vacia)
            {

            }
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                nodoActual = Frente;
                ClaseNodo<Tipo> nodoAux = new ClaseNodo<Tipo>();
                do
                {
                    nodoAux = nodoActual;
                    nodoActual = nodoActual.Siguiente;
                    nodoAux = null;
                } while (nodoActual != null);
                Frente = null;
                Final = null;

            }
        }



        ~ClaseColaDinamica()
        {
            this.Vaciar();
        }
    }
}
