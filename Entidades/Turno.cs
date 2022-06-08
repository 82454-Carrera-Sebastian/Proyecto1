using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Entidades
{
    public class Turno
    {
        private string DiaSemana;
        private DateTime FechaGeneracion;
        private DateTime FechaHoraInicio;
        private DateTime FechaHoraFin;

        public Turno(string dia, DateTime generacion, DateTime inicio, DateTime fin)
        {
            DiaSemana = dia;
            FechaGeneracion = generacion;
            FechaHoraInicio = inicio;
            FechaHoraFin = fin;
        }

        public Turno()
        {

        }

        public string DiaDeSemana
        {
            get => DiaSemana;
            set => DiaSemana = value;
        }

        public DateTime FechaDeGeneracion
        {
            get => FechaGeneracion;
            set => FechaGeneracion = value;
        }

        public DateTime FechaHoraDeInicio
        {
            get => FechaHoraInicio;
            set => FechaHoraInicio = value;
        }

        public DateTime FechaHoraDeFin
        {
            get => FechaHoraFin;
            set => FechaHoraFin = value;
        }
    }
}
