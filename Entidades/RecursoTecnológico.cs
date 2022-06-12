using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Entidades
{
    public class RecursoTecnológico
    {
        private int NumeroRT;
        private DateTime FechaAlta;
        private int PeriodicidadMantPreventivo;
        private int DuracionMantPreventivo;
        private int FraccionHorarioTurnos;

        public RecursoTecnológico(int numRT, DateTime fechaAlta)
        {
            NumeroRT = numRT;
            FechaAlta = fechaAlta;
        }

        public RecursoTecnológico()
        {

        }

        public int NumRecurso
        {
            get => NumeroRT;
            set => NumeroRT = value;
        }

        public DateTime FechaDeAlta
        {
            get => FechaAlta;
            set => FechaAlta = value;
        }

        public int PeriodicidadDeMantPrev
        {
            get => PeriodicidadMantPreventivo;
            set => PeriodicidadMantPreventivo = value;
        }

        public int DuracionDeMantenimientoPrev
        {
            get => DuracionMantPreventivo;
            set => DuracionMantPreventivo = value;
        }

        public int FraccionHorarioDeTurnos
        {
            get => FraccionHorarioTurnos;
            set => FraccionHorarioTurnos = value;
        }


        //LLamado por la clase AsignacionRestecnico para ver si un RT esta en mantenimiento en ese momento
        //le llegara por parametro un RT y utilizando la tabla mantenimiento verificara si este tiene fechaFin o no, si no la posee
        //no estara activo por lo tanto sus datos no se mostraran
        public bool esActivo(string nroRecurso)
        {
            bool esact = true;
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT fechaFin FROM Mantenimiento WHERE idRecurso LIKE '" + int.Parse(nroRecurso) + "' AND fechaFin IS NULL";

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;


                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader != null && dataReader.Read())
                {
                    if ((dataReader["fechaFin"].ToString()) != null)
                    {
                        esact = false;
                    }

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
            return esact;
        }
    }

    
}
