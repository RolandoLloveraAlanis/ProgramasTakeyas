namespace ArbolBinarioBusqueda
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dgvRosticeria = new System.Windows.Forms.DataGridView();
            this.RFC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IngresoAnual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDeEmpleados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distribuidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServicioADomicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inauguracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.bntEliminarPrimero = new System.Windows.Forms.Button();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtFoto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rdbAmbos = new System.Windows.Forms.RadioButton();
            this.rdbDollares = new System.Windows.Forms.RadioButton();
            this.rdbPesos = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnumempleados = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtingreso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.imgRosticeria = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chbServicio = new System.Windows.Forms.CheckBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.dtmInauguracion = new System.Windows.Forms.DateTimePicker();
            this.cmbDistribuidor = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnBuscarRFC = new System.Windows.Forms.Button();
            this.txtRFCBuscar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pbxArbol = new System.Windows.Forms.PictureBox();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbPre = new System.Windows.Forms.RadioButton();
            this.rdbPost = new System.Windows.Forms.RadioButton();
            this.rdbIn = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRosticeria)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgRosticeria)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArbol)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(713, 71);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 98);
            this.btnGenerar.TabIndex = 30;
            this.btnGenerar.Text = "Generar datos aleatorios";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dgvRosticeria
            // 
            this.dgvRosticeria.AllowUserToDeleteRows = false;
            this.dgvRosticeria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRosticeria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RFC,
            this.Nombre,
            this.IngresoAnual,
            this.NumeroDeEmpleados,
            this.Distribuidor,
            this.ServicioADomicilio,
            this.Moneda,
            this.Inauguracion,
            this.Foto});
            this.dgvRosticeria.EnableHeadersVisualStyles = false;
            this.dgvRosticeria.Location = new System.Drawing.Point(15, 288);
            this.dgvRosticeria.Name = "dgvRosticeria";
            this.dgvRosticeria.ReadOnly = true;
            this.dgvRosticeria.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRosticeria.Size = new System.Drawing.Size(667, 150);
            this.dgvRosticeria.TabIndex = 32;
            // 
            // RFC
            // 
            this.RFC.HeaderText = "RFC";
            this.RFC.Name = "RFC";
            this.RFC.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 70;
            // 
            // IngresoAnual
            // 
            this.IngresoAnual.HeaderText = "Ingreso Anual";
            this.IngresoAnual.Name = "IngresoAnual";
            this.IngresoAnual.ReadOnly = true;
            this.IngresoAnual.Width = 70;
            // 
            // NumeroDeEmpleados
            // 
            this.NumeroDeEmpleados.HeaderText = "Numero de empleados";
            this.NumeroDeEmpleados.Name = "NumeroDeEmpleados";
            this.NumeroDeEmpleados.ReadOnly = true;
            this.NumeroDeEmpleados.Width = 70;
            // 
            // Distribuidor
            // 
            this.Distribuidor.HeaderText = "Distribuidor";
            this.Distribuidor.Name = "Distribuidor";
            this.Distribuidor.ReadOnly = true;
            this.Distribuidor.Width = 70;
            // 
            // ServicioADomicilio
            // 
            this.ServicioADomicilio.HeaderText = "Servicio a domicilio";
            this.ServicioADomicilio.Name = "ServicioADomicilio";
            this.ServicioADomicilio.ReadOnly = true;
            this.ServicioADomicilio.Width = 70;
            // 
            // Moneda
            // 
            this.Moneda.HeaderText = "Moneda";
            this.Moneda.Name = "Moneda";
            this.Moneda.ReadOnly = true;
            this.Moneda.Width = 60;
            // 
            // Inauguracion
            // 
            this.Inauguracion.HeaderText = "Inauguracion";
            this.Inauguracion.Name = "Inauguracion";
            this.Inauguracion.ReadOnly = true;
            this.Inauguracion.Width = 80;
            // 
            // Foto
            // 
            this.Foto.HeaderText = "Foto";
            this.Foto.Name = "Foto";
            this.Foto.ReadOnly = true;
            this.Foto.Width = 50;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(677, 268);
            this.tabControl1.TabIndex = 31;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grb1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(669, 242);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registrar rosticeria";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grb1
            // 
            this.grb1.Controls.Add(this.bntEliminarPrimero);
            this.grb1.Controls.Add(this.txtRFC);
            this.grb1.Controls.Add(this.label8);
            this.grb1.Controls.Add(this.btnVaciar);
            this.grb1.Controls.Add(this.btnEliminar);
            this.grb1.Controls.Add(this.txtFoto);
            this.grb1.Controls.Add(this.label7);
            this.grb1.Controls.Add(this.rdbAmbos);
            this.grb1.Controls.Add(this.rdbDollares);
            this.grb1.Controls.Add(this.rdbPesos);
            this.grb1.Controls.Add(this.label6);
            this.grb1.Controls.Add(this.label1);
            this.grb1.Controls.Add(this.txtnumempleados);
            this.grb1.Controls.Add(this.label2);
            this.grb1.Controls.Add(this.txtingreso);
            this.grb1.Controls.Add(this.label3);
            this.grb1.Controls.Add(this.label4);
            this.grb1.Controls.Add(this.imgRosticeria);
            this.grb1.Controls.Add(this.label5);
            this.grb1.Controls.Add(this.chbServicio);
            this.grb1.Controls.Add(this.txtnombre);
            this.grb1.Controls.Add(this.dtmInauguracion);
            this.grb1.Controls.Add(this.cmbDistribuidor);
            this.grb1.Location = new System.Drawing.Point(6, 6);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(660, 231);
            this.grb1.TabIndex = 15;
            this.grb1.TabStop = false;
            this.grb1.Text = "Registro";
            // 
            // bntEliminarPrimero
            // 
            this.bntEliminarPrimero.BackColor = System.Drawing.Color.OrangeRed;
            this.bntEliminarPrimero.Location = new System.Drawing.Point(293, 188);
            this.bntEliminarPrimero.Name = "bntEliminarPrimero";
            this.bntEliminarPrimero.Size = new System.Drawing.Size(191, 23);
            this.bntEliminarPrimero.TabIndex = 26;
            this.bntEliminarPrimero.Text = "Eliminar primer rosticeria agregada";
            this.bntEliminarPrimero.UseVisualStyleBackColor = false;
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(121, 33);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(132, 20);
            this.txtRFC.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(118, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "RFC";
            // 
            // btnVaciar
            // 
            this.btnVaciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVaciar.Location = new System.Drawing.Point(212, 188);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(75, 23);
            this.btnVaciar.TabIndex = 23;
            this.btnVaciar.Text = "Vaciar";
            this.btnVaciar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Location = new System.Drawing.Point(483, 188);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(168, 23);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar rosticeria seleccionada";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // txtFoto
            // 
            this.txtFoto.Enabled = false;
            this.txtFoto.Location = new System.Drawing.Point(278, 112);
            this.txtFoto.Name = "txtFoto";
            this.txtFoto.Size = new System.Drawing.Size(173, 20);
            this.txtFoto.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Ruta de foto";
            // 
            // rdbAmbos
            // 
            this.rdbAmbos.AutoSize = true;
            this.rdbAmbos.Location = new System.Drawing.Point(140, 150);
            this.rdbAmbos.Name = "rdbAmbos";
            this.rdbAmbos.Size = new System.Drawing.Size(57, 17);
            this.rdbAmbos.TabIndex = 17;
            this.rdbAmbos.TabStop = true;
            this.rdbAmbos.Text = "Ambos";
            this.rdbAmbos.UseVisualStyleBackColor = true;
            // 
            // rdbDollares
            // 
            this.rdbDollares.AutoSize = true;
            this.rdbDollares.Location = new System.Drawing.Point(140, 131);
            this.rdbDollares.Name = "rdbDollares";
            this.rdbDollares.Size = new System.Drawing.Size(63, 17);
            this.rdbDollares.TabIndex = 16;
            this.rdbDollares.TabStop = true;
            this.rdbDollares.Text = "Dollares";
            this.rdbDollares.UseVisualStyleBackColor = true;
            // 
            // rdbPesos
            // 
            this.rdbPesos.AutoSize = true;
            this.rdbPesos.Location = new System.Drawing.Point(140, 112);
            this.rdbPesos.Name = "rdbPesos";
            this.rdbPesos.Size = new System.Drawing.Size(54, 17);
            this.rdbPesos.TabIndex = 15;
            this.rdbPesos.TabStop = true;
            this.rdbPesos.Text = "Pesos";
            this.rdbPesos.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tipo de moneda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtnumempleados
            // 
            this.txtnumempleados.Location = new System.Drawing.Point(9, 111);
            this.txtnumempleados.Name = "txtnumempleados";
            this.txtnumempleados.Size = new System.Drawing.Size(100, 20);
            this.txtnumempleados.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingreso Anual";
            // 
            // txtingreso
            // 
            this.txtingreso.Location = new System.Drawing.Point(9, 72);
            this.txtingreso.Name = "txtingreso";
            this.txtingreso.Size = new System.Drawing.Size(100, 20);
            this.txtingreso.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero de empleados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Distribuidor";
            // 
            // imgRosticeria
            // 
            this.imgRosticeria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgRosticeria.Location = new System.Drawing.Point(483, 12);
            this.imgRosticeria.Name = "imgRosticeria";
            this.imgRosticeria.Size = new System.Drawing.Size(171, 149);
            this.imgRosticeria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgRosticeria.TabIndex = 10;
            this.imgRosticeria.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Inauguracion";
            // 
            // chbServicio
            // 
            this.chbServicio.AutoSize = true;
            this.chbServicio.Location = new System.Drawing.Point(278, 36);
            this.chbServicio.Name = "chbServicio";
            this.chbServicio.Size = new System.Drawing.Size(184, 17);
            this.chbServicio.TabIndex = 9;
            this.chbServicio.Text = "¿Cuenta con servicio a domicilio?";
            this.chbServicio.UseVisualStyleBackColor = true;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(9, 33);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 5;
            // 
            // dtmInauguracion
            // 
            this.dtmInauguracion.Location = new System.Drawing.Point(6, 191);
            this.dtmInauguracion.Name = "dtmInauguracion";
            this.dtmInauguracion.Size = new System.Drawing.Size(200, 20);
            this.dtmInauguracion.TabIndex = 8;
            // 
            // cmbDistribuidor
            // 
            this.cmbDistribuidor.FormattingEnabled = true;
            this.cmbDistribuidor.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cmbDistribuidor.Location = new System.Drawing.Point(9, 150);
            this.cmbDistribuidor.Name = "cmbDistribuidor";
            this.cmbDistribuidor.Size = new System.Drawing.Size(56, 21);
            this.cmbDistribuidor.Sorted = true;
            this.cmbDistribuidor.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnBuscarRFC);
            this.tabPage2.Controls.Add(this.txtRFCBuscar);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(669, 242);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Buscar rosticeria";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnBuscarRFC
            // 
            this.btnBuscarRFC.Location = new System.Drawing.Point(334, 116);
            this.btnBuscarRFC.Name = "btnBuscarRFC";
            this.btnBuscarRFC.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarRFC.TabIndex = 16;
            this.btnBuscarRFC.Text = "Buscar";
            this.btnBuscarRFC.UseVisualStyleBackColor = true;
            // 
            // txtRFCBuscar
            // 
            this.txtRFCBuscar.Location = new System.Drawing.Point(127, 119);
            this.txtRFCBuscar.Name = "txtRFCBuscar";
            this.txtRFCBuscar.Size = new System.Drawing.Size(170, 20);
            this.txtRFCBuscar.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(127, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Ingrese RFC de la rosticeria";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pbxArbol);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(669, 242);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Dibujo del arbol";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pbxArbol
            // 
            this.pbxArbol.Location = new System.Drawing.Point(142, 3);
            this.pbxArbol.Name = "pbxArbol";
            this.pbxArbol.Size = new System.Drawing.Size(366, 233);
            this.pbxArbol.TabIndex = 0;
            this.pbxArbol.TabStop = false;
            // 
            // btnDibujar
            // 
            this.btnDibujar.Location = new System.Drawing.Point(713, 188);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(75, 23);
            this.btnDibujar.TabIndex = 33;
            this.btnDibujar.Text = "Dibujar";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbPre);
            this.groupBox1.Controls.Add(this.rdbPost);
            this.groupBox1.Controls.Add(this.rdbIn);
            this.groupBox1.Location = new System.Drawing.Point(704, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 100);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Metodo de Ordenamiento";
            // 
            // rdbPre
            // 
            this.rdbPre.AutoSize = true;
            this.rdbPre.Location = new System.Drawing.Point(9, 77);
            this.rdbPre.Name = "rdbPre";
            this.rdbPre.Size = new System.Drawing.Size(70, 17);
            this.rdbPre.TabIndex = 2;
            this.rdbPre.TabStop = true;
            this.rdbPre.Text = "PreOrden";
            this.rdbPre.UseVisualStyleBackColor = true;
            // 
            // rdbPost
            // 
            this.rdbPost.AutoSize = true;
            this.rdbPost.Location = new System.Drawing.Point(9, 54);
            this.rdbPost.Name = "rdbPost";
            this.rdbPost.Size = new System.Drawing.Size(75, 17);
            this.rdbPost.TabIndex = 1;
            this.rdbPost.TabStop = true;
            this.rdbPost.Text = "PostOrden";
            this.rdbPost.UseVisualStyleBackColor = true;
            // 
            // rdbIn
            // 
            this.rdbIn.AutoSize = true;
            this.rdbIn.Location = new System.Drawing.Point(9, 32);
            this.rdbIn.Name = "rdbIn";
            this.rdbIn.Size = new System.Drawing.Size(63, 17);
            this.rdbIn.TabIndex = 0;
            this.rdbIn.TabStop = true;
            this.rdbIn.Text = "InOrden";
            this.rdbIn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDibujar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dgvRosticeria);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Rosticeria";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRosticeria)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grb1.ResumeLayout(false);
            this.grb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgRosticeria)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxArbol)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridView dgvRosticeria;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn IngresoAnual;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDeEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distribuidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServicioADomicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inauguracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Foto;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.Button bntEliminarPrimero;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtFoto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdbAmbos;
        private System.Windows.Forms.RadioButton rdbDollares;
        private System.Windows.Forms.RadioButton rdbPesos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnumempleados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtingreso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox imgRosticeria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chbServicio;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.DateTimePicker dtmInauguracion;
        private System.Windows.Forms.ComboBox cmbDistribuidor;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnBuscarRFC;
        private System.Windows.Forms.TextBox txtRFCBuscar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pbxArbol;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbPre;
        private System.Windows.Forms.RadioButton rdbPost;
        private System.Windows.Forms.RadioButton rdbIn;
    }
}

