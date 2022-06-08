using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Entidades
{
    class Modelo
    {
        private string Nombre;

        public Modelo(string nomModelo)
        {
            Nombre = nomModelo;
        }

        public Modelo()
        {

        }

        public string NombreModelo
        {
            get => Nombre;
            set => Nombre = value;
        }
    }
}
