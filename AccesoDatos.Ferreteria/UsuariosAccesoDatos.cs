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
        public List<USUARIOS> ObtenerUsuarios()
        {
            var ListaUsuarios = new List<USUARIOS>();
            var dt = new DataTable();
            dt = conexion.ObtenerDatos("select * from USUARIOS");
            foreach (DataRow renglon in dt.Rows)
            {
                var usuarios = new USUARIOS
                {
                    IdUsuario = Convert.ToInt32(renglon["idusuario"]),
                    Nombre = renglon["nombre"].ToString(),
                    ApellidoP = renglon["apellidop"].ToString(),
                    ApellidoM = renglon["apellidom"].ToString(),
                    FechaNacimiento= renglon["fechanacimiento"].ToString(),
                    RFC=renglon["rfc"].ToString(),                    
                    Clave = renglon["clave"].ToString(),
                    Lectura =renglon["lectura"].ToString(),
                    Escritura = renglon["escritura"].ToString(),
                    Eliminar = renglon["eliminacion"].ToString(),
                    Actualizar = renglon["actualizar"].ToString(),
                };
                ListaUsuarios.Add(usuarios);
            }
            return ListaUsuarios;
        }
        public void GuardarUsuario(USUARIOS nuevousuario)
        {
            string consulta = string.Format("Insert Into USUARIOS values(null,'{0}','{1}','{2}','{3}','{4}',SHA1('{5}'),{6},{7},{8},{9});",
                nuevousuario.Nombre,nuevousuario.ApellidoP,nuevousuario.ApellidoM,nuevousuario.FechaNacimiento,nuevousuario.RFC,
                nuevousuario.Clave,nuevousuario.Lectura,nuevousuario.Escritura,nuevousuario.Eliminar,nuevousuario.Actualizar);
            conexion.EjecutarConsulta(consulta);
        }
        public List<USUARIOS> BuscarUsuario(string valor)
        {
            var ListaUsuarios = new List<USUARIOS>();
            var dt = new DataTable();
            var consulta = string.Format("select * from USUARIOS where idusuario like '%{0}%' or nombre like '%{0}%' or apellidop like '%{0}%' " +
                "or apellidom like '%{0}%' or fechanacimiento like '%{0}%' or rfc like '%{0}%';", valor);
            dt = conexion.ObtenerDatos(consulta);
            foreach (DataRow renglon in dt.Rows)
            {
                var usuarios = new USUARIOS
                {
                    IdUsuario = Convert.ToInt32(renglon["idusuario"]),
                    Nombre = renglon["nombre"].ToString(),
                    ApellidoP = renglon["apellidop"].ToString(),
                    ApellidoM = renglon["apellidom"].ToString(),
                    FechaNacimiento = renglon["fechanacimiento"].ToString(),
                    RFC = renglon["rfc"].ToString(),
                    Clave = renglon["clave"].ToString(),
                    Lectura = renglon["lectura"].ToString(),
                    Escritura = renglon["escritura"].ToString(),
                    Eliminar = renglon["eliminacion"].ToString(),
                    Actualizar = renglon["actualizar"].ToString(),
                };
                ListaUsuarios.Add(usuarios);
            }
            return ListaUsuarios;
        }
        public void EliminarUsuario(int usuario)
        {
            string consulta = string.Format("delete from USUARIOS where idusuario={0};", usuario);
            conexion.EjecutarConsulta(consulta);
        }
        public void ActualizarUsuario(USUARIOS usuario)
        {
            string consulta = string.Format("update USUARIOS set nombre='{0}',apellidop='{1}',apellidom='{2}',fechanacimiento='{3}'," +
                "rfc='{4}',lectura={5},escritura={6},eliminacion={7},actualizar={8} where idusuario={9};",
                usuario.Nombre,usuario.ApellidoP, usuario.ApellidoM, usuario.FechaNacimiento, usuario.RFC,usuario.Lectura
                , usuario.Escritura, usuario.Eliminar, usuario.Actualizar,usuario.IdUsuario);
            conexion.EjecutarConsulta(consulta);
        }
    }
}