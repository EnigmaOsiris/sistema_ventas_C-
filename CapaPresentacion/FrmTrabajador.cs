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
    public partial class FrmTrabajador : Form
    {

        public bool IsNuevo;
        public bool IsEditar;
        public FrmTrabajador()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtnombre, "Ingrese el nombre del trabajador");
            this.ttMensaje.SetToolTip(this.txtapellidos, "Ingrese los apellidos");
            this.ttMensaje.SetToolTip(this.txtUsuario, "Ingrese el usuario del trabajador");
            this.ttMensaje.SetToolTip(this.txtContraseña, "Ingrese la contresena para el usuario");
            this.ttMensaje.SetToolTip(this.cbacceso, "Seleccionar elacceso del trabajador");

        }
        private void MensajeOK(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Limpia los controles del formulario
        private void Limpiar()
        {
            this.txtIdtrabajador.Text = string.Empty;
            this.txtnombre.Text = string.Empty;
            this.txtapellidos.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;
            this.txttelefono.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            this.txtUsuario.Text = string.Empty;
            this.txtContraseña.Text = string.Empty;

        }
        //Habilita los controles
        private void Habilitar(bool Valor)
        {
            this.txtIdtrabajador.ReadOnly = !Valor;
            this.txtnombre.ReadOnly = !Valor;
            this.txtDireccion.ReadOnly = !Valor;
            this.cbsexo.Enabled = Valor;
            this.txtDireccion.ReadOnly = !Valor;
            this.txttelefono.ReadOnly = !Valor;
            this.txtEmail.ReadOnly = !Valor;
            this.cbacceso.Enabled = Valor;
            this.txtUsuario.ReadOnly = !Valor;
            this.txtContraseña.ReadOnly = !Valor;
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
            this.dataListado.DataSource = NTrabajador.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total Registros: " + Convert.ToString(dataListado.Rows.Count);
        }
        private void BuscarNombre()
        {
            this.dataListado.DataSource = NTrabajador.BuscarNombre(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void FrmTrabajador_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }
        //boton buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }
        //noton eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Desea Eliminar los datos", "Sistema de Ventas",
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
                            Rpta = NTrabajador.Eliminar(Convert.ToInt32(Codigo));

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOK("Eliminacion correcta");
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
        //boton nuevo
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
                if (this.txtnombre.Text == string.Empty || this.txtapellidos.Text == string.Empty || txtUsuario.Text == string.Empty || txtContraseña.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorIcono.SetError(txtnombre, "Ingrese un Valor");
                    errorIcono.SetError(txtapellidos, "Ingrese un Valor");
                    errorIcono.SetError(txtUsuario, "Ingrese un Valor");
                    errorIcono.SetError(txtContraseña, "Ingrese un Valor");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        Rpta = NTrabajador.Insertar(this.txtnombre.Text.Trim().ToUpper(),
                        this.txtapellidos.Text.Trim().ToUpper(), cbsexo.Text,txtDireccion.Text,
                        txttelefono.Text, txtEmail.Text, cbacceso.Text, txtUsuario.Text, txtContraseña.Text);

                    }
                    else
                    {
                        Rpta = NTrabajador.Editar(Convert.ToInt32(this.txtIdtrabajador.Text), this.txtnombre.Text.Trim().ToUpper(),
                        this.txtapellidos.Text.Trim().ToUpper(), cbsexo.Text, txtDireccion.Text,
                        txttelefono.Text, txtEmail.Text, cbacceso.Text, txtUsuario.Text, txtContraseña.Text);
                    }
                    if (Rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOK("Insercion correcta");
                        }
                        else
                        {
                            this.MensajeOK("Actualizacion correctar");
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
                    this.Mostrar();
                    this.txtIdtrabajador.Text = "";

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
            if (!this.txtIdtrabajador.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
            }
            else
            {
                this.MensajeError("Selecione un dat para modificar");
            }
        }
        //boton cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.txtIdtrabajador.Text = string.Empty;
        } 
        //metodo double click para seleccionar al eliminar
        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            txtIdtrabajador.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idtrabajador"].Value);
            this.txtnombre.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["nombre"].Value);
            this.txtapellidos.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["apellidos"].Value);
            this.cbsexo.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["sexo"].Value);
            this.txtDireccion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["direccion"].Value);
            this.txttelefono.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["telefono"].Value);
            this.txtEmail.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["email"].Value);
            this.cbacceso.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["acceso"].Value);
            this.txtUsuario.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["usuario"].Value);
            this.txtContraseña.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["contraseña"].Value);
            this.tabControl1.SelectedIndex = 1;
        }
        //lista de datos 
        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar =
                    (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }
        //selector para eliminar
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
    }
}
