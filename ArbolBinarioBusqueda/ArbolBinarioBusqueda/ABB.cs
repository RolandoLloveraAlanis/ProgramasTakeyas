using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinarioBusqueda
{
    class ABB: ClaseABB<Rosticeria> 
    {
        private void RecorrerNodos(ClaseNodo<Rosticeria> NodoActual, ref string Resultado)
        {
            if (NodoActual != null)
            {
                if (NodoActual.HijoIzq != null)
                    Resultado = Resultado + "\n" + NodoActual.ObjetoConDatos.ToString() + "->" +
                   NodoActual.HijoIzq.ObjetoConDatos.ToString() + ";";
                if (NodoActual.HijoDer != null)
                    Resultado = Resultado + "\n" + NodoActual.ObjetoConDatos.ToString() + "->" +
                   NodoActual.HijoDer.ObjetoConDatos.ToString() + ";";
                     RecorrerNodos(NodoActual.HijoIzq, ref Resultado); // Llamada recursiva para recorrer el subárbol izquierdo
                     RecorrerNodos(NodoActual.HijoDer, ref Resultado); // Llamada recursiva para recorrer el subárbol derecho
            }
        }

        public void CrearArchivoDot(ref string Resultado)
        {
            if (!Vacia) // Si no está vacío ...
            {
                Resultado = Resultado + "digraph Figura {";
                Resultado = Resultado + "\nRaíz->" + Raiz.ObjetoConDatos.ToString() + ";";
                RecorrerNodos(Raiz, ref Resultado);
                Resultado = Resultado + "\n}";
            }
        }
    }

}

