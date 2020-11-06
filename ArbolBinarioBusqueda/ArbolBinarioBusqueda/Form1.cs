using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbolBinarioBusqueda
{
    public partial class Form1 : Form
    {
        ClaseABB<Rosticeria> ABB = new ClaseABB<Rosticeria>();
       static  ABB abb = new ABB();
        public Form1()
        {
            InitializeComponent();
            rdbIn.Checked = true;
        }
        public void MostrarRosticeria()
        {
            if(rdbIn.Checked==true)
            {
                dgvRosticeria.Rows.Clear();
                foreach (Rosticeria ros in ABB.Iterador(ClaseABB<Rosticeria>.Sorting.InOrden))
                {
                    dgvRosticeria.Rows.Add(ros.RFC, ros.Nombre, ros.IngresoAnual, ros.NumEmpleados, ros.Distribuidor, ros.ConvertirDeboolaString(), ros.Moneda, ros.Inauguracion, ros.Foto);
                }
            }
            else if(rdbPost.Checked==true)
            {
                dgvRosticeria.Rows.Clear();
                foreach (Rosticeria ros in ABB.Iterador(ClaseABB<Rosticeria>.Sorting.PostOrden))
                {
                    dgvRosticeria.Rows.Add(ros.RFC, ros.Nombre, ros.IngresoAnual, ros.NumEmpleados, ros.Distribuidor, ros.ConvertirDeboolaString(), ros.Moneda, ros.Inauguracion, ros.Foto);
                }
            }
            else if(rdbPre.Checked==true)
            {
                dgvRosticeria.Rows.Clear();
                foreach (Rosticeria ros in ABB.Iterador(ClaseABB<Rosticeria>.Sorting.PreOrden))
                {
                    dgvRosticeria.Rows.Add(ros.RFC, ros.Nombre, ros.IngresoAnual, ros.NumEmpleados, ros.Distribuidor, ros.ConvertirDeboolaString(), ros.Moneda, ros.Inauguracion, ros.Foto);
                }
            }
        
        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            ABB.Vaciar();
            string[] tipoMoneda = { "Peso", "Dollar", "Ambos" };
            string[] domicilio = { "Si", "No" };
            Random ram = new Random();
            Rosticeria r;
            double ProbTrue = 0.2;
            DateTime dt = DateTime.Now;
            for (int i = 0; i < 10; i++)
            {
                r = new Rosticeria();
                r.RFC = Guid.NewGuid().ToString().Substring(0, 5);
                r.Nombre = Guid.NewGuid().ToString().Substring(0, 13);
                r.IngresoAnual = ram.Next(1, 120);
                r.NumEmpleados = ram.Next(1, 10);
                r.Distribuidor = (char)ram.Next('A', 'D');
                r.Inauguracion = dt;
                dt = dt.AddMinutes(1);
                r.ServicioDomicilio = ram.NextDouble() < ProbTrue;
                r.Moneda = tipoMoneda[ram.Next(0, 3)];
                r.Foto = "C:/Users/rolan/Pictures/c930159287293d31eccf3a708dcbe632";

                ABB.InsertarNodo(r);
                MostrarRosticeria();

            }
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            if (!ABB.Vacia) // Si no está vacío ..
                DibujarFigura(); // Invoca el método para dibujar la figura
            else
                MessageBox.Show("Árbol Binario de Búsqueda vacío", "E R R O R",
               MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void DibujarFigura()
        {

                string Resultado=  CrearArchivoDot();

            
                InvocaDibujar(); 
              MessageBox.Show("Código para generar el archivo FIGURA.jpg con la imagen:\n\n" + Resultado + "\n\nEjecutar mediante: DOT -TJPG -O \\Figura", "CREACIÓN DEL ARCHIVO EN LENGUAJE DOT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 CrearNuevaFormaConFigura();
        }

        private string CrearArchivoDot()
        {
                string Resultado = "";
            abb.CrearArchivoDot(ref Resultado);
                 System.IO.StreamWriter AliasArchivo = new
                 System.IO.StreamWriter("\\Figura");
                   AliasArchivo.WriteLine(Resultado);
                  AliasArchivo.Close();
             return (Resultado);
        }

        private void InvocaDibujar()
        {
            // El archivo por lotes DIBUJAR.bat contiene el siguiente código:
            // @echo off
            // del \Figura.jpg
            // \"Archivos de programa\Graphviz 2.28"\bin\DOT -Tjpg -O \Figura
            // Ejecuta DIBUJAR.bat ubicado en la carpeta raíz de la unidad de disco
            System.Diagnostics.Process.Start("H:\\Datos\\DIBUJAR.bat");
        }

        private void CrearNuevaFormaConFigura()
        {

            System.IO.FileStream AliasFigura;
            try // Intenta abrir el archivo
            {
                AliasFigura = new System.IO.FileStream("\\Figura.jpg",
               System.IO.FileMode.Open, System.IO.FileAccess.Read);
            }
            catch (Exception x)
            {
                MessageBox.Show("No se pudo abrir el archivo \\Figura.jpg", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try 
            {
                pbxArbol.Image = System.Drawing.Bitmap.FromStream(AliasFigura);
            }
            catch (Exception x) 
            {
                MessageBox.Show("No se pudo cargar la imagen del archivo \\Figura.jpg",
               "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AliasFigura.Close(); 
                return;
            }
            AliasFigura.Close();
 pbxArbol.Refresh();
        }

    }
}
