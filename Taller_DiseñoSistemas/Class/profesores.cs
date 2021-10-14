using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_DiseñoSistemas.Class
{
    class profesores
    {
        private String rut;
        private String nombre;
        private String apellido;
        private String direccion;
        private String cargo;
        private int asignatura;

        private String valor;
        private int opcion;

        private String rut2;

        public profesores(String _rut, String _nombre,String _apellido, 
            String _direccion, String _cargo, int _asignatura)
        {
            this.rut = _rut;
            this.nombre = _nombre;
            this.apellido = _apellido;
            this.direccion = _direccion;
            this.cargo = _cargo;
            this.asignatura = _asignatura;

        }

        public profesores() { }

        public profesores(int _opcion, String _valor)
        {
            this.opcion = _opcion;
            this.valor = _valor;
        }
        public profesores(String _rut2)
        {
            this.rut2 = _rut2;
        }

        public void ingresar_profesor()
        {
            Conexion connect = new Conexion();

            String query = String.Format("call sp_ingresar_profesor('{0}','{1}','{2}','{3}','{4}','{5}');",
                this.rut, this.nombre, this.apellido, this.direccion, this.cargo, this.asignatura);

            connect.setQuery(query);

            connect.EjecutarConsulta();
        }
        public DataTable ConsultarProfesores()
        {
            DataTable profesor = new DataTable();

            String query = "call sp_consultar_profesor()";

            Conexion consulta = new Conexion();

            consulta.setQuery(query);

            profesor = consulta.ConsultaDatos();

            return profesor;

        }

        public DataTable ConsultarProfesores2()
        {
            DataTable alumnos = new DataTable();

            String query = String.Format("call sp_consultar_profesor2('{0}','{1}');",
                this.valor, this.opcion);

            Conexion consulta = new Conexion();

            consulta.setQuery(query);

            alumnos = consulta.ConsultaDatos();

            return alumnos;
        }
        public void EliminarProfesores()
        {
            Conexion connect = new Conexion();

            String query = String.Format("call sp_eliminarprofesor('{0}');",
                this.rut2);

            connect.setQuery(query);

            connect.EjecutarConsulta();

        }
    }
}
