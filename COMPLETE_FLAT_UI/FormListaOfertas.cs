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
    public partial class FormListaOfertas : Form
    {
        ServicioOfertas.ServiceOfertasClient servicioOfertas = new ServicioOfertas.ServiceOfertasClient();
        public FormListaOfertas()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FormMantContrato frm = new FormMantContrato();
            frm.ShowDialog();
        }

        private void FormListaContratos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = servicioOfertas.GetOfertas().ToList();
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns["Id_oferta"].DisplayIndex = 0;
            dataGridView1.Columns["Id_venta"].DisplayIndex = 1;
            dataGridView1.Columns["Username"].DisplayIndex = 2;
            dataGridView1.Columns["Fecha_inicio"].DisplayIndex = 3;

            dataGridView1.Columns[1].HeaderText = "ID Oferta";
            dataGridView1.Columns[2].HeaderText = "ID Venta";
            dataGridView1.Columns[3].HeaderText = "Usuario";
            dataGridView1.Columns[0].HeaderText = "Fecha Inicio";
        }
    }
}
