using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class DDetalle_Ingreso
    {
        //Variables
        private int _Iddetalle_ingreso;
        private int _Idingreso;
        private int _Idarticulo;
        private decimal _Precio_Compra;
        private decimal _precio_Venta;
        private int _Stock_Inicial;
        private int _Stock_Actual;
        private DateTime _Fecha_Ingreso;

        public int Iddetalle_ingreso
        {
            get{return _Iddetalle_ingreso;}
            set{ _Iddetalle_ingreso = value; }
        }
        public int Idingreso
        {
            get{return _Idingreso;}
            set{_Idingreso = value;}
        }
        public int Idarticulo
        {
            get{return _Idarticulo;}
            set{_Idarticulo = value;}
        }
        public decimal Precio_Compra
        {
            get{return _Precio_Compra;}
            set{_Precio_Compra = value;}
        }
        public decimal Precio_Venta
        {
            get{return _precio_Venta;}
            set{_precio_Venta = value;}
        }
        public int Stock_Inicial
        {
            get{ return _Stock_Inicial; }
            set{_Stock_Inicial = value;}
        }
        public int Stock_Actual
        {
            get{return _Stock_Actual;}
            set{_Stock_Actual = value;}
        }
        public DateTime Fecha_Ingreso
        {
            get{return _Fecha_Ingreso;}
            set{ _Fecha_Ingreso = value; }
        }

        //Constructores
        public DDetalle_Ingreso()
        {

        }
        public DDetalle_Ingreso(int iddetalle_ingreso, int idingreso, int idarticulo, 
            decimal precio_compra, decimal precio_venta, int stock_inicial, 
            int stock_actual, DateTime fecha_ingreso)
        {
            this.Iddetalle_ingreso = iddetalle_ingreso;
            this.Idingreso = idingreso;
            this.Idarticulo = idarticulo;
            this.Precio_Compra = precio_compra;
            this.Precio_Venta = precio_venta;
            this.Stock_Inicial = stock_inicial;
            this.Stock_Actual = stock_actual;
            this._Fecha_Ingreso = fecha_ingreso;

        }

        //Método Insertar
        public string Insertar(DDetalle_Ingreso Detalle_Ingreso, 
            ref SqlConnection SqlCon, ref SqlTransaction SqlTra)
        {
            string rpta = "";
            try
            {

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "spinsertar_detalle_ingreso";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIddetalle_ingreso = new SqlParameter();
                ParIddetalle_ingreso.ParameterName = "@iddetalle_ingreso";
                ParIddetalle_ingreso.SqlDbType = SqlDbType.Int;
                ParIddetalle_ingreso.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIddetalle_ingreso);

                SqlParameter ParIdingreso = new SqlParameter();
                ParIdingreso.ParameterName = "@idingreso";
                ParIdingreso.SqlDbType = SqlDbType.Int;
                ParIdingreso.Value = Detalle_Ingreso.Idingreso;
                SqlCmd.Parameters.Add(ParIdingreso);

                SqlParameter ParIdarticulo = new SqlParameter();
                ParIdarticulo.ParameterName = "@idarticulo";
                ParIdarticulo.SqlDbType = SqlDbType.Int;
                ParIdarticulo.Value = Detalle_Ingreso.Idarticulo;
                SqlCmd.Parameters.Add(ParIdarticulo);

                SqlParameter ParPrecio_Compra = new SqlParameter();
                ParPrecio_Compra.ParameterName = "@precio_compra";
                ParPrecio_Compra.SqlDbType = SqlDbType.Decimal;
                ParPrecio_Compra.Precision = 4;
                ParPrecio_Compra.Scale = 2;
                ParPrecio_Compra.Value = Detalle_Ingreso.Precio_Compra;
                SqlCmd.Parameters.Add(ParPrecio_Compra);

                SqlParameter ParPrecio_Venta = new SqlParameter();
                ParPrecio_Venta.ParameterName = "@precio_venta";
                ParPrecio_Venta.SqlDbType = SqlDbType.Decimal;
                ParPrecio_Venta.Precision = 4;
                ParPrecio_Venta.Scale = 2;
                ParPrecio_Venta.Value = Detalle_Ingreso.Precio_Venta;
                SqlCmd.Parameters.Add(ParPrecio_Venta);

                SqlParameter ParStock_Inicial = new SqlParameter();
                ParStock_Inicial.ParameterName = "@stock_inicial";
                ParStock_Inicial.SqlDbType = SqlDbType.Int;
                ParStock_Inicial.Value = Detalle_Ingreso.Stock_Inicial;
                SqlCmd.Parameters.Add(ParStock_Inicial);

                SqlParameter ParStock_Actual = new SqlParameter();
                ParStock_Actual.ParameterName = "@stock_actual";
                ParStock_Actual.SqlDbType = SqlDbType.Int;
                ParStock_Actual.Value = Detalle_Ingreso.Stock_Actual;
                SqlCmd.Parameters.Add(ParStock_Actual);

                SqlParameter ParFecha_Produccion = new SqlParameter();
                ParFecha_Produccion.ParameterName = "@fecha_ingreso";
                ParFecha_Produccion.SqlDbType = SqlDbType.DateTime;
                ParFecha_Produccion.Value = Detalle_Ingreso._Fecha_Ingreso;
                SqlCmd.Parameters.Add(ParFecha_Produccion);
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }

            return rpta;

        }
    }
}
