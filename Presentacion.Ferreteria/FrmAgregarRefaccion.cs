using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Ferreteria;
using Manejador.Ferreteria;

namespace Presentacion.Ferreteria
{
    public partial class FrmAgregarRefaccion : Form
    {
        RefaccionesManejador _refaccionesmanejador;
        private int i = 0;
        public FrmAgregarRefaccion(int c,string n,string d,string m,int v)
        {
            InitializeComponent();
            _refaccionesmanejador = new RefaccionesManejador();
            if (v == 1)
            {
                txtCodigodeBarras.Text=c.ToString();
                txtNombre.Text=n.ToString();
                txtDescripcion.Text=d.ToString();
                txtMarca.Text=m.ToString();
                txtCodigodeBarras.Enabled = false;
                i = 1;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (i == 1)
                ModificarRefacion();
            else
                GuardarRefaccion();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ModificarRefacion()
        {
            REFACCIONES nuevarefaccion = new REFACCIONES();
            nuevarefaccion.CodigoBarras = int.Parse(txtCodigodeBarras.Text);
            nuevarefaccion.Nombre = txtNombre.Text;
            nuevarefaccion.Descripcion = txtDescripcion.Text;
            nuevarefaccion.Marca = txtMarca.Text;
            var validar = _refaccionesmanejador.ValidarRefaccion(nuevarefaccion);
            if (validar.Item1)
            {
                _refaccionesmanejador.ActualizarRefacciones(nuevarefaccion);
                this.Close();
            }
            else
                MessageBox.Show(validar.Item2, "Error de Campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void GuardarRefaccion()
        {
            REFACCIONES nuevarefaccion = new REFACCIONES();
            if (txtCodigodeBarras.Text == "")
                nuevarefaccion.CodigoBarras = 0;
            else
                nuevarefaccion.CodigoBarras = int.Parse(txtCodigodeBarras.Text);
            nuevarefaccion.Nombre = txtNombre.Text;
            nuevarefaccion.Descripcion = txtDescripcion.Text;
            nuevarefaccion.Marca = txtMarca.Text;

            var validar = _refaccionesmanejador.ValidarRefaccion(nuevarefaccion);
            if (validar.Item1)
            {
                _refaccionesmanejador.GuardarRefacciones(nuevarefaccion);
                this.Close();
            }
            else
                MessageBox.Show(validar.Item2, "Error de Campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
