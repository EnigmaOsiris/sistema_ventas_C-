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
    public partial class FrmVistaCategoria_Articulo : Form
    {
        public FrmVistaCategoria_Articulo()
        {
            InitializeComponent();
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

        private void FrmVistaCategoria_Articulo_Load(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNombre();

        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            FrmArticulo form = FrmArticulo.GetInstancia();
            string par1, par2;
            par1 = Convert.ToString(this.dataListado.CurrentRow.Cells["idcategoria"].Value);
            par2 = Convert.ToString(this.dataListado.CurrentRow.Cells["nombre"].Value);
            form.setCategoria(par1, par2);
            this.Hide();
        }
    }
}
