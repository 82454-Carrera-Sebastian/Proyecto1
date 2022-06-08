using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Entidades
{
    public class Estado
    {
        private string Ambito;
        private string Nombre;
        private string Descripcion;
        private bool EsReservable;
        private bool EsCancelable;


        public Estado(string ambito, string nomEstado, string descrip)
        {
            Ambito = ambito;
            Nombre = nomEstado;
            Descripcion = descrip;
        }
        public Estado()
        {

        }

        public string AmbitoEstado
        {
            get => Ambito;
            set => Ambito = value;
        }

        public string NomEstado
        {
            get => Nombre;
            set => Nombre = value;
        }

        public string DescripEstado
        {
            get => Descripcion;
            set => Descripcion = value;
        }

        public bool SePuedeReservar
        {
            get => EsReservable;
            set => EsReservable = value;
        }

        public bool SePuedeCancelar
        {
            get => EsCancelable;
            set => EsCancelable = value;
        }
    }
}
