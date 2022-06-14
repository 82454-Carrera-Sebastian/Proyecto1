using System;
using System.Collections.Generic;
using System.Data;
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

    }
}
