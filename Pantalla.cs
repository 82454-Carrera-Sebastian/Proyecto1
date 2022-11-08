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
            dataGridViewRT.Visible = true;
            groupBox1.Visible = true;
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
                labelseleccion.Visible = true;
                labelseleccion.Text = nroRT;
                labelbuscar.Visible = true;
                dataGridViewRT.Visible = true;


            }
        }

        //TomarFechaYMotivo, una vez ingresados la fecha y motivo del mantenimiento se llama al metodo BuscarTurnos para que
        //obtenga todos los turnos que habra que cancelar
        //Ademas como este lenguaje es incomprensible este metodo funciona tambien como MostrarReservasDeTurnos
        //Porque despues de horas de intentos no se podia cargar la grilla
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            labelConfirmar.Visible = true;
            buttonConfirmar.Visible = true;
            ges = new Gestor();
            dataGridView1.DataSource = ges.BuscarTurnosConfirmadosYPendientesDeConfirmacion(labelseleccion.Text, maskedTextBoxFecha.Text, ges);
        }



        //Confirma matenimiento, llama al gestor para que se encargue
        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            ges.CrearMantenimiento(labelseleccion.Text, maskedTextBoxFecha.Text, richTextBoxMotivo.Text, obtenerFechas(), obtenerContactos(), obtenerIDs());
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string id = Convert.ToString(row.Cells["id"].Value);
                //string Correo = Convert.ToString(row.Cells["Correo"].Value);
                ges.CancelarTurnos(id);
                //ges.EnviarEmail(Correo, id);
            }
            limpiarPantalla();
            MessageBox.Show("Mantenimiento cargado con exito");
        }


        private string[] obtenerContactos()
        {
            List<string> contactos = new List<string>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                //string id = Convert.ToString(row.Cells["id"].Value);
                string Correo = Convert.ToString(row.Cells["Correo"].Value);
                contactos.Add(Correo);
            }
            return contactos.ToArray();
        }

        public string[] obtenerIDs()
        {
            List<string> listaIDTurnos = new List<string>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string id = Convert.ToString(row.Cells["id"].Value);
                listaIDTurnos.Add(id);
            }
            return listaIDTurnos.ToArray();
        }

        public string[] obtenerFechas()
        {
            List<string> listaFechas = new List<string>();
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                string fecha = Convert.ToString(row.Cells["fechaHoraInicio"].Value);
                listaFechas.Add(fecha);
            }
            return listaFechas.ToArray();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            limpiarPantalla();
        }

        public void limpiarPantalla()
        {
            labelRT.Visible = false;
            labelseleccion.Visible = false;
            lblfecha.Visible = false;
            maskedTextBoxFecha.Visible = false;
            lblMotivo.Visible = false;
            richTextBoxMotivo.Visible = false;
            labelbuscar.Visible = false;
            buttonBuscar.Visible = false;
            labelConfirmar.Visible = false;
            buttonConfirmar.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            dataGridViewRT.Visible = false;
        }
    }
}
