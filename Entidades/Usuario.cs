using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        private int legajo;

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

        public int ObtenerLegajo
        {
            get => legajo;
            set => legajo = value;
        }

        //Metodo llamado por la  clase sesion para obtener el nombre del cientifico
        //busca en la BD el nombre del cientifico utilizando el legajo
        public string ObtenerCientifico(int legajoUsuario)
        {
            string nombreApellido = "";
            DataTable tabla = new DataTable();
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT nombre, apellido  FROM PersonalCientifico WHERE legajo LIKE '"+legajoUsuario+"'"; 

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;


                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader != null && dataReader.Read())
                {
                    nombreApellido = dataReader["nombre, apellido"].ToString();
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
            return nombreApellido;
        }
    }
}
