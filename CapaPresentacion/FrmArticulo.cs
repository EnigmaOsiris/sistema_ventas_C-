using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmArticulo : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;

        private static FrmArticulo _Instancia;
        public static FrmArticulo GetInstancia()
        {
            if(_Instancia==null)
            {
                _Instancia = new FrmArticulo();
            }
            return _Instancia;
        }

        public void setCategoria(string idcategoria,string nombre)
        {
            this.txtidCategoria.Text = idcategoria;
            this.txtCategoria.Text = nombre;
        }

        public FrmArticulo()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtNombre, "Ingrese el Nombre del articulo");
            this.ttMensaje.SetToolTip(this.pximagen, "Ingrese la imagen del articulo");
            this.ttMensaje.SetToolTip(this.cbidPresentacion, "Ingrese el idPresentacion del articulo");

            this.txtidCategoria.Visible = false;
            this.txtCategoria.ReadOnly = true;
            this.LlenarComboPresentacion();
         
        }

        //Mostrar Mensaje de Confirmación
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Limpiar todos los controles del formulario
        private void Limpiar()
        {
            this.txtNombre.Text = string.Empty;
            this.txtDescripcion.Text = string.Empty;
            this.txtIdArticulo.Text = string.Empty;
            this.txtCodigo.Text = string.Empty;
            this.txtCategoria.Text = string.Empty;
            this.txtidCategoria.Text = string.Empty;
            this.pximagen.Image = global::CapaPresentacion.Properties.Resources.ScreenShot_20170307165021; 


        }

        //Habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            this.txtCodigo.ReadOnly = !valor;
            this.txtNombre.ReadOnly = !valor;
            this.txtDescripcion.ReadOnly = !valor;
            this.btnbuscarcategoria.Enabled = valor;
            this.cbidPresentacion.Enabled = valor;
            this.txtIdArticulo.ReadOnly = !valor;
            this.btnCargar.Enabled = valor;
            this.btnLimpiar.Enabled = valor;
        }

        //Habilitar los botones
        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar) //Alt + 124
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

        //Método para ocultar columnas
        private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[1].Visible = false;
            this.dataListado.Columns[6].Visible = false;
            this.dataListado.Columns[8].Visible = false;
        }

        //Método Mostrar
        private void Mostrar()
        {
            this.dataListado.DataSource = NArticulo.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        //Método BuscarNombre
        private void BuscarNombre()
        {
            this.dataListado.DataSource = NArticulo.BuscarNombre(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);

        }


        //metod llenar presentacion 
        private void LlenarComboPresentacion()

        {
            cbidPresentacion.DataSource = NPresentacion.Mostrar();
            cbidPresentacion.ValueMember = "idpresentacion";
            cbidPresentacion.DisplayMember = "nombre";
        }
  

        private void FrmArticulo_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }

        // boton cargar imagen
        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            DialogResult resul = dialogo.ShowDialog();
            if(resul==DialogResult.OK)
            {
                this.pximagen.SizeMode = PictureBoxSizeMode.StretchImage;
                this.pximagen.Image = Image.FromFile(dialogo.FileName);
            }

        }

        //boton lipiar imagen o borrar
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.pximagen.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pximagen.Image = global::CapaPresentacion.Properties.Resources.ScreenShot_20170307165021;
        }

        //boton buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        //caja de texto buscar
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        //boton nuevo
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtCodigo.Focus();
        }

        //boton guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.txtNombre.Text == string.Empty || this.txtCodigo.Text == string.Empty || txtidCategoria.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                    errorIcono.SetError(txtNombre, "Ingrese un Valor");
                    errorIcono.SetError(txtCodigo, "Ingrese un Valor");
                    errorIcono.SetError(txtidCategoria, "Ingrese un Valor");
                }
                else
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    // Se guarda la imagen 
                    pximagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                    byte[] imagen = ms.GetBuffer();


                    if (this.IsNuevo)
                    {

                        rpta = NArticulo.Insertar(this.txtCodigo.Text, this.txtNombre.Text.Trim().ToUpper(),
                        this.txtDescripcion.Text.Trim(), imagen, Convert.ToInt32(txtidCategoria.Text), Convert.ToInt32(cbidPresentacion.SelectedValue));

                    }
                    else
                    {
                        rpta = NArticulo.Editar(Convert.ToInt32(this.txtIdArticulo.Text), this.txtCodigo.Text, this.txtNombre.Text.Trim().ToUpper(),
                        this.txtDescripcion.Text.Trim(), imagen, Convert.ToInt32(txtidCategoria.Text),Convert.ToInt32(cbidPresentacion.SelectedValue));
                    }

                    if (rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Sinsercion correcta");
                        }
                        else
                        {
                            this.MensajeOk("Actualizacion correcta");
                        }
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }

                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.Botones();
                    this.Limpiar();
                    this.Mostrar();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        //boto editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtIdArticulo.Text.Equals(""))
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

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListado.Columns["Eliminar"].Index)
            {
                DataGridViewTopLeftHeaderCell ChkEliminar = (DataGridViewTopLeftHeaderCell)dataListado.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        //mostar articulo
        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            this.txtIdArticulo.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idarticulo"].Value);
            this.txtCodigo.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["codigo"].Value);
            this.txtNombre.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["nombre"].Value);
            this.txtDescripcion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["descripcion"].Value);
            //Mostramos la Imagen
       
            byte[] imagenBuffer = (byte[])this.dataListado.CurrentRow.Cells["imagen"].Value;
          
            System.IO.MemoryStream ms = new System.IO.MemoryStream(imagenBuffer);
            // Se utiliza el MemoryStream para extraer la imagen
            this.pximagen.Image = Image.FromStream(ms);
            this.pximagen.SizeMode = PictureBoxSizeMode.StretchImage;

            this.txtidCategoria.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idcategoria"].Value);
            this.txtCategoria.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["categoria"].Value);
            this.cbidPresentacion.SelectedValue = Convert.ToString(this.dataListado.CurrentRow.Cells["idpresentacion"].Value);
           
            this.tabControl1.SelectedIndex = 1;
        }

        //metodo eliminar en la lista de datos 
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
        //boton de elimninar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Eliminar los Registros", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Rpta = NArticulo.Eliminar(Convert.ToInt32(Codigo));

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se Eliminó Correctamente el registro");
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

        private void btnbuscarcategoria_Click(object sender, EventArgs e)
        {
            FrmVistaCategoria_Articulo form = new FrmVistaCategoria_Articulo();
            form.ShowDialog();
        }
    }
}
