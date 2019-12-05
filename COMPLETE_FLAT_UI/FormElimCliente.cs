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
    public partial class FormElimCliente : Form
    {
        ServiciosUsuarios.UsuariosClient serviciosUsuarios = new ServiciosUsuarios.UsuariosClient();
        ServiceVentas.ServiceVentasClient serviciosVentas = new ServiceVentas.ServiceVentasClient();
        public FormElimCliente()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            var mensaje = serviciosUsuarios.DeleteUsuario(Convert.ToInt32(txtID.Text));
            MessageBox.Show(mensaje);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
