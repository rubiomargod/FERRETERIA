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
        private bool lectura=false;
        private bool escribir=false;
        private bool eliminar =false;
        private bool actualizar=false;
        public FrmMenu(string le, string es, string el, string ac)
        {
            InitializeComponent();
            //texto.Text = string.Format("{0},{1},{2},{3}",le,es,el,ac);
            permisos(le,es,el,ac);
        }

        private void OptRefacciones_Click(object sender, EventArgs e)
        {
            FrmRefacciones FR = new FrmRefacciones(lectura,escribir,eliminar,actualizar);
            FR.MdiParent = this;
            FrmUsuarios FU = new FrmUsuarios(lectura, escribir, eliminar, actualizar);
            FU.Close();
            FrmHerramientas FH = new FrmHerramientas(lectura, escribir, eliminar, actualizar);
            FH.Close();
            FR .Show();            
        }

        private void OptHerramientas_Click(object sender, EventArgs e)
        {
            FrmHerramientas FH = new FrmHerramientas(lectura, escribir, eliminar, actualizar);
            FH.MdiParent = this;
            FrmUsuarios FU = new FrmUsuarios(lectura, escribir, eliminar, actualizar);
            FU.Close();
            FrmRefacciones FR = new FrmRefacciones(lectura, escribir, eliminar, actualizar);
            FR.Close();
            FH.Show();
        }

        private void OptUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios FU = new FrmUsuarios(lectura, escribir, eliminar, actualizar);
            FU.MdiParent = this;
            FrmHerramientas FH = new FrmHerramientas(lectura, escribir, eliminar, actualizar);
            FH.Close();
            FrmRefacciones FR = new FrmRefacciones(lectura, escribir, eliminar, actualizar);
            FR.Close();
            FU.Show();
        }
        private void permisos(string le,string es,string el,string ac)
        {
            if (le == "1")
                lectura = true;
            if (es == "1")
                escribir = true;
            if(el == "1")
                eliminar= true;
            if(ac =="1")
                actualizar= true;
        }

        private void Optsalir_Click(object sender, EventArgs e)
        {
            FrmLogin FL = new FrmLogin();
            Hide();
            FL.ShowDialog();
            this.Close();
        }
    }
}
