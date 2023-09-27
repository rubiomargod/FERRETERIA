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
        public FrmRefacciones()
        {
            InitializeComponent();
            _refaccionesManejador = new RefaccionesManejador();
        }

        private void FrmRefacciones_Load(object sender, EventArgs e)
        {
            LlenarRefacciones();
        }
        private void LlenarRefacciones()
        {
            dtgrefacciones.DataSource = _refaccionesManejador.ObtenerRefacciones();
        }
    }
}
