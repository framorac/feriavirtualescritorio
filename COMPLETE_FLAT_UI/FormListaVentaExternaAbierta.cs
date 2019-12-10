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
    public partial class FormListaVentaExternaAbierta : Form
    {
        ServicioAcciones.ServiceAccionesClient servicioAcciones = new ServicioAcciones.ServiceAccionesClient();
        ServiceVentas.ServiceVentasClient servicioVentas = new ServiceVentas.ServiceVentasClient();
        public FormListaVentaExternaAbierta()
        {
            InitializeComponent();
        }

        private void FormListaVentaAbierta_Load(object sender, EventArgs e)
        {
            dgvVentaExternaAbierta.DataSource = servicioVentas.GetVentaCompletaFiltradoAbierto(6, 2).ToList();

            dgvVentaExternaAbierta.Columns["Id"].DisplayIndex = 0;

            dgvVentaExternaAbierta.Columns["NombreApellido"].DisplayIndex = 1;
            dgvVentaExternaAbierta.Columns["Tipo"].DisplayIndex = 2;
            dgvVentaExternaAbierta.Columns["Estado"].DisplayIndex = 3;
            dgvVentaExternaAbierta.Columns["Fecha"].DisplayIndex = 4;


            dgvVentaExternaAbierta.Columns[0].HeaderText = "Estado de la venta";
            dgvVentaExternaAbierta.Columns[1].HeaderText = "Fecha de la venta";
            dgvVentaExternaAbierta.Columns[2].HeaderText = "ID de la venta";
            dgvVentaExternaAbierta.Columns[3].HeaderText = "Nombre del cliente";
            dgvVentaExternaAbierta.Columns[4].HeaderText = "Tipo de venta";

            dgvVentaInternaAbierta.DataSource = servicioVentas.GetVentaCompletaFiltradoAbierto(6, 1).ToList();

            dgvVentaInternaAbierta.Columns["Id"].DisplayIndex = 0;

            dgvVentaInternaAbierta.Columns["NombreApellido"].DisplayIndex = 1;
            dgvVentaInternaAbierta.Columns["Tipo"].DisplayIndex = 2;
            dgvVentaInternaAbierta.Columns["Estado"].DisplayIndex = 3;
            dgvVentaInternaAbierta.Columns["Fecha"].DisplayIndex = 4;


            dgvVentaInternaAbierta.Columns[0].HeaderText = "Estado de la venta";
            dgvVentaInternaAbierta.Columns[1].HeaderText = "Fecha de la venta";
            dgvVentaInternaAbierta.Columns[2].HeaderText = "ID de la venta";
            dgvVentaInternaAbierta.Columns[3].HeaderText = "Nombre del cliente";
            dgvVentaInternaAbierta.Columns[4].HeaderText = "Tipo de venta";
        }

     

        private void BtnCerrarProceso_Click_1(object sender, EventArgs e)
        {
            servicioAcciones.AdjudicarProductor(Convert.ToInt32(dgvVentaExternaAbierta.CurrentRow.Cells[2].Value.ToString()));
        }

        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            dgvVentaExternaAbierta.DataSource = servicioVentas.GetVentaCompletaFiltradoAbierto(6, 2).ToList();

            dgvVentaExternaAbierta.Columns["Id"].DisplayIndex = 0;

            dgvVentaExternaAbierta.Columns["NombreApellido"].DisplayIndex = 1;
            dgvVentaExternaAbierta.Columns["Tipo"].DisplayIndex = 2;
            dgvVentaExternaAbierta.Columns["Estado"].DisplayIndex = 3;
            dgvVentaExternaAbierta.Columns["Fecha"].DisplayIndex = 4;


            dgvVentaExternaAbierta.Columns[0].HeaderText = "Estado de la venta";
            dgvVentaExternaAbierta.Columns[1].HeaderText = "Fecha de la venta";
            dgvVentaExternaAbierta.Columns[2].HeaderText = "ID de la venta";
            dgvVentaExternaAbierta.Columns[3].HeaderText = "Nombre del cliente";
            dgvVentaExternaAbierta.Columns[4].HeaderText = "Tipo de venta";
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
