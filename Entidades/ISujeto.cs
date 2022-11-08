using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Entidades
{
    public interface ISujeto
    {
        void Quitar(IObservadorMantenimientoCorrectivo observador);

        void Suscribir(IObservadorMantenimientoCorrectivo observador);

        void Notificar();
    }
}
