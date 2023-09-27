using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Ferreteria;

namespace AccesoDatos.Ferreteria
{
    public class TallerAccesoDatos
    {
        Conexion conexion;
        public TallerAccesoDatos()
        {
            conexion = new Conexion("localhost", "root", "", "FERRETERIA", 3306);
        }
        public List<TALLER> ObtenerHerramientas()
        {
            var ListaHerramientas = new List<TALLER>();
            var dt = new DataTable();
            dt = conexion.ObtenerDatos("select * from taller");
            foreach (DataRow renglon in dt.Rows) 
            {
                var herramientas = new TALLER
                {
                    CodigoHerramienta = Convert.ToInt32(renglon["codigoherramienta"]),
                    Nombre = renglon["nombre"].ToString(),
                    Medida = renglon["medida"].ToString(),
                    Marca = renglon["marca"].ToString(),
                    Descripcion = renglon["descripcion"].ToString(),
                };
                ListaHerramientas.Add(herramientas);
            }
            return ListaHerramientas;
        }
        public void GuardarHerramientas(TALLER nuevaherramienta)
        {
            string consulta = string.Format("Insert Into taller values('{0}','{1}','{2}','{3}','{4}');",
                nuevaherramienta.CodigoHerramienta,nuevaherramienta.Nombre,nuevaherramienta.Medida,nuevaherramienta.Marca,nuevaherramienta.Descripcion);
            conexion.EjecutarConsulta(consulta);
        }
        public List<TALLER> BuscarHerramientas(string valor)
        {
            var ListaHerramientas = new List<TALLER>();
            var dt = new DataTable();
            dt = conexion.ObtenerDatos("Select * from taller where nombre like '%{0}%';");
            foreach (DataRow renglon in dt.Rows)
            {
                var herramientas = new TALLER
                {
                    CodigoHerramienta = Convert.ToInt32(renglon["codigoherramienta"]),
                    Nombre = renglon["nombre"].ToString(),
                    Medida = renglon["medida"].ToString(),
                    Marca = renglon["marca"].ToString(),
                    Descripcion = renglon["descripcion"].ToString(),
                };
                ListaHerramientas.Add(herramientas);
            }
            return ListaHerramientas;
        }
        public void EliminarHerramienta(int herramienta)
        {
            string consulta = string.Format("delete from taller where codigoherramienta='{0}';", herramienta);
            conexion.EjecutarConsulta(consulta);
        }
        public void ActualizarHerramienta(TALLER herramienta)
        {
            string consulta = string.Format("update taller set nombre='{0}',medida='{1}',marca='{2}',descripcion='{3}' where codigoherramienta={4}",
                herramienta.Nombre,herramienta.Medida,herramienta.Marca,herramienta.Descripcion,herramienta.CodigoHerramienta);
            conexion.EjecutarConsulta(consulta);
        }
    }
}
