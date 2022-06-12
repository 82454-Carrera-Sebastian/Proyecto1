using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Entidades
{
    public class Sesión
    {
        private DateTime FechaHoraDesde;
        private DateTime FechaHoraHasta;
        private Usuario usu;

        public Sesión(DateTime comienzo)
        {
            FechaDeHoraDesde = comienzo;
            usu = new Usuario();
        }

        public Sesión()
        {

        }

        public DateTime FechaDeHoraDesde
        {
            get => FechaHoraDesde;
            set => FechaHoraDesde = value;
        }

        public DateTime FechaDeHoraHasta
        {
            get => FechaHoraHasta;
            set => FechaHoraHasta = value;
        }

        //metodo llamado por el gestor para obtener el legajo del cientifico llamando a la clase Usuario
        public string MostrarCientificoLogueado(string nombre)
        {
            string cientifico = usu.ObtenerCientifico(nombre);
            return cientifico;
        }
    }
}
