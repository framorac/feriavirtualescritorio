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
    public partial class FormEditContrato : Form
    {
        ServicioContratos.ServiceContratosClient servicioContratos = new ServicioContratos.ServiceContratosClient();
        public FormEditContrato()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                servicioContratos.UpdateVenta(Convert.ToInt32(txtUsuario.Text), Convert.ToDateTime(dtpFechaInicio.Value.ToString("dd/MM/yyyy")), Convert.ToDateTime(dtpFechaFin.Value.ToString("dd/MM/yyyy")));
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema al intentar editar el contrato.");
            }
           
        }
    }
}
