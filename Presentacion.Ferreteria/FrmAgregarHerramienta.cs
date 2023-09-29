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
    public partial class FrmAgregarHerramienta : Form
    {
        TallerManejador _Heramientasmanejador;
        private int i = 0;
        public FrmAgregarHerramienta(int c, string n, string me, string ma,string d,int v)
        {
            InitializeComponent();
            _Heramientasmanejador = new TallerManejador();
            if(v==1)
            {
                txtCodigodeBarras.Text=c.ToString();
                txtNombre.Text=n.ToString();
                txtMedida.Text=me.ToString();
                txtMarca.Text=ma.ToString();   
                txtDescripcion.Text=d.ToString();
                txtCodigodeBarras.Enabled=false;
                i = 1;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (i == 1)
                ModificarHerramienta();
            else
                GuardarHerramienta();
        }
        private void GuardarHerramienta()
        {
            TALLER nuevaherramienta = new TALLER();
            if (txtCodigodeBarras.Text == "")
                nuevaherramienta.CodigoHerramienta = 0;
            else
                nuevaherramienta.CodigoHerramienta=int.Parse(txtCodigodeBarras.Text);
            nuevaherramienta.Nombre = txtNombre.Text;
            nuevaherramienta.Medida = txtMedida.Text;
            nuevaherramienta.Marca=txtMarca.Text;
            nuevaherramienta.Descripcion=txtDescripcion.Text;

            var validar=_Heramientasmanejador.ValidadHerramienta(nuevaherramienta);
            if (validar.Item1)
            {
                _Heramientasmanejador.GuardarHerramienta(nuevaherramienta);
                this.Close();
            }
            else
                MessageBox.Show(validar.Item2, "Error de Campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void ModificarHerramienta()
        {
            TALLER nuevaherramienta = new TALLER();
            nuevaherramienta.CodigoHerramienta = int.Parse(txtCodigodeBarras.Text);
            nuevaherramienta.Nombre = txtNombre.Text;
            nuevaherramienta.Medida = txtMedida.Text;
            nuevaherramienta.Marca = txtMarca.Text;
            nuevaherramienta.Descripcion = txtDescripcion.Text;
            var validar = _Heramientasmanejador.ValidadHerramienta(nuevaherramienta);
            if (validar.Item1)
            {
                _Heramientasmanejador.ActualizarHerramienta(nuevaherramienta);
                this.Close();
            }
            else
                MessageBox.Show(validar.Item2, "Error de Campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
