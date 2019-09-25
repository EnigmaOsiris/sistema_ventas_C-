using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmCategoria : Form
    { 
        private bool IsNuevo = false;

        private bool IsEditar = false;

        public FrmCategoria()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip (this.txtNombre, "Ingresa el nombre de la categoria");

        }
        //mostrar mensaje de confirmacion
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje,"sistema de ventas",MessageBoxButtons.OK,MessageBoxIcon.Information);    
        }
        //Mostrar mensaje de error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Limpiar todos los cotrolos de formulario
        private void Limpiar()
        {
            this.txtNombre.Text = string.Empty;
            this.txtDescripcion.Text = string.Empty;
            this.txtIdCategoria.Text = string.Empty;

        }

        //habilitar los controles de fprmulario
        private void Habilitar(bool valor)
        {
            this.txtNombre.ReadOnly = !valor;
            this.txtDescripcion.ReadOnly = !valor;
            this.txtIdCategoria.ReadOnly = !valor;

        }

        //avilitar los botones 
        private void Botones()
        {
            if(this.IsNuevo||this.IsEditar)
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = true;

            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;

            }
        }

        //metodo acultar columnas
        private void OcualtarColumnas()
        {

            if (dataListado.RowCount >1) {

                this.dataListado.Columns[0].Visible = false;
                this.dataListado.Columns[1].Visible = false;
            }
        }

        //metodo mostrar
        private void Mostar()
        {
            this.dataListado.DataSource = NCategoria.Mostrar();
            this.OcualtarColumnas();
            lblTotal.Text = "Total de registros" + Convert.ToString(dataListado.Rows.Count);

        }
        //Metodo BuscarNomnbre
        private void BuscarNombre()
        {
            this.dataListado.DataSource = NCategoria.BuscarNombre(this.txtBuscar.Text);
            this.OcualtarColumnas();
            lblTotal.Text = "Total de registros" + Convert.ToString(dataListado.Rows.Count);

        }



        private void SistemaVenta_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            this.Mostar();
            this.Habilitar(false);
            this.Botones();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarNombre();

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtNombre.Focus();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (this.txtNombre.Text == string.Empty)
                {

                    MensajeError("Falta Ingresar algunos valores");
                    errorIcono.SetError(txtNombre, "Ingrese Nombre");
                }
                else
                { 
                    if (this.IsNuevo)
                    {
                        //insertar un producto
                        Rpta = NCategoria.Insertar(this.txtNombre.Text.Trim().ToUpper(),
                                   this.txtDescripcion.Text.Trim());

                    }
                    else
                    {
                        //modificar un producto
                        Rpta = NCategoria.Editar(Convert.ToInt32(this.txtIdCategoria.Text),
                                     this.txtNombre.Text.Trim().ToUpper(),
                                     this.txtDescripcion.Text.Trim());
                    }
                  
                    if (Rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Insercion corecta");
                        }
                        else
                        {
                            this.MensajeOk("Actualizacion carecta");
                        }

                    }
                    else
                    {
                        //Mostramos el mensaje de error
                        this.MensajeError(Rpta);
                    }
                    this.IsNuevo = false;
                    this.IsEditar= false;
                    this.Botones();
                    this.Limpiar();
                    this.Mostar();
                    this.txtIdCategoria.Text = "";

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void SistemaVenta_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
   
            if (!this.txtIdCategoria.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.Habilitar(true);
            }
            else
            {
                this.MensajeError("Buscar un registro para editar");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
        }

        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if(chkEliminar.Checked)
            {
                this.dataListado.Columns[0].Visible = true;
            }
            else
            {
                this.dataListado.Columns[0].Visible = false;

            }
        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==dataListado.Columns["Eliminar"].Index)
            {
                DataGridViewTopLeftHeaderCell ChkEliminar = (DataGridViewTopLeftHeaderCell)dataListado.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        //eliminar

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea eliminar los registros?", "Sistema Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dataListado.Rows)//recorre todas las filas 
                    {

                        if (Convert.ToBoolean(row.Cells[0].Value))//el bucle revisa fila for fila 
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Rpta = NCategoria.ELiminarr(Convert.ToInt32(Codigo));

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Eliminacion Correcta");
                            }
                            else
                            {
                                //Mostramos el mensaje de error
                                this.MensajeError(Rpta);
                            }
                        }
                    }

                    this.Mostar();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        
    }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            this.txtIdCategoria.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idcategoria"].Value);
            this.txtNombre.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["nombre"].Value);
            this.txtDescripcion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["descripcion"].Value);

            this.tabControl1.SelectedIndex = 1;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
    }
