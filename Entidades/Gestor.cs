using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Entidades
{
    class Gestor
    {
        private string DatosReservasTurnos; //Datos de reservas de los turnos confirmados y pendientes de confirmación
        private string CorreoRRT;
        private string EstadoRT;
        private DateTime FechaActual;
        private string RTDisponible; // RT disponible de RRT
        private string TurnosConfYPend; //
        private string UsuarioLogueado;



        public Gestor()
        {
            
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
    }
}
