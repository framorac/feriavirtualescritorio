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
    public partial class FormListaVentaExternaRecepcionado : Form
    {
        ServiceVentas.ServiceVentasClient servicioVentas = new ServiceVentas.ServiceVentasClient();
        ServicioAcciones.ServiceAccionesClient serviceAcciones = new ServicioAcciones.ServiceAccionesClient();
        public FormListaVentaExternaRecepcionado()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCerrarProceso_Click(object sender, EventArgs e)
        {
            serviceAcciones.ComenzarProcesoLocal(Convert.ToInt32(dgvVentasRecepcionadas.CurrentRow.Cells[2].Value.ToString()));
        }

        private void FormListaVentaExternaRecepcionado_Load(object sender, EventArgs e)
        {
            dgvVentasRecepcionadas.DataSource = servicioVentas.GetVentaCompletaFiltradoRecepcionado(6,2).ToList();

            dgvVentasRecepcionadas.Columns["Id"].DisplayIndex = 0;
            dgvVentasRecepcionadas.Columns["NombreApellido"].DisplayIndex = 1;
            dgvVentasRecepcionadas.Columns["Tipo"].DisplayIndex = 2;
            dgvVentasRecepcionadas.Columns["Estado"].DisplayIndex = 3;
            dgvVentasRecepcionadas.Columns["Fecha"].DisplayIndex = 4;

            dgvVentasRecepcionadas.Columns[0].HeaderText = "Estado de la venta";
            dgvVentasRecepcionadas.Columns[1].HeaderText = "Fecha de la venta";
            dgvVentasRecepcionadas.Columns[2].HeaderText = "ID de la venta";
            dgvVentasRecepcionadas.Columns[3].HeaderText = "Nombre del cliente";
            dgvVentasRecepcionadas.Columns[4].HeaderText = "Tipo de venta";
        }

        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            dgvVentasRecepcionadas.DataSource = servicioVentas.GetVentaCompletaFiltradoRecepcionado(6, 2).ToList();

            dgvVentasRecepcionadas.Columns["Id"].DisplayIndex = 0;
            dgvVentasRecepcionadas.Columns["NombreApellido"].DisplayIndex = 1;
            dgvVentasRecepcionadas.Columns["Tipo"].DisplayIndex = 2;
            dgvVentasRecepcionadas.Columns["Estado"].DisplayIndex = 3;
            dgvVentasRecepcionadas.Columns["Fecha"].DisplayIndex = 4;

            dgvVentasRecepcionadas.Columns[0].HeaderText = "Estado de la venta";
            dgvVentasRecepcionadas.Columns[1].HeaderText = "Fecha de la venta";
            dgvVentasRecepcionadas.Columns[2].HeaderText = "ID de la venta";
            dgvVentasRecepcionadas.Columns[3].HeaderText = "Nombre del cliente";
            dgvVentasRecepcionadas.Columns[4].HeaderText = "Tipo de venta";
        }
    }
}
