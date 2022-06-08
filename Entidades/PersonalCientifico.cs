using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Entidades
{
    class PersonalCientifico
    {
        private string Nombre;
        private string Apellido;
        private int Documento;
        private int Legajo;
        private int NumCelular;
        private string CorreoPers;
        private string CorreoInst;

        public PersonalCientifico(string nomCient, string apeCient, int doc, int leg, int cel, string mailPers, string mailInst)
        {
            Nombre = nomCient;
            Apellido = apeCient;
            Documento = doc;
            Legajo = leg;
            NumCelular = cel;
            CorreoPers = mailPers;
            CorreoInst = mailInst;
        }

        public PersonalCientifico()
        {
            
        }

        public string NombrePersonal
        {
            get => Nombre;
            set => Nombre = value;
        }

        public string ApellidoPersonal
        {
            get => Apellido;
            set => Apellido = value;
        }

        public int NumeroDocumento
        {
            get => Documento;
            set => Documento = value;
        }

        public int NumeroLegajo
        {
            get => Legajo;
            set => Legajo = value;
        }

        public int NumeroCelular
        {
            get => NumCelular;
            set => NumCelular = value;
        }

        public string CorreoPersonal
        {
            get => CorreoPers;
            set => CorreoPers = value;
        }

        public string CorreoIntitucional
        {
            get => CorreoInst;
            set => CorreoInst = value;
        }
    }
}
