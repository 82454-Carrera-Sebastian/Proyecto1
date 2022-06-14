﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        //el gestor debe llamar a la clase asignacionResponsableTecnologico para que esta obtenga los datos de
        //los RT que ese cientifico tiene disponible, para ello utilizara la "tabla2" creada en el metodo anterior
        public DataTable ObtenerRecursosTecnologicosDisponibles(string nombre)
        {

            DataTable tablaRT = art.MostrarRT(ObtenerRTDisponiblesDeRRT(ObtenerUsuarioLogueado(nombre)), RT);
            if (tablaRT.Rows.Count > 0)
            {
                MessageBox.Show("Recursos encontrados con exito");
                pan.dataGridViewRT.Visible = true; 
            }
            else
            {
                MessageBox.Show("No se encontro ningun recurso");
            }
            //pan.MostrarRTPorTipoDeRecurso(tablaRT);
            return tablaRT;
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
            tabla2.Columns.Add("nroRT", typeof(string));
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
                    tabla2 = art.EsUsuarioVigente(row["nroRT"].ToString(), tabla2);
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


        //Metodo llamado por la pantalla para obtener los turnos que haya que cancelar, llama a metodo de recurso tecnologico
        //El metodo obtener turnos obtendra los turnos que se cancelaran al aceptar el mantenimiento
        public DataTable BuscarTurnosConfirmadosYPendientesDeConfirmacion(string nrort, string fechaFin, Gestor ges)
        {
            DataTable tablaTurnos = RT.ObtenerTurnos(nrort, fechaFin);

            //ObtenerDatosReserva(tablaTurnos);

            //pan.MostrarReservasDeTurnos(tablaTurnos, ges);
            DataTable TablaDatosTurnos = ObtenerDatosReserva(tablaTurnos);
            return TablaDatosTurnos;
        }

        //metodo llamado por el metodo BuscarTurnosConfirmadosYPendientesDeConfirmacion del mismo gestor para obtener los datos de los 
        //turnos a cancelar.
        //El metodo creara una tabla que sera llenada a traves de un ciclo en cada turno con los datos a mostrar en grilla
        //primero llamara al metodo ObtenerDatosReserva del RT
        public DataTable ObtenerDatosReserva(DataTable tablaTurnos)
        {
            DataTable TablaDatosTurnos = new DataTable("TablaDatosTurnos");
            TablaDatosTurnos.Columns.Add("fechaHoraInicio");
            TablaDatosTurnos.Columns.Add("Nombre");
            TablaDatosTurnos.Columns.Add("Apellido");
            TablaDatosTurnos.Columns.Add("Correo");
            TablaDatosTurnos.Columns.Add("id");
            foreach (DataRow row in tablaTurnos.Rows)
            {
                TablaDatosTurnos = RT.ObtenerDatosReserva(row["id"].ToString(), TablaDatosTurnos);

            }
            //DataView dv = TablaDatosTurnos.DefaultView;
            //dv.Sort = "Nombre";
            //DataTable TablaDatosTurnosAgrupada = dv.ToTable();
            //return TablaDatosTurnosAgrupada;
            return TablaDatosTurnos;

        }

        public void CrearMantenimiento(string nroRT, string fechaFIN, string motivo)
        {
            RT = new RecursoTecnológico();
            RT.CrearMantenimiento(nroRT, fechaFIN, motivo);
            BuscarEstadoActual(nroRT, RT);
        }

        //Metodo llamado por el gestor que actualizara los estados, llamara al metodo de RT
        public void BuscarEstadoActual(string nroRT, RecursoTecnológico RT)
        {
            RT.ObtenerEstadoActual(nroRT);
        }

        //Metodo llamado por la pantalla para cancelar los turnos mostrados en grilla
        public void CancelarTurnos(string id)
        {
            RT = new RecursoTecnológico();
            RT.CancelarTurno(id);
        }

        public void EnviarEmail(string correoDestino, string id)
        {
            try
            {
                MailMessage correo = new MailMessage();
                correo.From = new MailAddress("mileabrilmusie@hotmail.com", "Sistema", System.Text.Encoding.UTF8);//Correo de salida
                correo.To.Add(correoDestino); //Correo destino?
                correo.Subject = "Cancelacion de turno"; //Asunto
                correo.Body = "Estimado responsable cientifico, le informamos que su turno " +id+ " ha sido cancelado por mantenimiento de RT "; //Mensaje del correo
                correo.IsBodyHtml = true;
                correo.Priority = MailPriority.Normal;
                SmtpClient smtp = new SmtpClient();
                smtp.UseDefaultCredentials = false;
                smtp.Host = "smtp.office365.com"; //Host del servidor de correo
                smtp.Port = 587; //Puerto de salida
                smtp.Credentials = new System.Net.NetworkCredential("mileabrilmusie@hotmail.com", "1dao43272769");//Cuenta de correo
                ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
                smtp.EnableSsl = true;//True si el servidor de correo permite ssl
                smtp.Send(correo);
                MessageBox.Show("Mail generado y enviado con éxito");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
