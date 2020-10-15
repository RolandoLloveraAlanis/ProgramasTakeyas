using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rosticeria1
{
    public partial class Form1 : Form
    {
        ClaseNodo<Rosticeria> cn = new ClaseNodo<Rosticeria>();
        ClaseListaSimpleOrdenada<Rosticeria> CLSO = new ClaseListaSimpleOrdenada<Rosticeria>();
    
        public Form1()
        {
            InitializeComponent();
        }

        public void MostrarRosticeria()
        {
            dgvRosticeria.Rows.Clear();
            foreach (Rosticeria ros in CLSO)
            {
                dgvRosticeria.Rows.Add(ros.RFC,ros.Nombre, ros.IngresoAnual, ros.NumEmpleados, ros.Distribuidor, ros.ConvertirDeboolaString(), ros.Moneda, ros.Inauguracion, ros.Foto );
            }
        }
        private void imgRosticeria_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarRFC_Click(object sender, EventArgs e)
        {
            Rosticeria r = new Rosticeria();
            r.RFC = txtRFCBuscar.Text;

               
            MessageBox.Show("Se a encontrado con exito la rosticeria " + CLSO.BuscarNodo(r));
               
          
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Ya confirmó los datos?", "Aregrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if(string.IsNullOrEmpty(txtFoto.Text))
                {
                    MessageBox.Show("Inserte una foto");
                }
                else
                {
                    Rosticeria r = new Rosticeria();
                    try
                    {
                        r.RFC = txtRFC.Text;
                        r.Nombre = txtnombre.Text;
                        r.IngresoAnual = double.Parse(txtingreso.Text);
                        r.NumEmpleados = int.Parse(txtnumempleados.Text);
                        r.Distribuidor = char.Parse(cmbDistribuidor.Text);
                        r.Inauguracion = dtmInauguracion.Value;
                        r.ServicioDomicilio = chbServicio.Checked;
                        if (rdbPesos.Checked == true)
                        {
                            r.Moneda = rdbPesos.Text;
                        }
                        else if (rdbDollares.Checked == true)
                        {
                            r.Moneda = rdbDollares.Text;
                        }
                        else if (rdbAmbos.Checked == true)
                        {
                            r.Moneda = rdbAmbos.Text;
                        }


                        r.Foto = txtFoto.Text;



                        try
                        {
                            CLSO.AgregarNodo(r);
                            MessageBox.Show("Rosticeria insertada con exito");
                        }
                        catch (Exception x)
                        {
                            MessageBox.Show(x.Message);
                        }
                        MostrarRosticeria();

                    }
                    catch (Exception x)
                    {
                        MessageBox.Show(x.Message);
                    }


                    foreach (Control x in grb1.Controls)
                        if (x is TextBox)
                            x.Text = "";
                    cmbDistribuidor.Text = "";
                    rdbAmbos.Checked = false;
                    rdbDollares.Checked = false;
                    rdbPesos.Checked = false;
                    chbServicio.Checked = false;
                    imgRosticeria.Image = null;

                    txtnombre.Focus();
                    
                }

            }

                
            else
            {

                txtnombre.Focus();
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar los datos seleccionados?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                Rosticeria rAux = new Rosticeria();
                try
                {
                    DataGridViewRow currentRow = dgvRosticeria.CurrentRow;
                    if (currentRow == null)
                    {
                        MessageBox.Show("Seleccione una rosticeria de la tabla");
                        return;
                    }
                    rAux.RFC = dgvRosticeria.CurrentRow.Cells[0].Value.ToString();
                    rAux.Nombre = dgvRosticeria.CurrentRow.Cells[1].Value.ToString();
                    rAux.IngresoAnual = double.Parse(dgvRosticeria.CurrentRow.Cells[2].Value.ToString());
                    rAux.NumEmpleados = int.Parse(dgvRosticeria.CurrentRow.Cells[3].Value.ToString());

                    //Distribuidor
                    if (char.Parse(dgvRosticeria.CurrentRow.Cells[4].Value.ToString()) == 'A')
                    {
                        rAux.Distribuidor = 'A';
                    }
                    if (char.Parse(dgvRosticeria.CurrentRow.Cells[4].Value.ToString()) == 'B')
                    {
                        rAux.Distribuidor = 'B';
                    }
                    if (char.Parse(dgvRosticeria.CurrentRow.Cells[4].Value.ToString()) == 'C')
                    {
                        rAux.Distribuidor = 'C';
                    }
                    if (char.Parse(dgvRosticeria.CurrentRow.Cells[4].Value.ToString()) == 'D')
                    {
                        rAux.Distribuidor = 'D';
                    }

                    //Servicio a domicilio
                    if (dgvRosticeria.CurrentRow.Cells[5].Value.ToString() == "Si")
                    {
                        rAux.ServicioDomicilio = true;
                    }
                    if (dgvRosticeria.CurrentRow.Cells[5].Value.ToString() == "No")
                    {
                        rAux.ServicioDomicilio = false;
                    }


                    //Tipo de Moneda
                    if (dgvRosticeria.CurrentRow.Cells[6].Value.ToString() == "Pesos")
                    {
                        rAux.Moneda = "Pesos";
                    }
                    if (dgvRosticeria.CurrentRow.Cells[6].Value.ToString() == "Dollares")
                    {
                        rAux.Moneda = "Dollares";
                    }
                    if (dgvRosticeria.CurrentRow.Cells[6].Value.ToString() == "Ambos")
                    {
                        rAux.Moneda = "Ambos";
                    }
                    rAux.Inauguracion = DateTime.Parse(dgvRosticeria.CurrentRow.Cells[7].Value.ToString());
                    rAux.Foto = dgvRosticeria.CurrentRow.Cells[8].Value.ToString();

                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }

                if (MessageBox.Show("¿Está seguro que desea borrar esta rosticeria? \n" + rAux.Nombre, "ELIMINAR",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
              
                {
                    Rosticeria rosEliminada;
                    try
                    {
                        rosEliminada = CLSO.ElimidarNodo(rAux);
                        MessageBox.Show("Se a eliminado esta rosticeria " + "\n" + rAux.Nombre);


                        MostrarRosticeria();
                        foreach (Control x in grb1.Controls)
                            if (x is TextBox)
                                x.Text = "";
                        cmbDistribuidor.Text = "";
                        rdbAmbos.Checked = false;
                        rdbDollares.Checked = false;
                        rdbPesos.Checked = false;
                        chbServicio.Checked = false;
                        imgRosticeria.Image = null;

                        txtnombre.Focus();
                        if (CLSO.Vacia)
                        {
                            btnEliminar.Enabled = false;
                            btnVaciar.Enabled = false;
                        }

                    }
                    catch (Exception x)
                    {
                        MessageBox.Show(x.Message);
                    }
                    
                }

            }
            else
            {
                txtnombre.Focus();

            }
        }

        private void btnVaciar_Click_1(object sender, EventArgs e)
        {

            try
            {
                CLSO.Vaciar();

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            MostrarRosticeria();
        }

        private void btnBusccar_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog obtenerImagen = new OpenFileDialog();
                obtenerImagen.InitialDirectory = "C:\\";
                obtenerImagen.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png)";
                if (obtenerImagen.ShowDialog() == DialogResult.OK)
                {
                    imgRosticeria.ImageLocation = obtenerImagen.FileName;
                    txtFoto.Text = obtenerImagen.FileName;
                }
                else
                {
                    MessageBox.Show("No se selecciono ninguna foto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception x)
            {
                MessageBox.Show("No selecciono una foto"+ x);
            }
          
        }
        private void Cargarimagen(string ruta)
        {
            Bitmap foto = new Bitmap(ruta);
            imgRosticeria.SizeMode = PictureBoxSizeMode.StretchImage;
            imgRosticeria.Image = (Image)foto;
            imgRosticeria.Refresh();
        }

        private void dgvRosticeria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRFC.Text = dgvRosticeria.CurrentRow.Cells[0].Value.ToString();
            txtnombre.Text = dgvRosticeria.CurrentRow.Cells[1].Value.ToString();
            txtingreso.Text = dgvRosticeria.CurrentRow.Cells[2].Value.ToString();
            txtnumempleados.Text = dgvRosticeria.CurrentRow.Cells[3].Value.ToString();
            cmbDistribuidor.Text = dgvRosticeria.CurrentRow.Cells[4].Value.ToString();
            if (dgvRosticeria.CurrentRow.Cells[5].Value.ToString() == "Si")
            {
                chbServicio.Checked = true;
            }
                
            if (dgvRosticeria.CurrentRow.Cells[6].Value.ToString() == "Pesos")
            {
                rdbPesos.Checked = true;
            }
            if (dgvRosticeria.CurrentRow.Cells[6].Value.ToString() == "Dollares")
            {
                rdbDollares.Checked = true;
            }
            if (dgvRosticeria.CurrentRow.Cells[6].Value.ToString() == "Ambos")
            {
                rdbAmbos.Checked = true;
            }
            dtmInauguracion.Text = dgvRosticeria.CurrentRow.Cells[7].Value.ToString();
            txtFoto.Text = dgvRosticeria.CurrentRow.Cells[8].Value.ToString();
            Cargarimagen(dgvRosticeria.CurrentRow.Cells[8].Value.ToString());
          
        }
    }
}
