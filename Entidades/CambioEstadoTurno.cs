using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Entidades
{
    public class CambioEstadoTurno
    {
        private DateTime FechaHoraDesde;
        private DateTime FechaHoraHasta;


        public CambioEstadoTurno(DateTime fechaHoraDesde, DateTime fechaHoraHasta)
        {
            FechaHoraDesde = fechaHoraDesde;
            FechaHoraHasta = fechaHoraHasta;
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
    }
}
