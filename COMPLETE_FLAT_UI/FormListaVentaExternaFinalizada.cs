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
    public partial class FormListaVentaExternaFinalizada : Form
    {
        ServiceVentas.ServiceVentasClient servicioVentas = new ServiceVentas.ServiceVentasClient();
        ServicioAcciones.ServiceAccionesClient servicioAcciones = new ServicioAcciones.ServiceAccionesClient();
        public FormListaVentaExternaFinalizada()
        {
            InitializeComponent();
        }

        private void FormListaVentaExternaFinalizada_Load(object sender, EventArgs e)
        {
            dgvVentasFinalizadas.DataSource = servicioVentas.GetVentaCompletaFiltradoFinalizada(6, 2);
            dgvVentasFinalizadas.AutoGenerateColumns = false;

            dgvVentasFinalizadas.Columns["Id"].DisplayIndex = 0;
            dgvVentasFinalizadas.Columns["NombreApellido"].DisplayIndex = 1;
            dgvVentasFinalizadas.Columns["Tipo"].DisplayIndex = 2;
            dgvVentasFinalizadas.Columns["Estado"].DisplayIndex = 3;
            dgvVentasFinalizadas.Columns["Fecha"].DisplayIndex = 4;

            dgvVentasFinalizadas.Columns[0].HeaderText = "Estado de la venta";
            dgvVentasFinalizadas.Columns[1].HeaderText = "Fecha de la venta";
            dgvVentasFinalizadas.Columns[2].HeaderText = "ID de la venta";
            dgvVentasFinalizadas.Columns[3].HeaderText = "Nombre del cliente";
            dgvVentasFinalizadas.Columns[4].HeaderText = "Tipo de venta";
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
