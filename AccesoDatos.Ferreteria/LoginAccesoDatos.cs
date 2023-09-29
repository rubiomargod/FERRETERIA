using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Ferreteria
{
    public class LoginAccesoDatos
    {
        Conexion conexion;
        public LoginAccesoDatos()
        {
            conexion = new Conexion("localhost", "root", "", "FERRETERIA", 3306);
        }
        public bool ValidarUsuario(string u, string p)
        {
            DataSet ds = conexion.ResultadoLogin(string.Format("call P_Validar('{0}','{1}')", u, sha1(p)), "USUARIOS");
            DataTable dt = ds.Tables["USUARIOS"];
            DataRow r = dt.Rows[0];
            if (r["rs"].ToString().Equals("C0rr3ct0"))
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
            DataSet ds = conexion.Permisos(string.Format("call P_Permisos('{0}')", usuario), "USUARIOS");
            DataTable dt = ds.Tables["USUARIOS"];
            DataRow r = dt.Rows[0];
            return r["rs"].ToString();
        }
        public static string sha1(string texto)
        {
            SHA1 sha1 = SHA1CryptoServiceProvider.Create();
            Byte[] TextOriginal = ASCIIEncoding.Default.GetBytes(texto);
            Byte[] hash = sha1.ComputeHash(TextOriginal);
            StringBuilder cadena = new StringBuilder();
            foreach (byte i in hash)
            {
                cadena.AppendFormat("{0:x2}", i);
            }
            return cadena.ToString();
        }
    }
}
