using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using Datos;

namespace CapaNegocio
{
    public class NIngreso
    {
        public static string Insertar(int idtrabajador, int idproveedor, DateTime fecha, string tipo_comprobante,DataTable dtDetalles)
        {
            DIngreso Obj = new DIngreso();
            Obj.Idtrabajador = idtrabajador;
            Obj.Idproveedor = idproveedor;
            Obj.Fecha = fecha;
            Obj.Tipo_Comprobante = tipo_comprobante;
            List<DDetalle_Ingreso>detalles=new List<DDetalle_Ingreso>();
            foreach (DataRow row in dtDetalles.Rows)
            {
                DDetalle_Ingreso detalle = new DDetalle_Ingreso();
                detalle.Idarticulo = Convert.ToInt32(row["idarticulo"].ToString());
                detalle.Precio_Compra = Convert.ToDecimal(row["precio_compra"].ToString());
                detalle.Precio_Venta = Convert.ToDecimal(row["precio_venta"].ToString());
                detalle.Stock_Inicial = Convert.ToInt32(row["stock_inicial"].ToString());
                detalle.Stock_Actual = Convert.ToInt32(row["stock_inicial"].ToString());
                detalle.Fecha_Ingreso = Convert.ToDateTime(row["fecha_ingreso"].ToString());
                detalles.Add(detalle);
            }


            return Obj.Insertar(Obj, detalles);
        }
        public static string Anular(int idingreso)
        {
            DIngreso Obj = new DIngreso();
            Obj.Idingreso = idingreso;
            return Obj.Anular(Obj);
        }
        public static DataTable Mostrar()
        {
            return new DIngreso().Mostrar();
        }
        public static DataTable BuscarFechas(string textobuscar, string textobuscar2)
        {
            DIngreso Obj = new DIngreso();
            return Obj.BuscarFechas(textobuscar, textobuscar2);
        }
        public static DataTable MostrarDetalle(string textobuscar)
        {
            DIngreso Obj = new DIngreso();
            return Obj.MostrarDetalle(textobuscar);
        }
    }
}
