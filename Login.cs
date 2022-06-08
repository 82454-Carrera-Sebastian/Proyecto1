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

namespace Proyecto1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario(txtUsuario.Text, txtPassword.Text);

            string usuCorrecto = "f";
            string passCorrecto = "1";

            if (txtUsuario.Text.Equals(usuCorrecto) && txtPassword.Text.Equals(passCorrecto))
            {
                //nombre de user y pass correctos
                Pantalla ventana = new Pantalla(usu);
                ventana.Show();
                this.Hide();
            }
            else
            {
                //Nombre de user o pass incorrecto
                MessageBox.Show("Ingrese valores correctos...");
            }
        }
    }
}
