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
    public class NCliente
    {
        public static string Insertar(string nombre, string apellidos, 
            string sexo, DateTime fecha_nacimiento,string direccion, string telefono, string email)
        {
            DCliente Obj = new DCliente();
            Obj.Nombre = nombre;
            Obj.Apellidos = apellidos;
            Obj.Sexo = sexo;
            Obj.Fecha_Nacimiento = fecha_nacimiento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
            return Obj.Insertar(Obj);
        }
        //Método Editar 
        public static string Editar(int idcliente, string nombre, string apellidos,
            string sexo, DateTime fecha_nacimiento,string direccion, string telefono, string email)
        {
            DCliente Obj = new DCliente();
            Obj.Idcliente = idcliente;
            Obj.Nombre = nombre;
            Obj.Apellidos = apellidos;
            Obj.Sexo = sexo;
            Obj.Fecha_Nacimiento = fecha_nacimiento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;

            return Obj.Editar(Obj);
        }

        //Método Eliminar 
        public static string Eliminar(int idcliente)
        {
            DCliente Obj = new DCliente();
            Obj.Idcliente = idcliente;
            return Obj.Eliminar(Obj);
        }

        //Método Mostrar
        public static DataTable Mostrar()
        {
            return new DCliente().Mostrar();
        }

        //Método Buscarnombre
        public static DataTable BuscarNombre(string textobuscar)
        {
            DCliente Obj = new DCliente();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);

        }



    }
}
