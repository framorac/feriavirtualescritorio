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
    public partial class FormListaVentaExternaEnCamino : Form
    {
        ServiceVentas.ServiceVentasClient servicioVentas = new ServiceVentas.ServiceVentasClient();
        public FormListaVentaExternaEnCamino()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormListaVentaExternaEnCamino_Load(object sender, EventArgs e)
        {
            dgvVentaEnCamino.DataSource = servicioVentas.GetVentaCompletaFiltradoEnCamino(6, 2).ToList();

            dgvVentaEnCamino.Columns["Id"].DisplayIndex = 0;
            dgvVentaEnCamino.Columns["NombreApellido"].DisplayIndex = 1;
            dgvVentaEnCamino.Columns["Tipo"].DisplayIndex = 2;
            dgvVentaEnCamino.Columns["Estado"].DisplayIndex = 3;
            dgvVentaEnCamino.Columns["Fecha"].DisplayIndex = 4;

            dgvVentaEnCamino.Columns[0].HeaderText = "Estado de la venta";
            dgvVentaEnCamino.Columns[1].HeaderText = "Fecha de la venta";
            dgvVentaEnCamino.Columns[2].HeaderText = "ID de la venta";
            dgvVentaEnCamino.Columns[3].HeaderText = "Nombre del cliente";
            dgvVentaEnCamino.Columns[4].HeaderText = "Tipo de venta";
        }
    }
}
