using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPLETE_FLAT_UI
{
    public partial class FormMantCliente : Form
    {
        ServicioPerfiles.ServicePerfilesClient servicioPerfiles = new ServicioPerfiles.ServicePerfilesClient();
        ServiciosUsuarios.UsuariosClient serviciosUsuarios = new ServiciosUsuarios.UsuariosClient();

        DateTime dateTime = DateTime.Now;
        public FormMantCliente()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMantCliente_Load(object sender, EventArgs e)
        {
            var ls = servicioPerfiles.GetPerfiles().ToList();

            foreach (var item in ls)
            {
                cbTipoUsuario.Items.Add(item);
            }
            cbTipoUsuario.DisplayMember = "Descripcion";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var perfil = cbTipoUsuario.SelectedItem as ServicioPerfiles.Perfiles;
            
            serviciosUsuarios.InsertUsuario(txtUsuario.Text, txtContraseña.Text, perfil.Id_perfil, txtNombre.Text, txtApellido.Text, txtCorreo.Text, DateTime.Now);
           
        }

    }
}
