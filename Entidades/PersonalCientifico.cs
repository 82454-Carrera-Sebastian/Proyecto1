using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        //Metodo llamado por la clase asignacion para obtener los datos del PC
        public string MostrarNombre(string id)
        {
            string nombre = "";
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT P.nombre FROM PersonalCientífico P JOIN Turno T ON P.legajo = T.idPersonal WHERE T.id LIKE '" + id + "' ";

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;


                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader != null && dataReader.Read())
                {
                    nombre = dataReader["nombre"].ToString();
                }


            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return nombre;
        }

        //Metodo llamado por la clase asignacion para obtener los datos del PC
        public string MostrarApellido(string id)
        {
            string apellido = "";
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT P.apellido FROM PersonalCientífico P JOIN Turno T ON P.legajo = T.idPersonal WHERE T.id LIKE '" + id + "' ";

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;


                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader != null && dataReader.Read())
                {
                    apellido = dataReader["apellido"].ToString();
                }


            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return apellido;
        }

        //Metodo llamado por la clase asignacion para obtener los datos del PC
        public string MostrarCorreo(string id)
        {
            string correo = "";
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT P.correoInst FROM PersonalCientífico P JOIN Turno T ON P.legajo = T.idPersonal WHERE T.id LIKE '" + id + "' ";

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;


                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader != null && dataReader.Read())
                {
                    correo = dataReader["correoInst"].ToString();
                }


            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return correo;
        }




    }

}
