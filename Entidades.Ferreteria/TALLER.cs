using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Ferreteria
{
    public class TALLER
    {
        private int _CodigoBarras;
        private string _Nombre;
        private string _Medida;
        private string _Marca;
        private string _Descripcion;
        public int CodigoBarras { get => _CodigoBarras; set => _CodigoBarras = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Medida { get => _Medida; set => _Medida = value; }
        public string Marca { get => _Marca; set => _Marca = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
    }
}
