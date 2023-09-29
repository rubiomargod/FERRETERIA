using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.Ferreteria;

namespace Manejador.Ferreteria
{
    public class LoginManejador
    {
        LoginAccesoDatos _loginaccesodatos = new LoginAccesoDatos();
        public bool ValidarAcceso(string usuario, string clave)
        {
            if (_loginaccesodatos.ValidarUsuario(usuario,clave))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string Permisos(string usuario)
        {
            return _loginaccesodatos.Permisos(usuario);
        }
    }
}
