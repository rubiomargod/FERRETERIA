using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Ferreteria;
using AccesoDatos.Ferreteria;

namespace Manejador.Ferreteria
{
    public class UsuariosManejador
    {
        UsuariosAccesoDatos _usuariosaccesodatos;
        public UsuariosManejador()
        {
            _usuariosaccesodatos = new UsuariosAccesoDatos();
        }
        public List<USUARIOS> ObtenerUsuarios()
        {
            return _usuariosaccesodatos.ObtenerUsuarios();
        }
        public List<USUARIOS> BuscarUsuarios(string valor)
        {
            return _usuariosaccesodatos.BuscarUsuario(valor);
        }
        public void GuardarUsuario(USUARIOS nuevousuario)
        {
            _usuariosaccesodatos.GuardarUsuario(nuevousuario);
        }
        public void ActualizarUsuarios(USUARIOS usuario)
        {
            _usuariosaccesodatos.ActualizarUsuario(usuario);
        }
        public void EliminarUsuario(int usuario)
        {
            _usuariosaccesodatos.EliminarUsuario(usuario);
        }
        public Tuple<bool, string> ValidarUsuario(USUARIOS nuevousuario)
        {
            string mensaje = "";
            bool valida = true;
            if(nuevousuario.Nombre=="")
            {
                mensaje = mensaje + "El Campo Nombre es Reqerido \n";
                valida = false;
            }
            if (nuevousuario.ApellidoP == "")
            {
                mensaje = mensaje + "El Campo Apellido Paterno es Reqerido \n";
                valida = false;
            }
            if (nuevousuario.ApellidoM == "")
            {
                mensaje = mensaje + "El Campo Apellido Materno es Reqerido \n";
                valida = false;
            }
            if (nuevousuario.FechaNacimiento == "")
            {
                mensaje = mensaje + "El Campo Fecha Nacimiento es Reqerido \n";
                valida = false;
            }
            if (nuevousuario.RFC == "")
            {
                mensaje = mensaje + "El Campo RFC es Reqerido \n";
                valida = false;
            }
            if (nuevousuario.Clave == "")
            {
                mensaje = mensaje + "El Campo Clave es Reqerido \n";
                valida = false;
            }
            if (nuevousuario.Lectura == "")
            {
                mensaje = mensaje + "El Campo Permiso Lectura es Reqerido \n";
                valida = false;
            }
            if (nuevousuario.Escritura == "")
            {
                mensaje = mensaje + "El Campo Permiso Escritura es Reqerido \n";
                valida = false;
            }
            if (nuevousuario.Eliminar == "")
            {
                mensaje = mensaje + "El Campo Permiso Eliminar es Reqerido \n";
                valida = false;
            }
            if (nuevousuario.Actualizar == "")
            {
                mensaje = mensaje + "El Campo Permiso Actualizar es Reqerido \n";
                valida = false;
            }
            var validar = new Tuple<bool, string>(valida, mensaje);
            return validar;
        }
    }
}
