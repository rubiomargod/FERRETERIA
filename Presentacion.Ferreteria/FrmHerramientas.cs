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
    }
}
