using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejador.Ferreteria;
using Entidades.Ferreteria;

namespace Presentacion.Ferreteria
{
    public partial class FrmHerramientas : Form
    {
        TallerManejador _herramientasmanejador;
        private int codigo=0;
        private string nombre = "";
        private string medida = "";
        private string marca = "";
        private string descripcion = "";
        public FrmHerramientas()
        {
            InitializeComponent();
            _herramientasmanejador = new TallerManejador();
        }
        private void FrmHerramientas_Load(object sender, EventArgs e)
        {
            LlenarHerramientas();
        }
        private void LlenarHerramientas()
        {
            dtgHerramientas.DataSource = _herramientasmanejador.ObtenerHerramientas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
            LlenarHerramientas();
        }
        private void Eliminar()
        {
            if (MessageBox.Show("estas segur@ que Deseas eliminar a esta Herramienta", "Eliminar Herramienta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var idherraamienta = int.Parse(dtgHerramientas.CurrentRow.Cells["codigoherramienta"].Value.ToString());
                _herramientasmanejador.EliminarHerramienta(idherraamienta);
            }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar(txtbuscar.Text);
        }
        private void Buscar(string valor)
        {
            dtgHerramientas.DataSource = _herramientasmanejador.BuscarHerramientas(valor);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmAgregarHerramienta FAH=new FrmAgregarHerramienta(0,"","","","",0);
            FAH.ShowDialog();
            LlenarHerramientas();
        }

        private void dtgHerramientas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = int.Parse(dtgHerramientas.CurrentRow.Cells["codigoherramienta"].Value.ToString());
            nombre = dtgHerramientas.CurrentRow.Cells["nombre"].Value.ToString();
            medida = dtgHerramientas.CurrentRow.Cells["medida"].Value.ToString();
            marca = dtgHerramientas.CurrentRow.Cells["marca"].Value.ToString();
            descripcion = dtgHerramientas.CurrentRow.Cells["descripcion"].Value.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FrmAgregarHerramienta FAH = new FrmAgregarHerramienta(codigo,nombre,medida,marca,descripcion,1);
            FAH.ShowDialog();
            LlenarHerramientas();
        }
    }
}
