using Proyecto1.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        //PRIMER METODO EJECUTADO btn que llama caso de uso
        private void btnRegistrarIng_Click(object sender, EventArgs e)
        {
            //ges = new Gestor();
            //ges.ObtenerRecursosTecnologicosDisponibles(labelActual.Text);
            ges = new Gestor();
            MostrarRTPorTipoDeRecurso(labelActual.Text);
        }

        //Metodo llamado por el gestor para cargar la grilla de RT y mostrarla
        public void MostrarRTPorTipoDeRecurso(string nombre)
        {
            //if (tablaRT.Rows.Count > 0)
            //{
            //    MessageBox.Show("Recursos encontrados con exito");
            //    dataGridViewRT.DataSource = tablaRT;
            //}
            //else
            //{
            //    MessageBox.Show("No se encontro ningun recurso");
            //}
            dataGridViewRT.DataSource = ges.ObtenerRecursosTecnologicosDisponibles(nombre);

        }



        private void Pantalla_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //TomarSeleccionRT y PedirFinFechaMotivo
        private void dataGridViewRT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice > -1)
            {
                DataGridViewRow filaSeleccionada = dataGridViewRT.Rows[indice];
                string nroRT = filaSeleccionada.Cells["Numero"].Value.ToString();
                MessageBox.Show("Indique Fecha y motivo del mantenimiento");
                lblfecha.Visible = true;
                lblMotivo.Visible = true;
                maskedTextBoxFecha.Visible = true;
                richTextBoxMotivo.Visible = true;
                labelRT.Visible = true;
                buttonBuscar.Visible = true;
                labelseleccion.Text = nroRT;

            }
        }

        //TomarFechaYMotivo, una vez ingresados la fecha y motivo del mantenimiento se llama al metodo BuscarTurnos para que
        //obtenga todos los turnos que habra que cancelar
        //ADemas como este lenguaje es incomprensible este metodo funciona tambien como MostrarReservasDeTurnos
        //Porque despues de horas de intentos no se podia cargar la grilla
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
             ges = new Gestor();
             dataGridView1.DataSource = ges.BuscarTurnosConfirmadosYPendientesDeConfirmacion(labelseleccion.Text, maskedTextBoxFecha.Text, ges);
        }

        public void MostrarReservasDeTurnos(DataTable tablaTurnos, Gestor ges)
        {
            //ges = new Gestor();
             
             //dataGridView1.DataSource = ges.ObtenerDatosReserva(tablaTurnos);
        }

        //Confirma matenimiento, llama al gestor para que se encargue
        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
             ges.CrearMantenimiento(labelseleccion.Text, maskedTextBoxFecha.Text, richTextBoxMotivo.Text);
        }
    }
}
