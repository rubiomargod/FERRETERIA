using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Ferreteria;
using AccesoDatos.Ferreteria;

namespace Manejador.Ferreteria
{
    public class RefaccionesManejador
    {
        private RefaccionesAccesoDatos _refaccionesaccesodatos;
        public RefaccionesManejador()
        {
            _refaccionesaccesodatos = new RefaccionesAccesoDatos();
        }
        public List<REFACCIONES> ObtenerRefacciones()
        {
            return _refaccionesaccesodatos.ObtenerRefacciones();
        }
        public List<REFACCIONES> BuscarRefaccione(string valor)
        {
            return _refaccionesaccesodatos.BuscarRefacciones(valor);
        }
        public void GuardarRefacciones(REFACCIONES nuevarefaccion)
        {
            _refaccionesaccesodatos.GuardarRefaccion(nuevarefaccion);
        }
        public void ActualizarRefacciones(REFACCIONES refacciones)
        {
            _refaccionesaccesodatos.ActualizarRefacciones(refacciones);
        }
        public void EliminarRefaccion(int refaccion)
        {
            _refaccionesaccesodatos.EliminarRefaccion(refaccion);
        }
        public Tuple<bool, string> ValidarRefaccion(REFACCIONES nuevarefacion)
        {
            string mensaje ="";
            bool valida = true;
            if (nuevarefacion.CodigoBarras.ToString() == "")
            {
                mensaje = mensaje + "El Campo CodigoBarras es Reqerido \n";
                valida = false;
            }
            if (nuevarefacion.Nombre.ToString() == "")
            {
                mensaje = mensaje + "El Campo Nombre es Reqerido \n";
                valida = false;
            }
            if (nuevarefacion.Descripcion.ToString() == "")
            {
                mensaje = mensaje + "El Campo Descripcion es Reqerido \n";
                valida = false;
            }
            if (nuevarefacion.Marca.ToString() == "")
            {
                mensaje = mensaje + "El Campo Marca es Reqerido \n";
                valida = false;
            }
            var validar = new Tuple<bool, string>(valida, mensaje);
            return validar;
        }
    }
}