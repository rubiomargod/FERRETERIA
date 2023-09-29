using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Ferreteria;
using AccesoDatos.Ferreteria;

namespace Manejador.Ferreteria
{
    public class TallerManejador
    {
        TallerAccesoDatos _tallerAccesoDatos;
        public TallerManejador()
        {
            _tallerAccesoDatos = new TallerAccesoDatos();
        }
        public List<TALLER> ObtenerHerramientas()
        {
            return _tallerAccesoDatos.ObtenerHerramientas();
        }
        public List<TALLER> BuscarHerramientas(string valor)
        {
            return _tallerAccesoDatos.BuscarHerramientas(valor);
        }
        public void GuardarHerramienta(TALLER herramienta)
        {
            _tallerAccesoDatos.GuardarHerramientas(herramienta);
        }
        public void ActualizarHerramienta(TALLER herramienta)
        {
            _tallerAccesoDatos.ActualizarHerramienta(herramienta);
        }
        public void EliminarHerramienta(int id)
        {
            _tallerAccesoDatos.EliminarHerramienta(id);
        }
        public Tuple<bool, string> ValidadHerramienta(TALLER nuevaherramienta)
        {
            string mensaje = "";
            bool valida = true;
            if (nuevaherramienta.CodigoHerramienta.ToString() == "")
            {
                mensaje = mensaje + "El Campo Codigo de Herramienta es Reqerido \n";
                valida = false;
            }
            if (nuevaherramienta.Nombre.ToString() == "")
            {
                mensaje = mensaje + "El Campo Nombre es Reqerido \n";
                valida = false;
            }
            if (nuevaherramienta.Medida.ToString() == "")
            {
                mensaje = mensaje + "El Campo Medida es Reqerido \n";
                valida = false;
            }
            if (nuevaherramienta.Marca.ToString() == "")
            {
                mensaje = mensaje + "El Campo Marca es Reqerido \n";
                valida = false;
            }
            if (nuevaherramienta.Descripcion.ToString() == "")
            {
                mensaje = mensaje + "El Campo Descripcion es Reqerido \n";
                valida = false;
            }
            var validar = new Tuple<bool, string>(valida, mensaje);
            return validar;
        }
    }
}