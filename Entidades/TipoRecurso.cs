using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Entidades
{
    public class TipoRecurso
    {
        private string Nombre;
        private string Descripcion;

        public TipoRecurso(string nomRecurso, string descrip)
        {
            Nombre = nomRecurso;
            Descripcion = descrip;
        }

        public TipoRecurso()
        {

        }

        public string NombreRecurso
        {
            get => Nombre;
            set => Nombre = value;
        }

        public string DescripcionRecurso
        {
            get => Descripcion;
            set => Descripcion = value;
        }
    }
}
