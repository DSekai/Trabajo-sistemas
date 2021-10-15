using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_DiseñoSistemas.Class
{
    class asistencia
    {
        private String rut;

        private String fecha;
       
        private String asis;
        private String asignatura;
        public asistencia(String _rut, String _fecha, string _asistencia, string _asignatura)
        {
            this.rut = _rut;
            this.fecha = _fecha;
            this.asis = _asistencia;
            this.asignatura = _asignatura;


        }

        public asistencia(string rut, string fecha, string asis)
        {
            this.rut = rut;
            this.fecha = fecha;
            this.asis = asis;
        }

        public void ingresar_asistencia()
        {
            Conexion connect = new Conexion();

            String query = String.Format("call sp_ingresar_asistencia('{0}','{1}','{2}','{3}','{4}');",
                this.rut, this.fecha, this.asis, this.asignatura);

            connect.setQuery(query);

            connect.EjecutarConsulta();
        }

        public DataTable consultar_curso()
        {
            DataTable curso = new DataTable();

            String query = "call sp_consultar_curso_anotacion;";

            Conexion consulta = new Conexion();

            consulta.setQuery(query);

            curso = consulta.ConsultaDatos();

            return curso;

        }
    }
}
