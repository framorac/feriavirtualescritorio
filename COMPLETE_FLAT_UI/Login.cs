﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMPLETE_FLAT_UI;

namespace SignUpDemo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            COMPLETE_FLAT_UI.ServiciosUsuarios.UsuariosClient serviciosUsuarios = new COMPLETE_FLAT_UI.ServiciosUsuarios.UsuariosClient();

            try
            {
                var resultado = serviciosUsuarios.Login(txtUsuario.Text, txtContrasena.Text);

              

                if (txtUsuario.Text.Equals("") || txtContrasena.Text.Equals(""))
                {
                    if (txtUsuario.Equals(""))
                    {
                        MessageBox.Show("Por favor, ingrese su usuario");
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese su contraseña");
                    }
                    
                }
                else
                {
                    if (resultado.ToLower().Equals("true"))
                    {
                        FormMenuPrincipal frm = new FormMenuPrincipal();
                        frm.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña no coinciden.");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido conectar con el servidor, por favor, vuelva a intentarlo más tarde." + ex);
            }
        }
    }
}
