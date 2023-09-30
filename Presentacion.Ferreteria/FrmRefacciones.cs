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
    public partial class FrmRefacciones : Form
    {
        RefaccionesManejador _refaccionesManejador;
        private int codigobarra = 0;
        private string nombre = "";
        private string descripcion = "";
        private string marca = "";
        public FrmRefacciones(bool le, bool es, bool el, bool ac)
        {
            InitializeComponent();
            _refaccionesManejador = new RefaccionesManejador();
            ControlarBotones(es,el,ac);
        }
        private void ControlarBotones(Boolean escribir,Boolean eliminar,Boolean actualizar)
        {
            btnNuevo.Enabled = escribir;
            btnEliminar.Enabled = eliminar;
            btnModificar.Enabled = actualizar;
        }

        private void FrmRefacciones_Load(object sender, EventArgs e)
        {
            LlenarRefacciones();
        }
        private void LlenarRefacciones()
        {
            dtgrefacciones.DataSource = _refaccionesManejador.ObtenerRefacciones();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
            LlenarRefacciones();
        }
        private void Eliminar()
        {
            if (MessageBox.Show("estas segur@ que Deseas eliminar a esta Refaccion", "Eliminar Refaccion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var idrefaccion = int.Parse(dtgrefacciones.CurrentRow.Cells["codigobarras"].Value.ToString());
                _refaccionesManejador.EliminarRefaccion(idrefaccion);
            }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar(txtbuscar.Text);
        }
        private void Buscar(string valor)
        {
            dtgrefacciones.DataSource = _refaccionesManejador.BuscarRefaccione(valor);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmAgregarRefaccion FAR = new FrmAgregarRefaccion(0,"","","",0);
            FAR.ShowDialog();
            LlenarRefacciones();
        }

        private void dtgrefacciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codigobarra =int.Parse(dtgrefacciones.CurrentRow.Cells["codigobarras"].Value.ToString());
            nombre = dtgrefacciones.CurrentRow.Cells["nombre"].Value.ToString();
            descripcion = dtgrefacciones.CurrentRow.Cells["descripcion"].Value.ToString();
            marca = dtgrefacciones.CurrentRow.Cells["Marca"].Value.ToString();           
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FrmAgregarRefaccion FAR = new FrmAgregarRefaccion(codigobarra,nombre,descripcion,marca,1);
            FAR.ShowDialog();
            LlenarRefacciones();
        }
    }
}