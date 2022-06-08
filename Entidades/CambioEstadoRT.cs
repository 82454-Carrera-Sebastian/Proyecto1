using System;
using System.Collections.Generic;
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
    }
}
