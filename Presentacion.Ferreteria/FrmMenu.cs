using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Ferreteria
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void OptRefacciones_Click(object sender, EventArgs e)
        {
            FrmRefacciones FR = new FrmRefacciones();
            FR.MdiParent = this;
            FrmUsuarios FU = new FrmUsuarios();
            FU.Close();
            FrmHerramientas FH = new FrmHerramientas();
            FH.Close();
            FR .Show();
        }

        private void OptHerramientas_Click(object sender, EventArgs e)
        {
            FrmHerramientas FH = new FrmHerramientas();
            FH.MdiParent = this;
            FrmUsuarios FU = new FrmUsuarios();
            FU.Close();
            FrmRefacciones FR = new FrmRefacciones();
            FR.Close();
            FH.Show();
        }

        private void OptUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios FU = new FrmUsuarios();
            FU.MdiParent = this;
            FrmHerramientas FH = new FrmHerramientas();
            FH.Close();
            FrmRefacciones FR = new FrmRefacciones();
            FR.Close();
            FU.Show();
        }
    }
}
