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
    public partial class FormListaVentaExterna : Form
    {
        public FormListaVentaExterna()
        {
            InitializeComponent();
        }

        private void FormListaVentaExterna_Load(object sender, EventArgs e)
        {

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            FormEditVentaExterna frm = new FormEditVentaExterna();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //frm..Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
               

                frm.ShowDialog();

            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
    }
}
