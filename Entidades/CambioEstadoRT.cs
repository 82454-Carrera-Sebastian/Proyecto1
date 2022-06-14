using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Entidades
{
    public class CambioEstadoRT
    {
        private DateTime FechaHoraDesde;
        private DateTime FechaHoraHasta;


        public CambioEstadoRT(DateTime fechaHoraDesde, DateTime fechaHoraHasta)
        {
            FechaHoraDesde = fechaHoraDesde;
            FechaHoraHasta = fechaHoraHasta;
        }

        public CambioEstadoRT()
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

        //Metodo para obtener el estado actual del RT
        public string EsActual()
        {
            string actual = "";
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT id FROM CambioEstadoRT WHERE fechaHoraHasta IS NULL";

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

        public void CambiarEstado(string actual)
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "UPDATE CambioEstadoRT SET fechaHoraHasta = @fecha WHERE id LIKE '" + actual + "'";

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

        //Metodo llamado por el RT para cambiar su estado a Mantenimiento
        public void CrearEstado(string nroRT)
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO CambioEstadoRT VALUES " + "(CONVERT(DATETIME,@fechaInicio,103),NULL,@id,@nombre,@ambito)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fechaInicio", DateTime.Now.ToString());
                cmd.Parameters.AddWithValue("@id", nroRT);
                cmd.Parameters.AddWithValue("@nombre", "Mantenimiento");
                cmd.Parameters.AddWithValue("@ambito", "RecursoTecnologico");
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
