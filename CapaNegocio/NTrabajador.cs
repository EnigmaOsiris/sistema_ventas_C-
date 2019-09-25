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
    public class NTrabajador
    {
        public static string Insertar(string nombre,string apellidos,
            string sexo,string direccion,string telefono,string email,
            string acceso,string usuario,string contraseña)
        {
            DTrabajador Obj = new DTrabajador();
            Obj.Nombre = nombre;
            Obj.Apellidos = apellidos;
            Obj.Sexo = sexo;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
            Obj.Acceso = acceso;
            Obj.Usuario = usuario;
            Obj.Contraseña = contraseña;
            return Obj.Insertar(Obj);
        }
        //Método Editar 
        public static string Editar(int idtrabajador, string nombre, string apellidos, 
            string sexo, string direccion, string telefono, string email,
            string acceso, string usuario, string contraseña)
        {
            DTrabajador Obj = new DTrabajador();
            Obj.Idtrabajador = idtrabajador;
            Obj.Nombre = nombre;
            Obj.Apellidos = apellidos;
            Obj.Sexo = sexo;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
            Obj.Acceso = acceso;
            Obj.Usuario = usuario;
            Obj.Contraseña = contraseña;

            return Obj.Editar(Obj);
        }
        //Método Eliminar
        public static string Eliminar(int idtrabajador)
        {
            DTrabajador Obj = new DTrabajador();
            Obj.Idtrabajador = idtrabajador;
            return Obj.Eliminar(Obj);
        }

        //Método Mostrar
        public static DataTable Mostrar()
        {
            return new DTrabajador().Mostrar();
        }
        //Método BuscarNombre
        public static DataTable BuscarNombre(string textobuscar)
        {
            DTrabajador Obj = new DTrabajador();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }

        public static DataTable Login(string usuario,string contrasena)
        {
            DTrabajador Obj = new DTrabajador();
            Obj.Usuario = usuario;
            Obj.Contraseña = contrasena;
            return Obj.Login(Obj);
        }
    }
}
