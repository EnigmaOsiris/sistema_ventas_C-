using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;
using System.Data;
using System.Data.SqlClient;

namespace CapaNegocio
{
    public class NCategoria
    {
        public static string Insertar(string nombre,string descripcion)
        {
            Dcategoria Obj = new Dcategoria();
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Insertar(Obj);

        }
        //metodo editar
        public static string Editar(int idcategoria,string nombre, string descripcion)
        {
            Dcategoria Obj = new Dcategoria();
            Obj.IdCategoria = idcategoria;
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Editar(Obj);

        }
        //metodo eliminar
        public static string ELiminarr(int idcategoria)
        {
            Dcategoria Obj = new Dcategoria();
            Obj.IdCategoria = idcategoria;
            return Obj.Eliminar(Obj);

        }
        //metodo mostrar 
        public static DataTable Mostrar()
        {
            return new Dcategoria().Mostar();
        }
        //metodo BuscarNombre
        public static DataTable BuscarNombre(string textoBuscar)
        {
            Dcategoria Obj = new Dcategoria();
            Obj.TextoBuscar=textoBuscar;
            return Obj.BuscarNombre(Obj);
        }

    }
}
