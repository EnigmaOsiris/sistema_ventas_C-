using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;
using System.Data.SqlClient;
using System.Data;

namespace CapaNegocio
{
   public class NProveedor
    {

        public static string Insertar(string sector_social, string sector_comercial, 
            string direccion, string telefono, string email, string url)
        {
            DProveedor Obj = new DProveedor();
            Obj.Razon_Social = sector_social;
            Obj.Sector_Comercial = sector_comercial;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
            Obj.Url = url;

            return Obj.Insertar(Obj);
        }

        //Método Editar 
        public static string Editar(int idproveedor, string sector_social,
            string sector_comercial, string direccion, string telefono, 
            string email, string url)
        {
            DProveedor Obj = new DProveedor();
            Obj.Idproveedor = idproveedor;
            Obj.Razon_Social = sector_social;
            Obj.Sector_Comercial = sector_comercial;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
            Obj.Url = url;
            return Obj.Editar(Obj);
        }

        //Método Eliminar 
        public static string Eliminar(int idpreovedor)
        {
            DProveedor Obj = new DProveedor();
            Obj.Idproveedor = idpreovedor;
            return Obj.Eliminar(Obj);
        }

        //Método Mostrar 
        public static DataTable Mostrar()
        {
            return new DProveedor().Mostrar();
        }

        //Método BuscarRazon_Social 
        public static DataTable BuscarRazon_Social(string textobuscar)
        {
            DProveedor Obj = new DProveedor();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarRazon_Social(Obj);
        }

    }
}
