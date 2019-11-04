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
    public partial class FormElimContratos : Form
    {
        ServicioContratos.ServiceContratosClient serviciosContratos = new ServicioContratos.ServiceContratosClient();
        public FormElimContratos()
        {
            InitializeComponent();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            serviciosContratos.DeleteContrato(Convert.ToInt32(txtID.Text));
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
