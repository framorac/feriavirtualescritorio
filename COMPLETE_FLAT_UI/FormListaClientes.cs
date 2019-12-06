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
    public partial class FormListaClientes : Form
    {
        ServiciosUsuarios.UsuariosClient serviciosUsuarios = new ServiciosUsuarios.UsuariosClient();
        public FormListaClientes()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormListaClientes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = serviciosUsuarios.GetUsuarios().ToList();
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns["id"].DisplayIndex = 0;
            dataGridView1.Columns["Username"].DisplayIndex = 1;
            dataGridView1.Columns["Email"].DisplayIndex = 2;
            dataGridView1.Columns["Nombre"].DisplayIndex = 3;
            dataGridView1.Columns["Apellido"].DisplayIndex = 4;
            dataGridView1.Columns["Password"].DisplayIndex = 5;
            dataGridView1.Columns["Perfil"].DisplayIndex = 6;
            dataGridView1.Columns["FechaCreacion"].DisplayIndex = 7;

            dataGridView1.Columns[7].HeaderText = "ID";
            dataGridView1.Columns[6].HeaderText = "Usuario";
            dataGridView1.Columns[3].HeaderText = "Nombre";
            dataGridView1.Columns[0].HeaderText = "Apellido";
            dataGridView1.Columns[1].HeaderText = "Correo";
            dataGridView1.Columns[4].HeaderText = "Contraseña";
            dataGridView1.Columns[5].HeaderText = "Perfil";
            dataGridView1.Columns[2].HeaderText = "Fecha de creación";
        }
        

        private void BtnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormEditCliente frm = new FormEditCliente();

            if (dataGridView1.SelectedRows.Count > 0)
            {
                frm.txtID.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                frm.txtUsuario.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                frm.txtCorreo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.txtNombre.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                frm.txtApellido.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.txtContraseña.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                frm.txtTipoUsuario.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                frm.txtFechaCreacion.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

                frm.Show();

            }
            else
            {
                MessageBox.Show("seleccione una fila por favor");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormMantCliente frm = new FormMantCliente();
            frm.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FormElimCliente frm = new FormElimCliente();
            

            frm.txtID.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            int ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[7].Value);
            frm.ShowDialog();
            serviciosUsuarios.DeleteUsuario(ID);
        }

        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = serviciosUsuarios.GetUsuarios().ToList();
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns["id"].DisplayIndex = 0;
            dataGridView1.Columns["Username"].DisplayIndex = 1;
            dataGridView1.Columns["Email"].DisplayIndex = 2;
            dataGridView1.Columns["Nombre"].DisplayIndex = 3;
            dataGridView1.Columns["Apellido"].DisplayIndex = 4;
            dataGridView1.Columns["Password"].DisplayIndex = 5;
            dataGridView1.Columns["Perfil"].DisplayIndex = 6;
            dataGridView1.Columns["FechaCreacion"].DisplayIndex = 7;

            dataGridView1.Columns[7].HeaderText = "ID";
            dataGridView1.Columns[6].HeaderText = "Usuario";
            dataGridView1.Columns[3].HeaderText = "Nombre";
            dataGridView1.Columns[0].HeaderText = "Apellido";
            dataGridView1.Columns[1].HeaderText = "Correo";
            dataGridView1.Columns[4].HeaderText = "Contraseña";
            dataGridView1.Columns[5].HeaderText = "Perfil";
            dataGridView1.Columns[2].HeaderText = "Fecha de creación";
        }
    }
}
