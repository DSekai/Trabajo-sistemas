using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Configuration;
using MySql.Data;
using System.Data;
using System.Windows.Forms;

namespace Taller_DiseñoSistemas.Class
{
    class Conexion
    {
        public MySqlConnection conn;
        public string query;

        static string server = ConfigurationManager.AppSettings["host"];
        static string database = ConfigurationManager.AppSettings["namebd"];
        static string user = ConfigurationManager.AppSettings["user"];
        static string pass = ConfigurationManager.AppSettings["pass"];

        public String connecString = String.Format("server={0};uid={1};pwd={2};database={3}", server, user, pass, database);

        public void setQuery(String _query)
        {
            this.query = _query;
        }

        public void EjecutarConsulta()
        {
            try
            {
                using (conn = new MySqlConnection(connecString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(this.query, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error {0}", ex.Message);
            }
        }

        public DataTable ConsultaDatos()
        {
            DataTable dt = new DataTable();
            try
            {
                using (conn = new MySqlConnection(connecString))
                {
                    conn.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(this.query, conn);
                    adapter.Fill(dt);

                    return dt;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error {0}", ex.Message);
                throw;
            }
        }

        public DataSet ConsultaDatos2()
        {
            DataSet dt = new DataSet();
            try
            {
                using (conn = new MySqlConnection(connecString))
                {
                    conn.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(this.query, conn);
                    adapter.Fill(dt);

                    return dt;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error {0}", ex.Message);
                throw;
            }
        }
    }


}
