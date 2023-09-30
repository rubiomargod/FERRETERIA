using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Ferreteria
{
    public class USUARIOS
    {
        private int _IdUsuario;
        private string _Nombre;
        private string _ApellidoP;
        private string _ApellidoM;
        private string _FechaNacimiento;
        private string _RFC;        
        private string _Clave;
        private string _Lectura;
        private string _Escritura;
        private string _Eliminar;
        private string _Actualizar;

        public int IdUsuario { get => _IdUsuario; set => _IdUsuario = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string ApellidoP { get => _ApellidoP; set => _ApellidoP = value; }
        public string ApellidoM { get => _ApellidoM; set => _ApellidoM = value; }
        public string FechaNacimiento { get => _FechaNacimiento; set => _FechaNacimiento = value; }
        public string RFC { get => _RFC; set => _RFC = value; }
        public string Clave { get => _Clave; set => _Clave = value; }
        public string Lectura { get => _Lectura; set => _Lectura = value; }
        public string Escritura { get => _Escritura; set => _Escritura = value; }
        public string Eliminar { get => _Eliminar; set => _Eliminar = value; }
        public string Actualizar { get => _Actualizar; set => _Actualizar = value; }
    }
}
