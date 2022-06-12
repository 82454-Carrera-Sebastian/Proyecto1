using System;
using Proyecto1.Entidades;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto1.AccesosADatos;

namespace Proyecto1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("") || txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Campos vacíos..");
            }
            else
            {
                string nombreUsu = txtUsuario.Text;
                string password = txtPassword.Text;
                bool resultado = false;
                try
                {
                    resultado = AD_Usuarios.ValidarUsuario(nombreUsu, password);
                    if (resultado == true)
                    {
                        Usuario usu = new Usuario();//(nombreUsu, password);ç
                        {
                            usu.NombreUsuario = nombreUsu;
                            usu.ClaveUsuario = password;
                        }
                        Pantalla ventana = new Pantalla(usu);
                        ventana.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario inexistente");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al consultar usuario");
                }

            }
        }

        public void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
