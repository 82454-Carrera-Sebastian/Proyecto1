using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Entidades
{
    class Sesión
    {
        private DateTime FechaHoraDesde;
        private DateTime FechaHoraHasta;

        public Sesión(DateTime comienzo)
        {
            FechaDeHoraDesde = comienzo;
        }

        public Sesión()
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
