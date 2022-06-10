using Proyecto1.Entidades;
using System;
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
    public partial class Pantalla : Form
    {
        public Pantalla(Usuario usu)
        {
            InitializeComponent();
        }

        private void Pantalla_Load(object sender, EventArgs e)
        {


        }

        //Metodo llamado por el gestor para cargar la grilla de RT y mostrarla
        public void MostrarRTPorTipoDeRecurso(DataTable tablaRT)
        {
            //Colocar nombre de la grilla
            //nombreGrilla.DataSource = tablaRT;
        }

        private void Pantalla_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //proximo metodo: utilizar el vento cellclick para tomar la seleccion del usuario
    }
}
