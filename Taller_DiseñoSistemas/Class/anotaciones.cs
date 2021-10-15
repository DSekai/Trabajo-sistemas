using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_DiseñoSistemas.Class
{
    class anotaciones
    {
        private String rut;
   
        private String fecha;
        private String anotacion;
        private String detalle;
       

        public anotaciones(String _rut, String _fecha, String _anotacion, String _detalle)
        {
            this.rut = _rut;
            this.fecha = _fecha;
            this.anotacion = _anotacion;
            this.detalle = _detalle;
           

        }

        public anotaciones(){}

        public void ingresar_anotacion()
        {
            Conexion connect = new Conexion();

            String query = String.Format("call sp_ingresar_anotaciones('{0}','{1}','{2}','{3}','{4}');",
                this.rut,  this.fecha, this.anotacion, this.detalle);

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

        public DataTable carga_dt()
        {
            DataTable curso = new DataTable();

            String query = "call sp_consultar_alumno_anotacion;";

            Conexion consulta = new Conexion();

            consulta.setQuery(query);

            curso = consulta.ConsultaDatos();

            return curso;

        }


    }
}
