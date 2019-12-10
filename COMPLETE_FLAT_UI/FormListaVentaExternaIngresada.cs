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
    public partial class FormListaVentaExternaIngresada : Form
    {
        ServiceVentas.ServiceVentasClient servicioVentas = new ServiceVentas.ServiceVentasClient();
        
        public FormListaVentaExternaIngresada()
        {
            InitializeComponent();
        }

        private void FormListaVentaExterna_Load(object sender, EventArgs e)
        {
            dgvSolicitudVentaExterna.DataSource = servicioVentas.GetVentaCompletaFiltradoIngresada(6,2);
            dgvSolicitudVentaExterna.AutoGenerateColumns = false;

            dgvSolicitudVentaExterna.Columns["Id"].DisplayIndex = 0;
            dgvSolicitudVentaExterna.Columns["NombreApellido"].DisplayIndex = 1;
            dgvSolicitudVentaExterna.Columns["Tipo"].DisplayIndex = 2;
            dgvSolicitudVentaExterna.Columns["Estado"].DisplayIndex = 3;
            dgvSolicitudVentaExterna.Columns["Fecha"].DisplayIndex = 4;


            dgvSolicitudVentaExterna.Columns[0].HeaderText = "Estado de la venta";
            dgvSolicitudVentaExterna.Columns[1].HeaderText = "Fecha de la venta";
            dgvSolicitudVentaExterna.Columns[2].HeaderText = "ID de la venta";
            dgvSolicitudVentaExterna.Columns[3].HeaderText = "Nombre del cliente";
            dgvSolicitudVentaExterna.Columns[4].HeaderText = "Tipo de venta";

            dgvVentaInterna.DataSource = servicioVentas.GetVentaCompletaFiltradoIngresada(6, 1);
            dgvVentaInterna.AutoGenerateColumns = false;

            dgvVentaInterna.Columns["Id"].DisplayIndex = 0;
            dgvVentaInterna.Columns["NombreApellido"].DisplayIndex = 1;
            dgvVentaInterna.Columns["Tipo"].DisplayIndex = 2;
            dgvVentaInterna.Columns["Estado"].DisplayIndex = 3;
            dgvVentaInterna.Columns["Fecha"].DisplayIndex = 4;


            dgvVentaInterna.Columns[0].HeaderText = "Estado de la venta";
            dgvVentaInterna.Columns[1].HeaderText = "Fecha de la venta";
            dgvVentaInterna.Columns[2].HeaderText = "ID de la venta";
            dgvVentaInterna.Columns[3].HeaderText = "Nombre del cliente";
            dgvVentaInterna.Columns[4].HeaderText = "Tipo de venta";
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPublicar_Click(object sender, EventArgs e)
        {
            var mensaje = servicioVentas.UpdateVenta(1, Convert.ToInt32(dgvSolicitudVentaExterna.CurrentRow.Cells[2].Value.ToString()),'0');

            MessageBox.Show(mensaje);
        }

        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            dgvSolicitudVentaExterna.DataSource = servicioVentas.GetVentaCompletaFiltradoIngresada(6, 2);
            dgvSolicitudVentaExterna.AutoGenerateColumns = false;

            dgvSolicitudVentaExterna.Columns["Id"].DisplayIndex = 0;
            dgvSolicitudVentaExterna.Columns["NombreApellido"].DisplayIndex = 1;
            dgvSolicitudVentaExterna.Columns["Tipo"].DisplayIndex = 2;
            dgvSolicitudVentaExterna.Columns["Estado"].DisplayIndex = 3;
            dgvSolicitudVentaExterna.Columns["Fecha"].DisplayIndex = 4;


            dgvSolicitudVentaExterna.Columns[0].HeaderText = "Estado de la venta";
            dgvSolicitudVentaExterna.Columns[1].HeaderText = "Fecha de la venta";
            dgvSolicitudVentaExterna.Columns[2].HeaderText = "ID de la venta";
            dgvSolicitudVentaExterna.Columns[3].HeaderText = "Nombre del cliente";
            dgvSolicitudVentaExterna.Columns[4].HeaderText = "Tipo de venta";
        }

        private void BtnPublicarVentaInterna_Click(object sender, EventArgs e)
        {
            var mensaje = servicioVentas.UpdateVenta(1, Convert.ToInt32(dgvVentaInterna.CurrentRow.Cells[2].Value.ToString()), '0');

            MessageBox.Show(mensaje);
        }

        private void BtnRefrescarVentaInterna_Click(object sender, EventArgs e)
        {
            dgvVentaInterna.DataSource = servicioVentas.GetVentaCompletaFiltradoIngresada(6, 1);
            dgvVentaInterna.AutoGenerateColumns = false;

            dgvVentaInterna.Columns["Id"].DisplayIndex = 0;
            dgvVentaInterna.Columns["NombreApellido"].DisplayIndex = 1;
            dgvVentaInterna.Columns["Tipo"].DisplayIndex = 2;
            dgvVentaInterna.Columns["Estado"].DisplayIndex = 3;
            dgvVentaInterna.Columns["Fecha"].DisplayIndex = 4;


            dgvVentaInterna.Columns[0].HeaderText = "Estado de la venta";
            dgvVentaInterna.Columns[1].HeaderText = "Fecha de la venta";
            dgvVentaInterna.Columns[2].HeaderText = "ID de la venta";
            dgvVentaInterna.Columns[3].HeaderText = "Nombre del cliente";
            dgvVentaInterna.Columns[4].HeaderText = "Tipo de venta";
        }
    }
}
