using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmIngreso : Form
    {
        public static FrmIngreso _instancia;
        public static FrmIngreso GetInstancia()
        {
            if(_instancia ==null)
                {
                _instancia = new FrmIngreso();
                }
            return _instancia;
        }
        public void setProveedor (string idproveedor,string nombre)
        {
            this.txtidproveedor.Text = idproveedor;
            this.txtproveedor.Text = nombre;
        }
        public void setArticulo(string idarticulo,string nombre)
        {
            this.txtidarticulo.Text = idarticulo;
            this.txtarticulo.Text = nombre;
        }
        public FrmIngreso()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void txtproveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmIngreso_Load(object sender, EventArgs e)
        {

        }

        private void FrmIngreso_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instancia = null;
        }
    }
}
