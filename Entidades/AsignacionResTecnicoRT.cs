using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Entidades
{
    public class AsignacionResTecnicoRT
    {
        private DateTime FechaHoraDesde;
        private DateTime FechaHoraHasta;

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

        public AsignacionResTecnicoRT(DateTime fechaHoraDesde, DateTime fechaHoraHasta)
        {
            FechaHoraDesde = fechaHoraDesde;
            FechaHoraHasta = fechaHoraHasta;
        }
        public AsignacionResTecnicoRT()
        {

        }

        public bool EsUsuarioVigente(string numRT)
        {
            bool Resultado = false;
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT FechaHasta FROM AsignacionRespTecnRT WHERE numRT LIKE '" + int.Parse(numRT) + "'";

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                SqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader == null && dataReader.Read())
                {
                    Resultado = true;
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
            return Resultado;
        }

        //public void ObtenerRecursosTecnologicosDisponibles(DataTable tabla2)
        //{
        //    foreach (DataRow row in tabla2.Rows)
        //    {
        //        string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
        //        SqlConnection cn = new SqlConnection(cadenaConex);
        //        try
        //        {
        //            SqlCommand cmd = new SqlCommand();

        //            string consulta = "SELECT numRT FROM AsignacionRespTecnRT WHERE legRT LIKE '" + usu.ObtenerLegajo + "'";

        //            cmd.Parameters.Clear();

        //            cmd.CommandType = CommandType.Text;
        //            cmd.CommandText = consulta;

        //            cn.Open();
        //            cmd.Connection = cn;

        //            DataTable tabla = new DataTable();
        //            SqlDataAdapter da = new SqlDataAdapter(cmd);

        //            da.Fill(tabla);



        //        }
        //        catch (Exception ex)
        //        {
        //            throw;
        //        }
        //        finally
        //        {
        //            cn.Close();
        //        }
        //    }
    }
}
