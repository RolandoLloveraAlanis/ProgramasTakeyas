using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rosticeria1
{
    class ClaseListaSimpleOrdenada<Rosticeria> where Rosticeria: IEquatable<Rosticeria>,IComparable<Rosticeria>
    {
        private ClaseNodo<Rosticeria> _nodoInicial;
         
        public ClaseListaSimpleOrdenada()
        {
            this.NodoInicial = null;
        }
        private ClaseNodo<Rosticeria> NodoInicial
        {
            get { return _nodoInicial; }
            set { _nodoInicial = value; }
        }
        public bool Vacia
        {
            get
            {
                if (this.NodoInicial == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
           
        }
        public void AgregarNodo(Rosticeria otraRosticeria)
        {
          
            if(Vacia)
            {
                //ALtaAListaVacia
                ClaseNodo<Rosticeria> nodoNuevo = new ClaseNodo<Rosticeria>();
                nodoNuevo.ObjetoConDatos = otraRosticeria;
                nodoNuevo.Siguiente = null;
                this.NodoInicial = nodoNuevo;
                return;
            }
            else
            {
                ClaseNodo<Rosticeria> nodoActual = new ClaseNodo<Rosticeria>();
                nodoActual = this.NodoInicial;
                ClaseNodo<Rosticeria> nodoPrevio = new ClaseNodo<Rosticeria>();
                do
                {
                  if (otraRosticeria.Equals(nodoActual.ObjetoConDatos))
                  {
                    throw new Exception("Duplicado");
                  }
                    else if (otraRosticeria.CompareTo(nodoActual.ObjetoConDatos)==-1)
                    {
                        if(nodoActual.Equals(NodoInicial))
                        {
                            //Alta al principio
                            ClaseNodo<Rosticeria> nodoNuevo = new ClaseNodo<Rosticeria>();
                            nodoNuevo.ObjetoConDatos = otraRosticeria;
                            nodoNuevo.Siguiente = this.NodoInicial;
                            this.NodoInicial = nodoNuevo;
                            return;
                        }
                        else
                        {
                            //Alta intermedia
                            ClaseNodo<Rosticeria> nodoNuevo = new ClaseNodo<Rosticeria>();
                            nodoNuevo.ObjetoConDatos = otraRosticeria;
                            nodoNuevo.Siguiente = nodoPrevio.Siguiente;
                            nodoPrevio.Siguiente = nodoNuevo;
                            return;
                        }
                    }
                    else
                    {
                        nodoPrevio = nodoActual;
                        nodoActual = nodoActual.Siguiente;
                    }
                  
                } while (nodoActual != null);
                ClaseNodo<Rosticeria> NodoNuevo = new ClaseNodo<Rosticeria>();
                NodoNuevo.ObjetoConDatos = otraRosticeria;
                nodoPrevio.Siguiente = NodoNuevo;
                NodoNuevo.Siguiente = null;

            }
           

        }
         public Rosticeria ElimidarNodo(Rosticeria otraRosticeria)
        {
            if (Vacia)
            {
                throw new Exception("La lista se encuentra vacia");
            }
            else
            {
                ClaseNodo<Rosticeria> nodoActual = new ClaseNodo<Rosticeria>();
                nodoActual = this.NodoInicial;
                ClaseNodo<Rosticeria> nodoPrevio = new ClaseNodo<Rosticeria>();
                Rosticeria objetoEliminado;
                do
                {
                    if (otraRosticeria.Equals(nodoActual.ObjetoConDatos))
                    {
                        if (nodoActual.Equals(NodoInicial))
                        {
                            NodoInicial = nodoActual.Siguiente;
                            objetoEliminado = nodoActual.ObjetoConDatos;
                            nodoActual = null;
                            return (objetoEliminado);
                        }
                        else
                        {
                            if(nodoActual.Siguiente != null)
                            {
                                nodoPrevio.Siguiente = nodoActual.Siguiente;
                                objetoEliminado = nodoActual.ObjetoConDatos;
                                nodoActual = null;
                                return (objetoEliminado);
                            }
                            else
                            {
                                nodoPrevio.Siguiente = nodoActual.Siguiente;
                                objetoEliminado = nodoActual.ObjetoConDatos;
                                nodoActual = null;
                                return (objetoEliminado);
                            }
                          
                        }
                    }
                    else
                    {
                        if(otraRosticeria.CompareTo(nodoActual.ObjetoConDatos) == -1)
                        {
                            throw new Exception("No se encuentra en existencia");
                        }
                        else
                        {
                            nodoPrevio = nodoActual;
                            nodoActual = nodoActual.Siguiente;
                        }
                    }
                } while (nodoActual != null);
            }
            throw new Exception("No se encuentra en existencia");
        }
       public Rosticeria BuscarNodo(Rosticeria otraRosticeria)
        {
            if(Vacia)
            {
                throw new Exception("Lista vacia");
            }
            else
            {
                ClaseNodo<Rosticeria> nodoActual = new ClaseNodo<Rosticeria>();
                 nodoActual = NodoInicial;
                do
                {
                    if(otraRosticeria.Equals(nodoActual.ObjetoConDatos))
                    {
                        return(nodoActual.ObjetoConDatos);
                       
                    }
                    else if ((otraRosticeria.CompareTo(nodoActual.ObjetoConDatos)) == -1)
                    {
                        throw new Exception("No existe");
                    }
                    else
                    {
                        nodoActual = nodoActual.Siguiente;
                    }
                } while (nodoActual != null);
                throw new Exception("No encontrado");
            }
        }

        public void Vaciar()
        {
            if(Vacia)
            {
                throw new Exception("Esta vacia");
            }
            else
            {
                ClaseNodo<Rosticeria> nodoPrevio = new ClaseNodo<Rosticeria>();
                ClaseNodo<Rosticeria> nodoActual = new ClaseNodo<Rosticeria>();
                nodoActual = NodoInicial;
                do
                {
                    nodoPrevio = nodoActual;
                    nodoActual = nodoActual.Siguiente;
                    nodoPrevio = null;
                } while (nodoActual != null);
                NodoInicial = null;
                throw new Exception("Se han borrado los datos correctamente");
            }
        }
        public IEnumerator<Rosticeria> GetEnumerator()
        {
            if (Vacia)
            {
                yield break;
            }
            else
            {
                ClaseNodo<Rosticeria> nodoActual = new ClaseNodo<Rosticeria>();
                nodoActual = NodoInicial;
                do
                {
                    yield return (nodoActual.ObjetoConDatos);
                    nodoActual = nodoActual.Siguiente;
                } while (nodoActual != null);
                yield break;
            }


        }

        ~ ClaseListaSimpleOrdenada()
        {
            try
            {
                Vaciar();
            }
            catch (Exception x)
            {
                
            }
            
        }
    }
}
