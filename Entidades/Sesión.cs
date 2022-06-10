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

        public Sesión(DateTime comienzo)
        {
            FechaDeHoraDesde = comienzo;
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

        //metodo llamado por el gestor para obtener el nombre del cientifico llamando a la clase Usuario
        public string MostrarCientificoLogueado(int legajoUsuario, Usuario usu)
        {
            int cientifico = int.Parse(usu.ObtenerCientifico(legajoUsuario));
            return cientifico.ToString();
        }
    }
}
