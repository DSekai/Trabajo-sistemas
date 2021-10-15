using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_DiseñoSistemas.Class
{
    class alumnos
    {
        private String rut;
        private String nombre;
        private String apellido;
        private String nacimiento;
        private String direccion;
        private String tutor;
        private int curso;

        private String rut2;

        private int opcion;
        private String valor;


        public alumnos(String _rut, String _nombre, String _apellido, String _nacimiento,
            String _direccion, String _tutor, int _curso)
        {
            this.rut = _rut;
            this.nombre = _nombre;
            this.apellido = _apellido;
            this.nacimiento = _nacimiento;
            this.direccion = _direccion;
            this.tutor = _tutor;
            this.curso = _curso;

        }
        public alumnos(String _rut2)
        {
            this.rut2 = _rut2;
        }

        public alumnos() { }

        public void ingresar_alumno()
        {
            Conexion connect = new Conexion();

            String query = String.Format("call sp_ingresar_alumno('{0}','{1}','{2}','{3}','{4}','{5}','{6}');",
                this.rut, this.nombre, this.apellido, this.nacimiento, this.direccion, this.tutor, this.curso);

            connect.setQuery(query);

            connect.EjecutarConsulta();
        }

        public DataTable ConsultarAlumnos()
        {
            DataTable alumnos = new DataTable();

            String query = "call sp_consultaralumno;";

            Conexion consulta = new Conexion();

            consulta.setQuery(query);

            alumnos = consulta.ConsultaDatos();

            return alumnos;

        }



        public void EliminarAlumnos()
        {
            Conexion connect = new Conexion();

            String query = String.Format("call sp_eliminaralumno('{0}');",
                this.rut2);

            connect.setQuery(query);

            connect.EjecutarConsulta();

        }

        public void modificar_alumno()
        {
            Conexion connect = new Conexion();

            String query = String.Format("call sp_modificaralumno('{0}','{1}','{2}','{3}','{4}','{5}','{6}');",
                this.rut, this.nombre, this.apellido, this.nacimiento, this.direccion, this.tutor, this.curso);

            connect.setQuery(query);

            connect.EjecutarConsulta();
        }

        public alumnos(int _opcion, String _valor)
        {
            this.opcion = _opcion;
            this.valor = _valor;
        }

        public DataTable ConsultarAlumnos2()
        {
            DataTable alumnos = new DataTable();

            String query = String.Format("call sp_consultaralumno2('{0}','{1}');",
                this.valor, this.opcion);

            Conexion consulta = new Conexion();

            consulta.setQuery(query);

            alumnos = consulta.ConsultaDatos();

            return alumnos;

        }
    }
}
