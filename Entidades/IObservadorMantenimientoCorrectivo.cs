using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Entidades
{
    public interface IObservadorMantenimientoCorrectivo
    {
        void EnviarNotificacion(string fecha, string contacto, string id);
    }
}
