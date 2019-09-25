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
    public partial class FrmProveedor : Form
    {
        public bool IsNuevo = false;
        public bool IsEditar = false;
        public FrmProveedor()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtsector_social, "Ingrese sector social del proveedor");
            this.ttMensaje.SetToolTip(this.txtDireccion, "Ingrese la direccion del proveedor");

        }


        //mostrar mensaje de confirmacion
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Mostrar mensaje de error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Limpiar todos los cotrolos de formulario
        private void Limpiar()
        {
            this.txtsector_social.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            this.txtURL.Text = string.Empty;
            this.txtIdproveedor.Text = string.Empty;

        }

        //habilitar los controles de fprmulario
        private void Habilitar(bool valor)
        {
            this.txtsector_social.ReadOnly = !valor;
            this.txtDireccion.ReadOnly = !valor;
            this.cbsector_comercial.Enabled = valor;
            this.txtTelefono.ReadOnly = !valor;
            this.txtEmail.ReadOnly = !valor;
            this.txtURL.ReadOnly = !valor;
            this.txtIdproveedor.ReadOnly = !valor;

        }

        //avilitar los botones 
        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar)
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

            if (dataListado.RowCount > 1)
            {

                this.dataListado.Columns[0].Visible = false;
                this.dataListado.Columns[1].Visible = false;
            }
        }

        //metodo mostrar
        private void Mostar()
        {
            this.dataListado.DataSource = NProveedor.Mostrar();
            this.OcualtarColumnas();
            lblTotal.Text = "Total de registros" + Convert.ToString(dataListado.Rows.Count);

        }
        //Metodo Buscar por sector social
        private void BuscarSector_Social()
        {
            this.dataListado.DataSource = NProveedor.BuscarRazon_Social(this.txtBuscar.Text);
            this.OcualtarColumnas();
            lblTotal.Text = "Total de registros" + Convert.ToString(dataListado.Rows.Count);

        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmProveedor_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostar();
            this.Habilitar(false);
            this.Botones();
        }

        //boton buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarSector_Social();
        }

        //boton eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea Eliminar los Registros", "Sistema de Ventas", 
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Rpta = NProveedor.Eliminar(Convert.ToInt32(Codigo));

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Eliminacion correcta!");
                            }
                            else
                            {
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

        //boton de seleccion para eliminar 

        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEliminar.Checked)
            {
                this.dataListado.Columns[0].Visible = true;
            }
            else
            {
                this.dataListado.Columns[0].Visible = false;
            }
        }

        //boton nuevo
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtsector_social.Focus();
        }

        //boton guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                //La variable que almacena si se inserto 
                //o se modifico la tabla
                string Rpta = "";
                if (this.txtsector_social.Text == string.Empty || txtDireccion.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                    errorIcono.SetError(txtsector_social, "Ingrese un Valor");
                    errorIcono.SetError(txtDireccion, "Ingrese un Valor");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        Rpta = NProveedor.Insertar(this.txtsector_social.Text.Trim().ToUpper(),
                        cbsector_comercial.Text,txtDireccion.Text,
                        txtTelefono.Text, txtEmail.Text, txtURL.Text);

                    }
                    else
                    {
                        Rpta = NProveedor.Editar(Convert.ToInt32(this.txtIdproveedor.Text),
                            this.txtsector_social.Text.Trim().ToUpper(),
                        cbsector_comercial.Text,txtDireccion.Text,
                        txtTelefono.Text, txtEmail.Text, txtURL.Text);
                    }

                    if (Rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Insercion correcta");
                        }
                        else
                        {
                            this.MensajeOk("Actualizacion correcta");
                        }

                    }
                    else
                    {
                      
                        this.MensajeError(Rpta);
                    }
                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.Botones();
                    this.Limpiar();
                    this.Mostar();
                    this.txtIdproveedor.Text = "";

                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        //boton editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            if (!this.txtIdproveedor.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
            }
            else
            {
                this.MensajeError("seleccione un registro");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.txtIdproveedor.Text = string.Empty;
        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar =
                    (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            this.txtIdproveedor.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idproveedor"].Value);
            this.txtsector_social.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["sector_social"].Value);
            this.cbsector_comercial.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["sector_comercial"].Value);
            this.txtDireccion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["direccion"].Value);
            this.txtTelefono.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["telefono"].Value);
            this.txtEmail.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["email"].Value);
            this.txtURL.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["url"].Value);
            this.tabControl1.SelectedIndex = 1;
        }
    }
}

