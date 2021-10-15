using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_DiseñoSistemas.Class
{
    class asignaturas
    {
        private String nombre;
        private int id;

        public asignaturas(String _nombre)
        {
            this.nombre = _nombre;
        }

        public asignaturas(int _id)
        {
            this.id = _id;
        }

        public asignaturas()
        {
        }

        public void ingresar_asignatura()
        {
            Conexion connect = new Conexion();

            String query = String.Format("call sp_ingresar_asignatura('{0}');",
                this.nombre);

            connect.setQuery(query);

            connect.EjecutarConsulta();
        }

        public DataTable ConsultarAsignaturas()
        {
            DataTable asignatura = new DataTable();

            String query = "call sp_consultar_asignatura;";

            Conexion consulta = new Conexion();

            consulta.setQuery(query);

            asignatura = consulta.ConsultaDatos();

            return asignatura;
        }

        public DataTable ConsultarAsignaturas2()
        {
            DataTable asignatura = new DataTable();

            String query = String.Format("call sp_consultar_asignatura2('{0}');",
                this.nombre);

            Conexion consulta = new Conexion();

            consulta.setQuery(query);

            asignatura = consulta.ConsultaDatos();

            return asignatura;
        }

        public DataTable ConsultarAsignaturas3()
        {
            DataTable asignatura = new DataTable();

            String query = String.Format("call sp_consultar_asignatura3('{0}');",
                this.nombre);

            Conexion consulta = new Conexion();

            consulta.setQuery(query);

            asignatura = consulta.ConsultaDatos();

            return asignatura;
        }

    }
}
