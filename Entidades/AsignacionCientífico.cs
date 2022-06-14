using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Entidades
{
    public class AsignacionCientífico
    {
        private DateTime FechaDesde;
        private DateTime FechaHasta;
        private PersonalCientifico pc;

        public AsignacionCientífico(DateTime fechaDesde, DateTime fechaHasta)
        {
            FechaDesde = fechaDesde;
            FechaHasta = fechaHasta;
            pc = new PersonalCientifico();
        }

        public DateTime FechaDeHoraDesde
        {
            get => FechaDesde;
            set => FechaDesde = value;
        }

        public DateTime FechaDeHoraHasta
        {
            get => FechaHasta;
            set => FechaHasta = value;
        }

        public AsignacionCientífico()
        {

        }

        //Metodo llamado por la clase turno que deberia obtener a traves de la tabla asignacion el id del personal cientifico
        //(modificar bd y metodo de abajo para obtener el usuario), este metodo llamara a los metodos de la clase PC para
        //obtener los datos del mismo, por ultimo se llenara la tabla con todos los datos que luego sera devuelta a traves de los 
        //metodos al gestor
        public DataTable MostrarAsignacionCientifico(string id, DataTable TablaDatosTurnos,string fechaHoraInicio)
        {
            pc = new PersonalCientifico();
            string nombre = pc.MostrarNombre(id);
            string apellido = pc.MostrarApellido(id);
            string correo = pc.MostrarCorreo(id);

            TablaDatosTurnos.Rows.Add(fechaHoraInicio, nombre, apellido, correo);
            return TablaDatosTurnos;
        }
    }

}
