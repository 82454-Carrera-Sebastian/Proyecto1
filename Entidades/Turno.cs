using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Entidades
{
    public class Turno
    {
        private string DiaSemana;
        private DateTime FechaGeneracion;
        private DateTime FechaHoraInicio;
        private DateTime FechaHoraFin;
        private CambioEstadoTurno cam;

        public Turno(string dia, DateTime generacion, DateTime inicio, DateTime fin)
        {
            DiaSemana = dia;
            FechaGeneracion = generacion;
            FechaHoraInicio = inicio;
            FechaHoraFin = fin;
            cam = new CambioEstadoTurno();
        }

        public Turno()
        {

        }

        public string DiaDeSemana
        {
            get => DiaSemana;
            set => DiaSemana = value;
        }

        public DateTime FechaDeGeneracion
        {
            get => FechaGeneracion;
            set => FechaGeneracion = value;
        }

        public DateTime FechaHoraDeInicio
        {
            get => FechaHoraInicio;
            set => FechaHoraInicio = value;
        }

        public DateTime FechaHoraDeFin
        {
            get => FechaHoraFin;
            set => FechaHoraFin = value;
        }

        //Metodo llamado por RT para conocer estado y fecha inicio de los turnos de cierto rt, 
        //luego este metodo le preguntara al cambioDeEstadoTurno si el turno es actual y
        //el actual le pregunta a estado si es cancelable, es decir si estan pendientes o confirmadas
        public DataTable EsCancelable(string idTurno, DataTable tabla2, string fechaFin)
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT T.id C.estado, T.FechaHoraInicio FROM Turno T JOIN CambioEstadoTurno C ON T.id = C idTurno JOIN Estado E ON C.estado = E.nombre  WHERE T.idTurno LIKE '" + idTurno + "' AND c.fechaHoraHasta IS NULL";

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;


                SqlDataReader dataReader = cmd.ExecuteReader();
                //SqlDataAdapter da = new SqlDataAdapter(cmd);

                //da.Fill(tabla2);

                if (cam.SosActual(dataReader["estado"].ToString(), dataReader["FechaHoraInicio"].ToString(), fechaFin))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla2);
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
            return tabla2;
        }
    }
}
