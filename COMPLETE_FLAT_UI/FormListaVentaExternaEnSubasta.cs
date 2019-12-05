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
    public partial class FormListaVentaExternaEnSubasta : Form
    {
        ServiceVentas.ServiceVentasClient servicioVentas = new ServiceVentas.ServiceVentasClient();
        ServicioAcciones.ServiceAccionesClient servicioAcciones = new ServicioAcciones.ServiceAccionesClient();
        public FormListaVentaExternaEnSubasta()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            dgvSubastaTransporte.DataSource = servicioVentas.GetVentaCompletaFiltradoEnSubasta(6, 1).ToList();

            dgvSubastaTransporte.Columns["Id"].DisplayIndex = 0;
            dgvSubastaTransporte.Columns["NombreApellido"].DisplayIndex = 1;
            dgvSubastaTransporte.Columns["Tipo"].DisplayIndex = 2;
            dgvSubastaTransporte.Columns["Estado"].DisplayIndex = 3;
            dgvSubastaTransporte.Columns["Fecha"].DisplayIndex = 4;

            dgvSubastaTransporte.Columns[0].HeaderText = "Estado de la venta";
            dgvSubastaTransporte.Columns[1].HeaderText = "Fecha de la venta";
            dgvSubastaTransporte.Columns[2].HeaderText = "ID de la venta";
            dgvSubastaTransporte.Columns[3].HeaderText = "Nombre del cliente";
            dgvSubastaTransporte.Columns[4].HeaderText = "Tipo de venta";
        }

        private void FormListaVentaExternaEnSubasta_Load(object sender, EventArgs e)
        {
            dgvSubastaTransporte.DataSource = servicioVentas.GetVentaCompletaFiltradoEnSubasta(6, 1).ToList();

            dgvSubastaTransporte.Columns["Id"].DisplayIndex = 0;
            dgvSubastaTransporte.Columns["NombreApellido"].DisplayIndex = 1;
            dgvSubastaTransporte.Columns["Tipo"].DisplayIndex = 2;
            dgvSubastaTransporte.Columns["Estado"].DisplayIndex = 3;
            dgvSubastaTransporte.Columns["Fecha"].DisplayIndex = 4;

            dgvSubastaTransporte.Columns[0].HeaderText = "Estado de la venta";
            dgvSubastaTransporte.Columns[1].HeaderText = "Fecha de la venta";
            dgvSubastaTransporte.Columns[2].HeaderText = "ID de la venta";
            dgvSubastaTransporte.Columns[3].HeaderText = "Nombre del cliente";
            dgvSubastaTransporte.Columns[4].HeaderText = "Tipo de venta";
        }

        private void BtnCerrarProceso_Click(object sender, EventArgs e)
        {
            servicioAcciones.AdjudicarTransportista(Convert.ToInt32(dgvSubastaTransporte.CurrentRow.Cells[2].Value.ToString()));
        }
    }
}
