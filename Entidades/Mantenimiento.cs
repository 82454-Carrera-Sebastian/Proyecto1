using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Entidades
{
    public class Mantenimiento
    {
        private DateTime FechaInicio;
        private DateTime FechaFin;
        private DateTime FechaInicioPrev;
        private string MotivoMant;

        public Mantenimiento(DateTime fechaInPrev, string motivo)
        {
            FechaInicioPrev = fechaInPrev;
            MotivoMant = motivo;
        }

        public Mantenimiento()
        {

        }

        public DateTime FechaDeInicio
        {
            get => FechaInicio;
            set => FechaInicio = value;
        }

        public DateTime FechaDeFin
        {
            get => FechaFin;
            set => FechaFin = value;
        }

        public DateTime FechaDeInicioPrev
        {
            get => FechaInicioPrev;
            set => FechaInicioPrev = value;
        }

        public string MotivoMantenimiento
        {
            get => MotivoMant;
            set => MotivoMant = value;
        }
    }
}
