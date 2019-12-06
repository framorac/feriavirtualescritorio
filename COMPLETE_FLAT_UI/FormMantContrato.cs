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
    public partial class FormMantContrato : Form
    {
        ServicioContratos.ServiceContratosClient servicesContratos = new ServicioContratos.ServiceContratosClient();
        ServiciosUsuarios.UsuariosClient serviciosUsuarios = new ServiciosUsuarios.UsuariosClient();
        public FormMantContrato()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMantContrato_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var resultado = serviciosUsuarios.GetUsuarios().Where(x => x.id == Convert.ToInt32(txtUsuario.Text)).FirstOrDefault();

            if (resultado.Perfil.ToLower().Equals("cliente externo"))
            {
                var mensaje = servicesContratos.InsertContrato(Convert.ToInt32(txtUsuario.Text), Convert.ToDateTime(dtpFechaInicio.Value.ToString("dd/MM/yyyy")), Convert.ToDateTime(dtpFechaFin.Value.ToString("dd/MM/yyyy")));
                MessageBox.Show(mensaje);
            }
            else
            {
                MessageBox.Show("Por favor, los contratos solo pueden realizarse con perfiles de tipo cliente externo.");
            }
            
        }
    }
}
