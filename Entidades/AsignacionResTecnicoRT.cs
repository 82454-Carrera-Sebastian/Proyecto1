using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Entidades
{
    class AsignacionResTecnicoRT
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
    }
}
