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
    public class NArticulo
    { 
        //Método Insertar que llama al método Insertar de la clase DArtículo
        //de la CapaDatos
    public static string Insertar(string codigo, string nombre, string descripcion, byte[] imagen, int idcategoria, int idpresentacion)
    {
        DArticulos Obj = new DArticulos();
        Obj.Codigo = codigo;
        Obj.Nombre = nombre;
        Obj.Descripcion = descripcion;
        Obj.Imagen = imagen;
        Obj.Idcategoria = idcategoria;
        Obj.Idpresentacion = idpresentacion;
        return Obj.Insertar(Obj);
    }

    //Método Editar que llama al método Editar de la clase DArtículo
    //de la CapaDatos
    public static string Editar(int idarticulo, string codigo, string nombre, string descripcion, byte[] imagen, int idcategoria, int idpresentacion)
    {
        DArticulos Obj = new DArticulos();
        Obj.Idarticulo = idarticulo;
        Obj.Codigo = codigo;
        Obj.Nombre = nombre;
        Obj.Descripcion = descripcion;
        Obj.Imagen = imagen;
        Obj.Idcategoria = idcategoria;
        Obj.Idpresentacion = idpresentacion;
        return Obj.Editar(Obj);
    }

    //Método Eliminar que llama al método Eliminar de la clase DArtículo
    //de la CapaDatos
    public static string Eliminar(int idarticulo)
    {
        DArticulos Obj = new DArticulos();
        Obj.Idarticulo = idarticulo;
        return Obj.Eliminar(Obj);
    }

    //Método Mostrar que llama al método Mostrar de la clase DArtículo
    //de la CapaDatos
    public static DataTable Mostrar()
    {
        return new DArticulos().Mostrar();
    }

    //Método BuscarNombre que llama al método BuscarNombre
    //de la clase DArtículo de la CapaDatos

    public static DataTable BuscarNombre(string textobuscar)
    {
        DArticulos Obj = new DArticulos();
        Obj.TextoBuscar = textobuscar;
        return Obj.BuscarNombre(Obj);
    }
}
}