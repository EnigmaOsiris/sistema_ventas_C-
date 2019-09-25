using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using Datos;

//17
namespace Datos
{
    public class DProveedor
    {
        //Variables
        private int _Idproveedor;
        private string _Razon_Social;
        private string _Apellidos;
        private string _Sector_Comercial;
        private string _Tipo_Documento;
        private string _Num_Documento;
        private string _Direccion;
        private string _Telefono;
        private string _Email;
        private string _Url;
        private string _TextoBuscar;

        public int Idproveedor
        {
            get{return _Idproveedor;}
            set{_Idproveedor = value;}
        }

        public string Razon_Social
        {
            get{return _Razon_Social;}
            set{_Razon_Social = value;}
        }

        public string Apellidos
        {
            get{return _Apellidos;}
            set{_Apellidos = value;}
        }

        public string Sector_Comercial
        {
            get{return _Sector_Comercial;}
            set{_Sector_Comercial = value;}
        }

        public string Tipo_Documento
        {
            get{return _Tipo_Documento;}
            set{_Tipo_Documento = value;}
        }

        public string Num_Documento
        {
            get{return _Num_Documento;}
            set{_Num_Documento = value;}
        }

        public string Direccion
        {
            get{return _Direccion;}
            set{_Direccion = value;}
        }

        public string Telefono
        {
            get{return _Telefono;}
            set{_Telefono = value;}
        }

        public string Email
        {
            get{return _Email;}
            set{_Email = value;}
        }

        public string Url
        {
            get{return _Url;}
            set{_Url = value;}
        }

        public string TextoBuscar
        {
            get{return _TextoBuscar;}
            set{_TextoBuscar = value;}
        }

        public DProveedor(int idproveedor, string sector_social, string sector_comercial,
            string direccion,string telefono, string email, string url, string textobuscar)
        {
            this.Idproveedor = idproveedor;
            this.Razon_Social = sector_social;
            this.Sector_Comercial = sector_comercial;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Email = email;
            this.Url = url;
            this.TextoBuscar = textobuscar;
        }

        public DProveedor()
        {
        }

        //Método Insertar proveedor

        public string Insertar(DProveedor Proveedor)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
       
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdproveedor = new SqlParameter();
                ParIdproveedor.ParameterName = "@idproveedor";
                ParIdproveedor.SqlDbType = SqlDbType.Int;
                ParIdproveedor.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdproveedor);

                SqlParameter ParRazon_Social = new SqlParameter();
                ParRazon_Social.ParameterName = "@sector_social";
                ParRazon_Social.SqlDbType = SqlDbType.VarChar;
                ParRazon_Social.Size = 20;
                ParRazon_Social.Value = Proveedor.Razon_Social;
                SqlCmd.Parameters.Add(ParRazon_Social);

                SqlParameter ParSector_Comercial = new SqlParameter();
                ParSector_Comercial.ParameterName = "@sector_comercial";
                ParSector_Comercial.SqlDbType = SqlDbType.VarChar;
                ParSector_Comercial.Size = 40;
                ParSector_Comercial.Value = Proveedor.Sector_Comercial;
                SqlCmd.Parameters.Add(ParSector_Comercial);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 100;
                ParDireccion.Value = Proveedor.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 10;
                ParTelefono.Value = Proveedor.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = Proveedor.Email;
                SqlCmd.Parameters.Add(ParEmail);

                SqlParameter ParUrl = new SqlParameter();
                ParUrl.ParameterName = "@url";
                ParUrl.SqlDbType = SqlDbType.VarChar;
                ParUrl.Size = 50;
                ParUrl.Value = Proveedor.Url;
                SqlCmd.Parameters.Add(ParUrl);

                //Ejecutamos nuestro comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;

        }

        //Método Editar
        public string Editar(DProveedor Proveedor)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdcliente = new SqlParameter();
                ParIdcliente.ParameterName = "@idpreovedor";
                ParIdcliente.SqlDbType = SqlDbType.Int;
                ParIdcliente.Value = Proveedor.Idproveedor;
                SqlCmd.Parameters.Add(ParIdcliente);

                SqlParameter ParRazon_Social = new SqlParameter();
                ParRazon_Social.ParameterName = "@sector_social";
                ParRazon_Social.SqlDbType = SqlDbType.VarChar;
                ParRazon_Social.Size = 20;
                ParRazon_Social.Value = Proveedor.Razon_Social;
                SqlCmd.Parameters.Add(ParRazon_Social);

                SqlParameter ParSector_Comercial = new SqlParameter();
                ParSector_Comercial.ParameterName = "@sector_comercial";
                ParSector_Comercial.SqlDbType = SqlDbType.VarChar;
                ParSector_Comercial.Size = 40;
                ParSector_Comercial.Value = Proveedor.Sector_Comercial;
                SqlCmd.Parameters.Add(ParSector_Comercial);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 100;
                ParDireccion.Value = Proveedor.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 10;
                ParTelefono.Value = Proveedor.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = Proveedor.Email;
                SqlCmd.Parameters.Add(ParEmail);

                SqlParameter ParUrl = new SqlParameter();
                ParUrl.ParameterName = "@url";
                ParUrl.SqlDbType = SqlDbType.VarChar;
                ParUrl.Size = 50;
                ParUrl.Value = Proveedor.Url;
                SqlCmd.Parameters.Add(ParUrl);


                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Actualizo el Registro";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        //Método Eliminar
        public string Eliminar(DProveedor Proveedor)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speliminar_proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdcliente = new SqlParameter();
                ParIdcliente.ParameterName = "@idpreovedor";
                ParIdcliente.SqlDbType = SqlDbType.Int;
                ParIdcliente.Value = Proveedor.Idproveedor;
                SqlCmd.Parameters.Add(ParIdcliente);
                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Elimino el Registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        //Método Mostrar
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("proveedor");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }


        //Método BuscarRazon_Social
        public DataTable BuscarRazon_Social(DProveedor Proveedor)
        {
            DataTable DtResultado = new DataTable("proveedor");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_proveedor_razon_social";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Proveedor.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

       
    }

}
