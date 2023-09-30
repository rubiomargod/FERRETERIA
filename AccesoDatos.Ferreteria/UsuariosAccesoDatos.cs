using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Ferreteria;

namespace AccesoDatos.Ferreteria
{
    public class UsuariosAccesoDatos
    {
        Conexion conexion;
        public UsuariosAccesoDatos()
        {
            conexion = new Conexion("localhost", "root", "", "FERRETERIA", 3306);
        }
        public List<USUARIOS> ObtenerRefacciones()
        {
            var ListaUsuarios = new List<USUARIOS>();
            var dt = new DataTable();
            dt = conexion.ObtenerDatos("select * from USUARIOS");
            foreach (DataRow renglon in dt.Rows)
            {
                var usuarios = new USUARIOS
                {
                    IdUsuario = Convert.ToInt32(renglon[""]),
                    Nombre = renglon[""].ToString(),
                    ApellidoP = renglon[""].ToString(),
                    ApellidoM = renglon[""].ToString(),
                    FechaNacimiento= renglon[""].ToString(),
                    RFC=renglon[""].ToString(),

                    Clave = renglon[""].ToString(),
                    Lectura =renglon[""].ToString(),
                    Escritura = renglon[""].ToString(),
                    Eliminar = renglon[""].ToString(),
                    Actualizar = renglon[""].ToString(),
                };
                ListaUsuarios.Add(usuarios);
            }
            return ListaUsuarios;
        }
    }
}
