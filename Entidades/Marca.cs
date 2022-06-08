using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Entidades
{
    class Marca
    {
        private string Nombre;

        public Marca(string nomMarca)
        {
            Nombre = nomMarca;
        }

        public Marca()
        {

        }

        public string NombreMarca
        {
            get => Nombre;
            set => Nombre = value;
        }
    }
}
