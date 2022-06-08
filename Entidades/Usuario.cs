using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Entidades
{
    public class Usuario
    {
        private string Nombre;
        private string Clave;
        private bool Habilitado;

        public Usuario(string nomUsuario, string clave)
        {
            Nombre = nomUsuario;
            Clave = clave;
        }

        public Usuario()
        {

        }

        public string NombreUsuario
        {
            get => Nombre;
            set => Nombre = value;
        }

        public string ClaveUsuario
        {
            get => Clave;
            set => Clave = value;
        }

        public bool HabilitadoUsuario
        {
            get => Habilitado;
            set => Habilitado = value;
        }
    }
}
