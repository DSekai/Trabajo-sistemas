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
        public DataTable ConsultarNotas()
        {
            DataTable notas = new DataTable();
            string query = "call sp_consultaralumno_notas;";
            Conexion consulta = new Conexion();
            consulta.setQuery(query);
            notas = consulta.ConsultaDatos();

            return notas;
        }
    }
}
