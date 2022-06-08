using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Entidades
{
    public class AsignacionCientífico
    {
        private DateTime FechaDesde;
        private DateTime FechaHasta;


        public AsignacionCientífico(DateTime fechaDesde, DateTime fechaHasta)
        {
            FechaDesde = fechaDesde;
            FechaHasta = fechaHasta;
        }

        public DateTime FechaDeHoraDesde
        {
            get => FechaDesde;
            set => FechaDesde = value;
        }

        public DateTime FechaDeHoraHasta
        {
            get => FechaHasta;
            set => FechaHasta = value;
        }

        public AsignacionCientífico()
        {

        }
    }

}
