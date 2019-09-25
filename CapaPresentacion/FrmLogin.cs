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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();


        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DataTable Datos = NTrabajador.Login(this.txtUsuario.Text, this.txtPassword.Text);
            //Evaluamos si no existen los Datos
            if (Datos.Rows.Count== 0)
            {
                MessageBox.Show("No Tiene Acceso al Sistema", "Sistema Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FrmPrincipal frm = new FrmPrincipal();
                frm.Idetrabajador = Datos.Rows[0][0].ToString();
                frm.Apellidos = Datos.Rows[0][1].ToString();
                frm.Nombre = Datos.Rows[0][2].ToString();
                frm.Acceso = Datos.Rows[0][3].ToString();

                frm.Show();
                this.Hide();

            }
        }
    }
}
