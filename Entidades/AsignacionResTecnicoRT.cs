using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Entidades
{
    public class AsignacionResTecnicoRT
    {
        private DateTime FechaHoraDesde;
        private DateTime FechaHoraHasta;

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

        public AsignacionResTecnicoRT(DateTime fechaHoraDesde, DateTime fechaHoraHasta)
        {
            FechaHoraDesde = fechaHoraDesde;
            FechaHoraHasta = fechaHoraHasta;
        }
        public AsignacionResTecnicoRT()
        {

        }

        //metodo llamado por el gestor que envia una lista con todos los RT de los cuales el cientifico es o fue responsable
        //para que esta clase revise si es responsable actual
        //si la fechaHasta devuelve un NULL es pq ese es responsaable actual
        public bool EsUsuarioVigente(string numRT)
        {
            bool Resultado = false;
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT FechaHasta FROM AsignacionRespTecnRT WHERE numRT LIKE '" + int.Parse(numRT) + "'";

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                SqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader == null && dataReader.Read())
                {
                    Resultado = true;
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
            return Resultado;
        }

        //Metodo llamado por el gestor que envia todos los RT de los cuales el cientifico es responsable para que sean mostrados
        //Una vez obtenidos los datos del RT se llamara al metodo esActivo que es propio de RT para ver si este no se encuentra en
        //mantenimiento en este momento
        public DataTable MostrarRT(DataTable tabla2, RecursoTecnológico RT)
        {
            DataTable tabla = new DataTable();
            foreach (DataRow row in tabla2.Rows)
            {
                string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
                SqlConnection cn = new SqlConnection(cadenaConex);
                try
                {
                    SqlCommand cmd = new SqlCommand();

                    string consulta = "SELECT T.nombre, R.numRecurso, MA.nombre ,M.nombre  FROM RecursoTecnológico R JOIN TipoRecurso T ON R.idTipoRT = T.id JOIN Modelo M ON M.id = R.idModelo JOIN Marca MA ON MA.id = M.idMarca JOIN AsignacionRespTecnRT A ON A.nroRT = R.numRecurso WHERE  R.numRecurso LIKE '" + row + "' GROUP BY R.idTipoRT, T.nombre, R.numRecurso, MA.nombre ,M.nombre ";

                    cmd.Parameters.Clear();

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = consulta;

                    cn.Open();
                    cmd.Connection = cn;


                    SqlDataAdapter da = new SqlDataAdapter(cmd);



                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (RT.esActivo(dataReader["R.numRecurso"].ToString()) && dataReader.Read())
                    {
                        da.Fill(tabla);
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
                
            }
            return tabla;

        }
    }
}
