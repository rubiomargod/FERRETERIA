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
    public partial class FrmAgregarUsuarios : Form
    {
        UsuariosManejador _usuariosmanejador;
        private int i = 0;
        private int idusuario = 0;
        public FrmAgregarUsuarios(int id,string n,string ap,string am,string f,string rfc,string c,string l,string es,string el,string ac,int v)
        {
            InitializeComponent();
            _usuariosmanejador = new UsuariosManejador();
            if (v == 1)
            {
                idusuario= id;
                txtNombre.Text =n.ToString();
                txtApellidoP.Text =ap.ToString();
                txtApellidoM.Text =am.ToString();
                txtFechaN.Text =f.ToString();
                txtRFC.Text =rfc.ToString();
                //txtClave.Text =c.ToString();
                if(l.ToString().ToLower()=="true")
                ChkbLectura.Checked=true;
                if (es.ToString().ToLower() == "true")
                ChkbEscritura.Checked = true;
                if (el.ToString().ToLower() == "true")
                ChkbEliminar.Checked = true;
                if (ac.ToString().ToLower() == "true")
                ChkbActualizar.Checked = true;                
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
                ModificarUsuario();
            else
                GuardarUsuario();
        }
        private void ModificarUsuario()
        {
            USUARIOS nuevousuario = new USUARIOS();
            nuevousuario.IdUsuario = idusuario;
            nuevousuario.Nombre = txtNombre.Text;
            nuevousuario.ApellidoP = txtApellidoP.Text;
            nuevousuario.ApellidoM = txtApellidoM.Text;
            nuevousuario.FechaNacimiento = txtFechaN.Text;
            nuevousuario.RFC = txtRFC.Text;
            nuevousuario.Clave = txtClave.Text;
            if (ChkbLectura.Checked == true)
                nuevousuario.Lectura = "true";
            else
                nuevousuario.Lectura = "false";
            if (ChkbEscritura.Checked == true)
                nuevousuario.Escritura = "true";
            else
                nuevousuario.Escritura = "false";
            if (ChkbEliminar.Checked == true)
                nuevousuario.Eliminar = "true";
            else
                nuevousuario.Eliminar = "false";
            if (ChkbActualizar.Checked == true)
                nuevousuario.Actualizar = "true";
            else
                nuevousuario.Actualizar = "false";
            var validar = _usuariosmanejador.ValidarUsuario(nuevousuario);
            if (validar.Item1)
            {
                _usuariosmanejador.ActualizarUsuarios(nuevousuario);
                this.Close();
            }
            else
                MessageBox.Show(validar.Item2, "Error de Campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void GuardarUsuario()
        {
            USUARIOS nuevousuario = new USUARIOS();
            nuevousuario.Nombre = txtNombre.Text;
            nuevousuario.ApellidoP = txtApellidoP.Text;
            nuevousuario.ApellidoM = txtApellidoM.Text;
            nuevousuario.FechaNacimiento=txtFechaN.Text;
            nuevousuario.RFC=txtRFC.Text;
            nuevousuario.Clave=txtClave.Text;
            if(ChkbLectura.Checked==true)
                nuevousuario.Lectura = "true";
            else
                nuevousuario.Lectura = "false";
            if (ChkbEscritura.Checked == true)
                nuevousuario.Escritura = "true";
            else
                nuevousuario.Escritura = "false";
            if (ChkbEliminar.Checked == true)
                nuevousuario.Eliminar = "true";
            else
                nuevousuario.Eliminar = "false";
            if (ChkbActualizar.Checked == true)
                nuevousuario.Actualizar = "true";
            else
                nuevousuario.Actualizar = "false";
            var validar = _usuariosmanejador.ValidarUsuario(nuevousuario);
            if(validar.Item1)
            {
                _usuariosmanejador.GuardarUsuario(nuevousuario);
                this.Close();
            }
            else
                MessageBox.Show(validar.Item2, "Error de Campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
