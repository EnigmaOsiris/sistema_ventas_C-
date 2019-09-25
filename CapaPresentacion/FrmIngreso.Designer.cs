namespace CapaPresentacion
{
    partial class FrmIngreso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dtFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtproveedor = new System.Windows.Forms.TextBox();
            this.txtIdgreso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtidproveedor = new System.Windows.Forms.TextBox();
            this.btnbuscarproveedores = new System.Windows.Forms.Button();
            this.cbidPresentacion = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnbuscararticulo = new System.Windows.Forms.Button();
            this.txtidarticulo = new System.Windows.Forms.TextBox();
            this.txtarticulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtstockinicial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtstockactual = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtpreciocompra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtprecioventa = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtFechavencimiento = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtfecha_ingreso = new System.Windows.Forms.DateTimePicker();
            this.lblTotal = new System.Windows.Forms.Label();
            this.chkanular = new System.Windows.Forms.CheckBox();
            this.dataListadodetalleventa = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.datalistadodetalle = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadodetalleventa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datalistadodetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // dtFechaIngreso
            // 
            this.dtFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaIngreso.Location = new System.Drawing.Point(693, 27);
            this.dtFechaIngreso.Name = "dtFechaIngreso";
            this.dtFechaIngreso.Size = new System.Drawing.Size(100, 20);
            this.dtFechaIngreso.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(612, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Fecha Ingreso";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(684, 389);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(592, 389);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(486, 389);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // txtproveedor
            // 
            this.txtproveedor.Location = new System.Drawing.Point(247, 33);
            this.txtproveedor.Name = "txtproveedor";
            this.txtproveedor.Size = new System.Drawing.Size(105, 20);
            this.txtproveedor.TabIndex = 5;
            this.txtproveedor.TextChanged += new System.EventHandler(this.txtproveedor_TextChanged);
            // 
            // txtIdgreso
            // 
            this.txtIdgreso.Location = new System.Drawing.Point(70, 26);
            this.txtIdgreso.Name = "txtIdgreso";
            this.txtIdgreso.Size = new System.Drawing.Size(100, 20);
            this.txtIdgreso.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Codigo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.datalistadodetalle);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cbidPresentacion);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnbuscarproveedores);
            this.groupBox1.Controls.Add(this.txtidproveedor);
            this.groupBox1.Controls.Add(this.dtFechaIngreso);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.txtproveedor);
            this.groupBox1.Controls.Add(this.txtIdgreso);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(7, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(811, 474);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Proveedor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(387, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 34);
            this.label9.TabIndex = 20;
            this.label9.Text = "Ingresos";
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(378, -109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 34);
            this.label2.TabIndex = 19;
            this.label2.Text = "Articulos";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(-4, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(832, 467);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(824, 441);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtidproveedor
            // 
            this.txtidproveedor.Location = new System.Drawing.Point(247, 7);
            this.txtidproveedor.Name = "txtidproveedor";
            this.txtidproveedor.Size = new System.Drawing.Size(41, 20);
            this.txtidproveedor.TabIndex = 40;
            // 
            // btnbuscarproveedores
            // 
            this.btnbuscarproveedores.Image = global::CapaPresentacion.Properties.Resources.ScreenShot_20170307122827;
            this.btnbuscarproveedores.Location = new System.Drawing.Point(358, 33);
            this.btnbuscarproveedores.Name = "btnbuscarproveedores";
            this.btnbuscarproveedores.Size = new System.Drawing.Size(42, 23);
            this.btnbuscarproveedores.TabIndex = 41;
            this.btnbuscarproveedores.UseVisualStyleBackColor = true;
            // 
            // cbidPresentacion
            // 
            this.cbidPresentacion.AutoCompleteCustomSource.AddRange(new string[] {
            "TICKET",
            "FACTURA"});
            this.cbidPresentacion.FormattingEnabled = true;
            this.cbidPresentacion.Location = new System.Drawing.Point(497, 30);
            this.cbidPresentacion.Name = "cbidPresentacion";
            this.cbidPresentacion.Size = new System.Drawing.Size(77, 21);
            this.cbidPresentacion.TabIndex = 43;
            this.cbidPresentacion.Text = "TICKET";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(422, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Presentacion";
            // 
            // btnbuscararticulo
            // 
            this.btnbuscararticulo.Image = global::CapaPresentacion.Properties.Resources.ScreenShot_20170307122827;
            this.btnbuscararticulo.Location = new System.Drawing.Point(185, 43);
            this.btnbuscararticulo.Name = "btnbuscararticulo";
            this.btnbuscararticulo.Size = new System.Drawing.Size(42, 23);
            this.btnbuscararticulo.TabIndex = 47;
            this.btnbuscararticulo.UseVisualStyleBackColor = true;
            // 
            // txtidarticulo
            // 
            this.txtidarticulo.Location = new System.Drawing.Point(72, 17);
            this.txtidarticulo.Name = "txtidarticulo";
            this.txtidarticulo.Size = new System.Drawing.Size(41, 20);
            this.txtidarticulo.TabIndex = 46;
            // 
            // txtarticulo
            // 
            this.txtarticulo.Location = new System.Drawing.Point(72, 43);
            this.txtarticulo.Name = "txtarticulo";
            this.txtarticulo.Size = new System.Drawing.Size(105, 20);
            this.txtarticulo.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Articulo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtFechavencimiento);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtprecioventa);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtpreciocompra);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtstockactual);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtstockinicial);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtarticulo);
            this.groupBox2.Controls.Add(this.btnbuscararticulo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtidarticulo);
            this.groupBox2.Location = new System.Drawing.Point(27, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(747, 132);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            // 
            // txtstockinicial
            // 
            this.txtstockinicial.Location = new System.Drawing.Point(77, 95);
            this.txtstockinicial.Name = "txtstockinicial";
            this.txtstockinicial.Size = new System.Drawing.Size(100, 20);
            this.txtstockinicial.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Stock inicial";
            // 
            // txtstockactual
            // 
            this.txtstockactual.Location = new System.Drawing.Point(287, 95);
            this.txtstockactual.Name = "txtstockactual";
            this.txtstockactual.Size = new System.Drawing.Size(100, 20);
            this.txtstockactual.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Stock actual";
            // 
            // txtpreciocompra
            // 
            this.txtpreciocompra.Location = new System.Drawing.Point(352, 46);
            this.txtpreciocompra.Name = "txtpreciocompra";
            this.txtpreciocompra.Size = new System.Drawing.Size(100, 20);
            this.txtpreciocompra.TabIndex = 54;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(250, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "Precio compra";
            // 
            // txtprecioventa
            // 
            this.txtprecioventa.Location = new System.Drawing.Point(588, 46);
            this.txtprecioventa.Name = "txtprecioventa";
            this.txtprecioventa.Size = new System.Drawing.Size(100, 20);
            this.txtprecioventa.TabIndex = 56;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(502, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 55;
            this.label12.Text = "Precio venta\r\n";
            // 
            // dtFechavencimiento
            // 
            this.dtFechavencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechavencimiento.Location = new System.Drawing.Point(588, 92);
            this.dtFechavencimiento.Name = "dtFechavencimiento";
            this.dtFechavencimiento.Size = new System.Drawing.Size(100, 20);
            this.dtFechavencimiento.TabIndex = 50;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(479, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 13);
            this.label13.TabIndex = 49;
            this.label13.Text = "Fecha vencimiento";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtfecha_ingreso);
            this.tabPage1.Controls.Add(this.lblTotal);
            this.tabPage1.Controls.Add(this.chkanular);
            this.tabPage1.Controls.Add(this.dataListadodetalleventa);
            this.tabPage1.Controls.Add(this.btnImprimir);
            this.tabPage1.Controls.Add(this.btnEliminar);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(824, 441);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Lista";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtfecha_ingreso
            // 
            this.dtfecha_ingreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfecha_ingreso.Location = new System.Drawing.Point(183, 39);
            this.dtfecha_ingreso.Name = "dtfecha_ingreso";
            this.dtfecha_ingreso.Size = new System.Drawing.Size(100, 20);
            this.dtfecha_ingreso.TabIndex = 45;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(641, 92);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 13);
            this.lblTotal.TabIndex = 44;
            this.lblTotal.Text = "label3";
            // 
            // chkanular
            // 
            this.chkanular.AutoSize = true;
            this.chkanular.Location = new System.Drawing.Point(42, 88);
            this.chkanular.Name = "chkanular";
            this.chkanular.Size = new System.Drawing.Size(56, 17);
            this.chkanular.TabIndex = 43;
            this.chkanular.Text = "Anular";
            this.chkanular.UseVisualStyleBackColor = true;
            // 
            // dataListadodetalleventa
            // 
            this.dataListadodetalleventa.AllowUserToAddRows = false;
            this.dataListadodetalleventa.AllowUserToDeleteRows = false;
            this.dataListadodetalleventa.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dataListadodetalleventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListadodetalleventa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataListadodetalleventa.Location = new System.Drawing.Point(33, 138);
            this.dataListadodetalleventa.MultiSelect = false;
            this.dataListadodetalleventa.Name = "dataListadodetalleventa";
            this.dataListadodetalleventa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListadodetalleventa.Size = new System.Drawing.Size(766, 167);
            this.dataListadodetalleventa.TabIndex = 42;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(626, 40);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 41;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(498, 40);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 40;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(375, 40);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 39;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Fecha Ingreso";
            // 
            // datalistadodetalle
            // 
            this.datalistadodetalle.AllowUserToAddRows = false;
            this.datalistadodetalle.AllowUserToDeleteRows = false;
            this.datalistadodetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistadodetalle.Location = new System.Drawing.Point(27, 229);
            this.datalistadodetalle.Name = "datalistadodetalle";
            this.datalistadodetalle.Size = new System.Drawing.Size(756, 141);
            this.datalistadodetalle.TabIndex = 49;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 389);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 57;
            this.label14.Text = "total";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(67, 389);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 13);
            this.label15.TabIndex = 58;
            this.label15.Text = "0.0";
            // 
            // FrmIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(826, 504);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmIngreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmIngreso";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmIngreso_FormClosing);
            this.Load += new System.EventHandler(this.FrmIngreso_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadodetalleventa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datalistadodetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtFechaIngreso;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtproveedor;
        private System.Windows.Forms.TextBox txtIdgreso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.TextBox txtidproveedor;
        private System.Windows.Forms.Button btnbuscarproveedores;
        private System.Windows.Forms.ComboBox cbidPresentacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtFechavencimiento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtprecioventa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtpreciocompra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtstockactual;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtstockinicial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtarticulo;
        private System.Windows.Forms.Button btnbuscararticulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtidarticulo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView datalistadodetalle;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker dtfecha_ingreso;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox chkanular;
        private System.Windows.Forms.DataGridView dataListadodetalleventa;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
    }
}