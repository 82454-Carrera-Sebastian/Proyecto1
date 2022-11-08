using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Entidades
{
    internal class InterfazMail : IObservadorMantenimientoCorrectivo
    {
        
        public void EnviarNotificacion(string fecha, string contacto, string id)
        {
            EnviarEmail(fecha, contacto, id);
        }
        public void EnviarEmail(string fecha ,string correoDestino, string id) 
        {
            try
            {
                MailMessage correo = new MailMessage();
                correo.From = new MailAddress("mileabrilmusie@hotmail.com", "Sistema", System.Text.Encoding.UTF8);//Correo de salida
                correo.To.Add(correoDestino); //Correo destino?
                correo.Subject = "Cancelacion de turno"; //Asunto
                correo.Body = "Estimado responsable cientifico, le informamos que su turno N° identificatorio:  " + id + " de la fecha: " + fecha + " ha sido cancelado por mantenimiento de RT "; //Mensaje del correo
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

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
