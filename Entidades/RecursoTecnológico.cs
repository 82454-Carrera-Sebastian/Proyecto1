using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Entidades
{
    public class RecursoTecnológico
    {
        private int NumeroRT;
        private DateTime FechaAlta;
        private int PeriodicidadMantPreventivo;
        private int DuracionMantPreventivo;
        private int FraccionHorarioTurnos;

        public RecursoTecnológico(int numRT, DateTime fechaAlta)
        {
            NumeroRT = numRT;
            FechaAlta = fechaAlta;
        }

        public RecursoTecnológico()
        {

        }

        public int NumRecurso
        {
            get => NumeroRT;
            set => NumeroRT = value;
        }

        public DateTime FechaDeAlta
        {
            get => FechaAlta;
            set => FechaAlta = value;
        }

        public int PeriodicidadDeMantPrev
        {
            get => PeriodicidadMantPreventivo;
            set => PeriodicidadMantPreventivo = value;
        }

        public int DuracionDeMantenimientoPrev
        {
            get => DuracionMantPreventivo;
            set => DuracionMantPreventivo = value;
        }

        public int FraccionHorarioDeTurnos
        {
            get => FraccionHorarioTurnos;
            set => FraccionHorarioTurnos = value;
        }
    }

    
}
