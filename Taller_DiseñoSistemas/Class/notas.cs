using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_DiseñoSistemas.Class
{
    class notas
    {
        private string nombre;

        public notas(string _nombre)
        {
            this.nombre = _nombre;
        }
        public DataTable ConsultarNotas()
        {
            DataTable notas = new DataTable();
            string query = "call sp_consultaralumno_notas;";
            Conexion consulta = new Conexion();
            consulta.setQuery(query);
            notas = consulta.ConsultaDatos();

            return notas;
        }

        public DataSet ConsultarAsignatura()
        {
            DataSet notas = new DataSet();
            string query = String.Format("call sp_consultaprosig('{0}');", this.nombre);
            Conexion consulta = new Conexion();
            consulta.setQuery(query);
            notas = consulta.ConsultaDatos2();

            return notas;
        }
    }
}
