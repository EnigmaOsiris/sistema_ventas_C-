using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class Dcategoria
    {
        private int _idCategoria;
        private string _Nombre;
        private string _Descripcion;

        private string _TextoBuscar;

        public int IdCategoria
        {
            get{ return _idCategoria; }
            set{_idCategoria = value;}
        }
        public string Nombre {
            get{ return _Nombre; }
            set {_Nombre = value;
            }
        }
        public string Descripcion
        {
            get{ return _Descripcion;}
            set  {_Descripcion = value; }
        }
        public string TextoBuscar
        {
            get { return _TextoBuscar;}

            set {_TextoBuscar = value;}
        }
        //constructor bacio
        public Dcategoria()
        {

        }

        //constructor con parametros 
        public Dcategoria(int idCategoria, string nombre, string descripcion, string textoBuscar)
        {
            this.IdCategoria = idCategoria;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.TextoBuscar = textoBuscar;

        }
        //metodo insertar
        public string Insertar(Dcategoria Categoria)
        {
            string respuesta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.Cn;
                sqlCon.Open();
                SqlCommand sqlCnd = new SqlCommand();
                sqlCnd.Connection = sqlCon;
                sqlCnd.CommandText = "spInsertar_Categoria";
                sqlCnd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdcategoria = new SqlParameter();
                ParIdcategoria.ParameterName = "@idCategoria";
                ParIdcategoria.SqlDbType = SqlDbType.Int;
                ParIdcategoria.Direction = ParameterDirection.Output;
                sqlCnd.Parameters.Add(ParIdcategoria);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Categoria.Nombre;
                sqlCnd.Parameters.Add(ParNombre);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.SqlDbType = SqlDbType.Text;
                ParDescripcion.Value = Categoria.Descripcion;
                sqlCnd.Parameters.Add(ParDescripcion);

                //ejecuta comandos
                respuesta = sqlCnd.ExecuteNonQuery() == 1 ? "ok":"no se ingreso el " ;

            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
            return respuesta;

        }

        //metodo Editar
        public string Editar(Dcategoria Categoria)
        {
            string respuesta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.Cn;
                sqlCon.Open();
                SqlCommand sqlCnd = new SqlCommand();
                sqlCnd.Connection = sqlCon;
                sqlCnd.CommandText = "spEditar_Categoria";
                sqlCnd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdcategoria = new SqlParameter();
                ParIdcategoria.ParameterName = "@idCategoria";
                ParIdcategoria.SqlDbType = SqlDbType.Int;
                ParIdcategoria.Value = Categoria.IdCategoria;
                sqlCnd.Parameters.Add(ParIdcategoria);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Categoria.Nombre;
                sqlCnd.Parameters.Add(ParNombre);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.SqlDbType = SqlDbType.Text;
                ParDescripcion.Value = Categoria.Descripcion;
                sqlCnd.Parameters.Add(ParDescripcion);

                //ejecuta comandos
                respuesta = sqlCnd.ExecuteNonQuery() == 1 ? "ok" : "no se actualizo el registro ";

            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
            return respuesta;

        }
        //metodo Eliminar
        public string Eliminar(Dcategoria Categoria)
        {
            string respuesta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.Cn;
                sqlCon.Open();
                SqlCommand sqlCnd = new SqlCommand();
                sqlCnd.Connection = sqlCon;
                sqlCnd.CommandText = "spEliminar_categoria";
                sqlCnd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdcategoria = new SqlParameter();
                ParIdcategoria.ParameterName = "@idCategoria";
                ParIdcategoria.SqlDbType = SqlDbType.Int;
                ParIdcategoria.Value = Categoria.IdCategoria;
                sqlCnd.Parameters.Add(ParIdcategoria);


                //ejecuta comandos
                respuesta = sqlCnd.ExecuteNonQuery() == 1 ? "ok" : "no se elimino el registro ";

            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
            return respuesta;

        }
        //metodo Mostar
        public DataTable Mostar()
        {
            DataTable DtResultado = new DataTable("categoria");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spMostar_Categoria";
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
        //metodo BuscarNombre
        public DataTable BuscarNombre (Dcategoria Categoria)
    
        {
        DataTable DtResultado = new DataTable("categoria");
        SqlConnection SqlCon = new SqlConnection();
        try
        {
         
            SqlCon.ConnectionString = Conexion.Cn;

            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlCon;
            SqlCmd.CommandText = "spBuscar_categoria";
            SqlCmd.CommandType = CommandType.StoredProcedure;
  
            SqlParameter ParTextoBuscar = new SqlParameter();
            ParTextoBuscar.ParameterName = "@textoBuscar";
            ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
            ParTextoBuscar.Size = 50;
            ParTextoBuscar.Value = Categoria.TextoBuscar;
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