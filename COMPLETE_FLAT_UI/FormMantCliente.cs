using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
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

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            var perfil = cbTipoUsuario.SelectedItem as ServicioPerfiles.Perfiles;

            if (ValidarFormularioVacio() == false)
            {
                if (serviciosUsuarios.GetUsuarios().Where(x => x.Username.ToLower() == txtUsuario.Text.ToLower()).FirstOrDefault() != null && serviciosUsuarios.GetUsuarios().Where(x => x.Email.ToLower() == txtCorreo.Text.ToLower()).FirstOrDefault() != null)
                {
                    MessageBox.Show("Usuario y correo ya existen, por favor ingrese otro.");
                }
                else if (serviciosUsuarios.GetUsuarios().Where(x => x.Email.ToLower() == txtCorreo.Text.ToLower()).FirstOrDefault() != null)
                {
                    MessageBox.Show("El correo ingresado ya existe, por favor ingrese otro.");
                }
                else if (serviciosUsuarios.GetUsuarios().Where(x => x.Username.ToLower() == txtUsuario.Text.ToLower()).FirstOrDefault() != null)
                {
                    MessageBox.Show("El usuario ingresado ya existe, por favor ingrese otro.");
                }
                else
                {
                    if (ValidarEmail(txtCorreo.Text))
                    {
                        var mensaje = serviciosUsuarios.InsertUsuario(txtUsuario.Text, txtContraseña.Text, perfil.Id_perfil, txtNombre.Text, txtApellido.Text, txtCorreo.Text, DateTime.Now);
                        MessageBox.Show(mensaje);
                    }
                    else
                    {
                        MessageBox.Show("Por favor, valide que el formato de el mail sea correcto");
                    }
                    
                }
                
            }
            else
            {
                MessageBox.Show("Por favor, rellene todos los campos antes de guardar.");
            }
        }

        private Boolean ValidarFormularioVacio()
        {
            Boolean flag = false;

            if (txtUsuario.Text.Equals("") || txtContraseña.Text.Equals("") || txtNombre.Text.Equals("") || txtApellido.Text.Equals("") || txtCorreo.Text.Equals("") || cbTipoUsuario.SelectedItem == null)
            {
                flag = true;
            }
            else
            {
                flag = false;
            }

            return flag;
        }

        static bool ValidarEmail(string email)
        {
            try
            {
                new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
