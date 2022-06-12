using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proyecto1.Entidades
{
    public class Gestor
    {
        private string DatosReservasTurnos; //Datos de reservas de los turnos confirmados y pendientes de confirmación
        private string CorreoRRT;
        private string EstadoRT;
        private DateTime FechaActual;
        private string RTDisponible; // RT disponible de RRT
        private string TurnosConfYPend; //
        private string UsuarioLogueado;
        private Usuario usu;
        private Sesión ses;
        private AsignacionResTecnicoRT art;
        private RecursoTecnológico RT;
        private Pantalla pan;

        public Gestor()
        {
            usu = new Usuario();
            ses = new Sesión();
            art = new AsignacionResTecnicoRT();
            RT = new RecursoTecnológico();
            pan = new Pantalla(usu);
        }

        public string DatosDeReservasDeTurnos
        {
            get => DatosReservasTurnos;
            set => DatosReservasTurnos = value;
        }

        public string CorreoDeRRT
        {
            get => CorreoRRT;
            set => CorreoRRT = value;
        }

        public string EstadoDeRT
        {
            get => EstadoRT;
            set => EstadoRT = value;
        }

        public DateTime LaFechaActual
        {
            get => FechaActual;
            set => FechaActual = value;
        }

        public string LosRTDisponibles
        {
            get => RTDisponible;
            set => RTDisponible = value;
        }

        public string LosTurnosConfYPend
        {
            get => TurnosConfYPend;
            set => TurnosConfYPend = value;
        }

        public string ElUsuarioLogueado
        {
            get => UsuarioLogueado;
            set => UsuarioLogueado = value;
        }

        //Obtener legajo de usuario a traves de la clase usuario
        //se pasa el nombre por parametro y se envia el mismo la clase sesion
        public string ObtenerUsuarioLogueado(string nombre)
        {
            string nombreUsuario = usu.ObtenerCientifico(nombre);//ses.MostrarCientificoLogueado(nombre);
            return nombreUsuario;
        }

        //Busca si el cientifico actual es responsable de algun RT
        //el gestor obtendra una lista con todos los recursos tecnologicos de los que el cientifico es o fue responsable
        //esa lista sera enviada a la clase asignacion responsable tecnico que se encargara de ver si el cientifico es
        //responsable actual de ese RT, creando otra lista con todos los RT de los que el cientifico es responsable actual
        public DataTable ObtenerRTDisponiblesDeRRT(string nombre)
        {
            DataTable tabla2 = new DataTable();
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT nroRT FROM AsignacionRespTecnRT WHERE legRT LIKE '" + nombre + "'";

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(tabla);

                foreach (DataRow row in tabla.Rows)
                {
                    if (art.EsUsuarioVigente(row["nroRT"].ToString()))
                    {
                        SqlDataAdapter daa = new SqlDataAdapter(cmd);
                        daa.Fill(tabla2);
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
            return tabla2;
       }

        //el gestor debe llamar a la clase asignacionResponsableTecnologico para que esta obtenga los datos de
        //los RT que ese cientifico tiene disponible, para ello utilizara la "tabla2" creada en el metodo anterior

        public void ObtenerRecursosTecnologicosDisponibles(string nombre)
        {
                        
            DataTable tablaRT = art.MostrarRT(ObtenerRTDisponiblesDeRRT(ObtenerUsuarioLogueado(nombre)), RT);

            pan.MostrarRTPorTipoDeRecurso(tablaRT);
        }

        //Metodo llamado por la pantalla para 
        public void BuscarTurnosConfirmadosYPendientesDeConfirmacion(string nrort)
        {

        }

    }
}
