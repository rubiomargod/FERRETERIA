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
    public partial class FrmUsuarios : Form
    {
        UsuariosManejador _usuariosmanejador;
        private int idusuario = 0;
        private string nombre = "";
        private string apellidop = "";
        private string apellidom = "";
        private string fecha = "";
        private string rfc = "";
        private string clave = "";
        private string lectura = "";
        private string escribir = "";
        private string eliminar = "";
        private string actualizar = "";

        public FrmUsuarios(bool le, bool es, bool el, bool ac)
        {
            InitializeComponent();
            _usuariosmanejador = new UsuariosManejador();
            ControlarBotones(es, el, ac);
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            LlenarUsuarios();
        }
        private void LlenarUsuarios()
        {
            dtgUsuarios.DataSource = _usuariosmanejador.ObtenerUsuarios();
        }
        private void ControlarBotones(Boolean escribir, Boolean eliminar, Boolean actualizar)
        {
            btnNuevo.Enabled = escribir;
            btnEliminar.Enabled = eliminar;
            btnModificar.Enabled = actualizar;
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar(txtbuscar.Text);
        }
        private void Buscar(string valor)
        {
            dtgUsuarios.DataSource = _usuariosmanejador.BuscarUsuarios(valor);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
            LlenarUsuarios();
        }
        private void Eliminar()
        {
            if (MessageBox.Show("estas segur@ que Deseas eliminar a este Usuario", "Eliminar Usuario", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var idrefaccion = int.Parse(dtgUsuarios.CurrentRow.Cells["idusuario"].Value.ToString());
                _usuariosmanejador.EliminarUsuario(idrefaccion);
            }
        }

        private void dtgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idusuario = int.Parse(dtgUsuarios.CurrentRow.Cells["idusuario"].Value.ToString());
            nombre=dtgUsuarios.CurrentRow.Cells["nombre"].Value.ToString();
            apellidop = dtgUsuarios.CurrentRow.Cells["apellidop"].Value.ToString();
            apellidom = dtgUsuarios.CurrentRow.Cells["apellidom"].Value.ToString();
            fecha = dtgUsuarios.CurrentRow.Cells["fechanacimiento"].Value.ToString();
            rfc = dtgUsuarios.CurrentRow.Cells["rfc"].Value.ToString();
            clave = dtgUsuarios.CurrentRow.Cells["clave"].Value.ToString();
            lectura = dtgUsuarios.CurrentRow.Cells["lectura"].Value.ToString();
            escribir = dtgUsuarios.CurrentRow.Cells["escritura"].Value.ToString();
            eliminar = dtgUsuarios.CurrentRow.Cells["eliminar"].Value.ToString();
            actualizar = dtgUsuarios.CurrentRow.Cells["actualizar"].Value.ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmAgregarUsuarios FAU = new FrmAgregarUsuarios(0,"","","","","","","","","","",0);
            FAU.ShowDialog();
            LlenarUsuarios();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FrmAgregarUsuarios FAU = new FrmAgregarUsuarios(idusuario,nombre,apellidop,apellidom,fecha,rfc,clave,lectura,escribir,eliminar,actualizar, 1);
            FAU.ShowDialog();
            LlenarUsuarios();
        }
    }
}