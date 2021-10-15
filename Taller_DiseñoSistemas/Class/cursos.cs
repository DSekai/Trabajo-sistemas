using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_DiseñoSistemas.Class
{
    class cursos
    {

        private String nombre;

        public cursos(String _nombre)
        {
            this.nombre = _nombre;
        }

        public cursos()
        {
        }

        public void ingresar_curso()
        {
            Conexion connect = new Conexion();

            String query = String.Format("call sp_ingresar_curso('{0}');",
                this.nombre);

            connect.setQuery(query);

            connect.EjecutarConsulta();
        }

        public DataTable Consultarcurso()
        {
            DataTable asignatura = new DataTable();

            String query = "call sp_consultar_curso;";

            Conexion consulta = new Conexion();

            consulta.setQuery(query);

            asignatura = consulta.ConsultaDatos();

            return asignatura;
        }

        public DataTable Consultarcurso2()
        {
            DataTable asignatura = new DataTable();

            String query = String.Format("call sp_consultar_curso2('{0}');",
                this.nombre);

            Conexion consulta = new Conexion();

            consulta.setQuery(query);

            asignatura = consulta.ConsultaDatos();

            return asignatura;
        }

    }
}
