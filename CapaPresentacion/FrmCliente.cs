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
    public partial class FrmCliente : Form
    {
        private bool IsEditar = false;
        private bool IsNuevo = false;
        public FrmCliente()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtnombre, "Ingrese el Nombre del cliente");
            this.ttMensaje.SetToolTip(this.txtapellidos, "Ingrese los Apellidos del cliente");
            this.ttMensaje.SetToolTip(this.txtDireccion, "Ingrese la Dirección del cliente");

        }

        //mensaje de confirmación
        private void MensajeOK(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //mostrar mensaje de error
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Limpiar()
        {
            this.txtIdcliente.Text = string.Empty;
            this.txtnombre.Text = string.Empty;
            this.txtapellidos.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;
            this.txtnumeroTelefono.Text = string.Empty;
            this.txtEmail.Text = string.Empty;

        }
        //Habilita los controles de los formularios
        private void Habilitar(bool Valor)
        {
            this.txtIdcliente.ReadOnly = !Valor;
            this.txtnombre.ReadOnly = !Valor;
            this.txtapellidos.ReadOnly = !Valor;
            this.txtDireccion.ReadOnly = !Valor;
            this.cbsexo.Enabled = Valor;
            this.dtFechaNacimiento.Enabled = Valor;
            this.txtDireccion.ReadOnly = !Valor;
            this.txtnumeroTelefono.ReadOnly = !Valor;
            this.txtEmail.ReadOnly = !Valor;
        }
        //Habilita los botones
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
        private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[1].Visible = false;
        }
        private void Mostrar()
        {
            this.dataListado.DataSource = NCliente.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total Registros: " + Convert.ToString(dataListado.Rows.Count);
        }
        private void BuscarNombre()
        {
            this.dataListado.DataSource = NCliente.BuscarNombre(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea Eliminar los datos", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Rpta = NCliente.Eliminar(Convert.ToInt32(Codigo));

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOK("Eliminacion correcta ");
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }

                        }
                    }
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

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
            this.txtIdcliente.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idcliente"].Value);
            this.txtnombre.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["nombre"].Value);
            this.txtapellidos.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["apellidos"].Value);
            this.cbsexo.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["sexo"].Value);
            this.dtFechaNacimiento.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["fecha_nacimiento"].Value);
            this.txtDireccion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["direccion"].Value);
            this.txtnumeroTelefono.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["telefono"].Value);
            this.txtEmail.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["email"].Value);

            this.tabControl1.SelectedIndex = 1;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtnombre.Focus();
        }

        //boton guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                string Rpta = "";
                if (this.txtnombre.Text == string.Empty || this.txtapellidos.Text == string.Empty || cbsexo.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                    errorIcono.SetError(txtnombre, "Ingrese un Valor");
                    errorIcono.SetError(txtapellidos, "Ingrese un Valor");
                    errorIcono.SetError(cbsexo, "Ingrese un Valor");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        Rpta = NCliente.Insertar(this.txtnombre.Text.Trim().ToUpper(),
                        this.txtapellidos.Text.Trim().ToUpper(), cbsexo.Text,
                        dtFechaNacimiento.Value, txtDireccion.Text,
                        txtnumeroTelefono.Text, txtEmail.Text);

                    }
                    else
                    {
                        Rpta = NCliente.Editar(Convert.ToInt32(this.txtIdcliente.Text), this.txtnombre.Text.Trim().ToUpper(),
                        this.txtapellidos.Text.Trim().ToUpper(), cbsexo.Text,
                        dtFechaNacimiento.Value, txtDireccion.Text,
                        txtnumeroTelefono.Text, txtEmail.Text);
                    }
                    if (Rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOK("Insercion Correcta");
                        }
                        else
                        {
                            this.MensajeOK("Actualizacion correcta");
                        }

                    }
                    else
                    {
                        //Mostramos el mensaje de error
                        this.MensajeError(Rpta);
                    }
                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.Botones();
                    this.Limpiar();
                    this.Mostrar();
                    this.txtIdcliente.Text = "";

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

            if (!this.txtIdcliente.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
            }
            else
            {
                this.MensajeError("Selecionar un registro");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.txtIdcliente.Text = string.Empty;
        }
    }

}