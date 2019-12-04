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
    public partial class FormListaContratos : Form
    {
        ServicioContratos.ServiceContratosClient servicioContrato = new ServicioContratos.ServiceContratosClient();
        public FormListaContratos()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FormMantContrato frm = new FormMantContrato();
            frm.ShowDialog();
        }

        private void FormListaContratos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = servicioContrato.GetContratos().ToList();
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns["id_contrato"].DisplayIndex = 0;
            dataGridView1.Columns["id_usuario"].DisplayIndex = 1;
            dataGridView1.Columns["fecha_inicio"].DisplayIndex = 2;
            dataGridView1.Columns["fecha_termino"].DisplayIndex = 3;

            dataGridView1.Columns[2].HeaderText = "ID";
            dataGridView1.Columns[3].HeaderText = "ID Usuario";
            dataGridView1.Columns[0].HeaderText = "Fecha Inicio";
            dataGridView1.Columns[1].HeaderText = "Fecha Termino";
        }

        private void BtnEliminarContrato_Click(object sender, EventArgs e)
        {
            FormElimContratos frm = new FormElimContratos();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                frm.txtID.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.Show();
            }
            else
            {
                MessageBox.Show("seleccione una fila por favor");
            }
        }

        private void BtnEditarContrato_Click(object sender, EventArgs e)
        {
            FormEditContrato frm = new FormEditContrato();

            if (dataGridView1.SelectedRows.Count > 0)
            {
                frm.txtUsuario.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.Show();
            }
            else
            {
                MessageBox.Show("seleccione una fila por favor");
            }
        }

        private void BtnAgregarContrato_Click(object sender, EventArgs e)
        {
            FormMantContrato frm = new FormMantContrato();
            frm.Show();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
