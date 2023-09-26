using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entidades.Ferreteria;
using Mysqlx.Crud;

namespace AccesoDatos.Ferreteria
{
    public class RefacionesAccesoDatos
    {
        Conexion conexion;
        public RefacionesAccesoDatos()
        {
            conexion = new Conexion("localhost","root","","FERRETERIA",3306);
        }
        public List<REFACCIONES> ObtenerRefacciones()
        {
            var ListaRefacciones = new List<REFACCIONES>();
            var dt = new DataTable();
            dt = conexion.ObtenerDatos("select * from REFACCIONES");
            foreach (DataRow renglon in dt.Rows) 
            {
                var refacciones = new REFACCIONES
                {
                    CodigoBarras = Convert.ToInt32(renglon["codigobarras"]),
                    Nombre = renglon["nombre"].ToString(),
                    Descripcion = renglon["descripcion"].ToString(),
                    Marca = renglon["marca"].ToString(),
                };
                ListaRefacciones.Add(refacciones);
            }
            return ListaRefacciones;
        }
        public void GuardarRefaccion(REFACCIONES nuevarefaccion)
        {
            string consulta = string.Format("Insert Into refacciones values('{0}','{1}','{2}','{3}');",
                nuevarefaccion.CodigoBarras,nuevarefaccion.Nombre,nuevarefaccion.Descripcion,nuevarefaccion.Marca);
            conexion.EjecutarConsulta(consulta);
        }
        public List<REFACCIONES> BuscarRefacciones(string valor)
        {
            var ListaRefacciones = new List<REFACCIONES>();
            var dt = new DataTable();
            dt = conexion.ObtenerDatos("Select * from REFACCIONES where nombre like '%{0}%';");
            foreach (DataRow renglon in dt.Rows)
            {
                var refacciones = new REFACCIONES
                {
                    CodigoBarras = Convert.ToInt32(renglon["codigobarras"]),
                    Nombre = renglon["nombre"].ToString(),
                    Descripcion = renglon["descripcion"].ToString(),
                    Marca = renglon["marca"].ToString(),
                };
                ListaRefacciones.Add(refacciones);
            }
            return ListaRefacciones;
        }
        public void EliminarRefaccion(REFACCIONES refaccion)
        {
            string consulta = string.Format("delete from REFACCIONES where codigobarras='{0}';", refaccion);
            conexion.EjecutarConsulta(consulta);
        }
        public void ActualizarRefacciones(REFACCIONES refaccion)
        {
            string consulta = string.Format("update REFACCIONES set nombre='{0}',descripcion='{1}',marca='{2}' where codigobarras={3}",
                refaccion.Nombre,refaccion.Descripcion,refaccion.Marca,refaccion.CodigoBarras);
            conexion.EjecutarConsulta(consulta);
        }
    }
}
