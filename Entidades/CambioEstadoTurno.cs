using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Entidades
{
    public class CambioEstadoTurno
    {
        private DateTime FechaHoraDesde;
        private DateTime FechaHoraHasta;
        private Estado es;


        public CambioEstadoTurno(DateTime fechaHoraDesde, DateTime fechaHoraHasta)
        {
            FechaHoraDesde = fechaHoraDesde;
            FechaHoraHasta = fechaHoraHasta;
            es = new Estado();
        }
        public CambioEstadoTurno()
        {

        }

        public DateTime FechaDeHoraDesde
        {
            get => FechaHoraDesde;
            set => FechaHoraDesde = value;
        }

        public DateTime FechaDeHoraHasta
        {
            get => FechaHoraHasta;
            set => FechaHoraHasta = value;
        }

        //Metodo para ver si un turno es actual, es decir si esta dentro de la fecha de mantenimiento
        //Es llamado por turno y llamara al metodo es cancelable de estado donde se vera si se encuentra en estado pendiente o confirmado
        //dado que si se encuentra en uno de esos dos significa que es cancelable
        public bool SosActual(string estado, string fechaInicio, string fechaFin)
        {
            bool resultado = false;
            CultureInfo Culture = new CultureInfo("es-ES");
            DateTime fechaFinMantenimiento = Convert.ToDateTime(fechaFin, Culture) ;
            DateTime fechaTurno = Convert.ToDateTime(fechaInicio, Culture);
            TimeSpan tSpan = fechaTurno - fechaFinMantenimiento;
            int dias = tSpan.Days;
            es = new Estado();
            if (dias <= 0 && es.esCancelable(estado))
            {
                resultado = true;
            }
            return resultado;

        }

        internal string EsActualTurno(string id)
        {
            string actual = "";
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT id FROM CambioEstadoTurno WHERE fechaHoraHasta IS NULL AND idTurno LIKE '" + id + "'";

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;


                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader != null && dataReader.Read())
                {
                    actual = dataReader["id"].ToString();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return actual;
        }

        internal void SetFechaFin(string actual)
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "UPDATE CambioEstadoTurno SET fechaHoraHasta = @fecha WHERE id LIKE '" + actual + "'";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fecha", DateTime.Now.ToString());
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;


                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader != null && dataReader.Read())
                {
                    actual = dataReader["id"].ToString();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        internal void CrearEstado(string id)
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO CambioEstadoTurno VALUES (CONVERT(DATETIME,@fechaInicio,103),NULL,@estado,@id)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fechaInicio", DateTime.Now.ToString());
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@estado", "'Cancelado'");
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
