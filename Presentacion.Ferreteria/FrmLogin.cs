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
    public partial class FrmLogin : Form
    {
        LoginManejador _loginmanejador;
        private string [] arreglo = null;
        public FrmLogin()
        {
            InitializeComponent();
            _loginmanejador = new LoginManejador();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (_loginmanejador.ValidarAcceso(txtUsuario.Text, txtClave.Text))
            {
                Permisos(txtUsuario.Text);
                FrmMenu FM = new FrmMenu(arreglo[0], arreglo[1], arreglo[2],arreglo[3]);
                Hide();
                FM.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Error de credenciales");
        }
        private void Permisos(string usuarios)
        {
            string permisos=_loginmanejador.Permisos(usuarios);
            arreglo =permisos.Split(',');
        }
    }
}