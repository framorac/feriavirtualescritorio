using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPLETE_FLAT_UI
{
    public partial class FormEditCliente : Form
    {
        int id;
        ServiciosUsuarios.UsuariosClient serviciosUsuarios = new ServiciosUsuarios.UsuariosClient();
        public FormEditCliente()
        {
            InitializeComponent();
        }


        private void BtnEditar_Click(object sender, EventArgs e)
        {
            //int id, string username, string password, int fk_perfil, string nombre
            //string apellido, string email, DateTime fecha
            string perfil = txtTipoUsuario.Text;
            

            switch (perfil)
            {
                case "admin":
                    id = 1;
                    break;
                case "user":
                    id = 2;
                    break;
                case "productor":
                    id = 3;
                    break;
                case "transporte":
                    id = 4;
                    break;
                case "consultor":
                    id = 5;
                    break;
                case "cliente interno":
                    id = 6;
                    break;
                case "cliente externo":
                    id = 7;
                    break;
                default:
                    id = 0;
                    break;
            }
           
            serviciosUsuarios.UpdateUsuario(Convert.ToInt32(txtID.Text), txtUsuario.Text,txtContraseña.Text, id, txtNombre.Text,
                                            txtApellido.Text, txtCorreo.Text, Convert.ToDateTime(txtFechaCreacion.Text));
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
