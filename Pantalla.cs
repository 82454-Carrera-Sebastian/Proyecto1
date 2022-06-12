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
        private Gestor ges;
        private Usuario usu;
        public Pantalla(Usuario usu)
        {
            InitializeComponent();
            labelActual.Text = usu.NombreUsuario;
        }

        private void Pantalla_Load(object sender, EventArgs e)
        {


        }

        //Metodo llamado por el gestor para cargar la grilla de RT y mostrarla
        public void MostrarRTPorTipoDeRecurso(DataTable tablaRT)
        {
            if (tablaRT.Rows.Count > 0)
            {
                MessageBox.Show("Recursos encontrados con exito");
                dataGridViewRT.DataSource = tablaRT;
            }
            else
            {
                MessageBox.Show("No se encontro ningun recurso");
            }

        }


        private void Pantalla_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //TomarSeleccionRT y PedirFinFechaMotivo
        //private void dataGridViewDatosRT_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    int indice = e.RowIndex;
        //    if (indice > -1)
        //    {
        //        DataGridViewRow filaSeleccionada = dataGridViewDatosRT.Rows[indice];
        //        string nroRT = filaSeleccionada.Cells["numRecurso"].Value.ToString();
        //        MessageBox.Show("Indique Fecha y motivo del mantenimiento");
        //        lblfecha.Visible = true;
        //        lblMotivo.Visible = true;
        //        maskedTextBoxFecha.Visible = true;
        //        richTextBoxMotivo.Visible = true;
        //        labelRT.Visible = true;
        //        buttonBuscar.Visible = true;
        //        labelRT.Text = nroRT;

        //    }
        //}

        //TomasFechaYMotivo
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            //oGestor.BuscarTurnosConfirmadosYPendientesDeConfirmacion();
        }

        //PRIMER METODO EJECUTADO btn que llama caso de uso
        private void btnRegistrarIng_Click(object sender, EventArgs e)
        {
            ges = new Gestor();
            
            ges.ObtenerRecursosTecnologicosDisponibles(labelActual.Text);
        }
    }
}
