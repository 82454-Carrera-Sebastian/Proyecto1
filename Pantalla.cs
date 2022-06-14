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
                labelRT.Text = "Recurso tecnológico número " + nroRT;

            }
        }

        //TomasFechaYMotivo
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
           //ges = new Gestor();
             ges.BuscarTurnosConfirmadosYPendientesDeConfirmacion(labelRT.Text, maskedTextBoxFecha.Text);
        }

        //public void MostrarReservasDeTurnos(DataTable tablaTurnos)
        //{
        //    string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
        //    SqlConnection cn = new SqlConnection(cadenaConex);
        //    try
        //    {
        //        foreach (DataRow row in tablaTurnos.Rows)
        //        {
        //            SqlCommand cmd = new SqlCommand();

        //            string consulta = "SELECT T.fechaHoraInicio, P.apellido, P.nombre, P.correoInst FROM Turno T JOIN PersonalCientifico P ON T.idPersonal = P.legajo WHERE T.id LIKE '" + row["id"].ToString() + "'";

        //            cmd.Parameters.Clear();

        //            cmd.CommandType = CommandType.Text;
        //            cmd.CommandText = consulta;

        //            cn.Open();
        //            cmd.Connection = cn;



        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        cn.Close();
        //    }

        //}
    }
}
