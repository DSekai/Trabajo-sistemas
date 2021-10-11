using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Data;

namespace Taller_DiseñoSistemas.Class
{
    class usuarios
    {

        private String usuario;
        private String contraseña;

        public usuarios(String _usuario, String _contraseña)
        {
            this.usuario = _usuario;
            this.contraseña = _contraseña;
        }

        public usuarios() { }

        public void ingresar_usuario()
        {
            //try
            //{
            Conexion connect = new Conexion();

            String query = String.Format("call sp_ingresar_usuario('{0}','{1}');",
                this.usuario, this.contraseña);

            connect.setQuery(query);

            connect.EjecutarConsulta();
            //}
            //catch (Du)
            //{
            //  MessageBox.Show("Error");
            //}
        }

        public usuarios(String _user)
        {
            this.usuario = _user;
        }

        public DataTable buscar_usuario()
        {
            DataTable usuario = new DataTable();

            String query = String.Format("call sp_buscar_usuario('{0}');",
                this.usuario);

            Conexion consulta = new Conexion();

            consulta.setQuery(query);

            usuario = consulta.ConsultaDatos();

            return usuario;
        }

        public DataTable buscar_usuario3()
        {
            DataTable usuario = new DataTable();

            String query = String.Format("call sp_buscar_usuario3('{0}');",
                this.usuario);

            Conexion consulta = new Conexion();

            consulta.setQuery(query);

            usuario = consulta.ConsultaDatos();

            return usuario;
        }

        public DataTable buscar_usuario2()
        {
            DataTable usuario = new DataTable();

            String query = String.Format("call sp_buscar_usuario2('{0}','{1}');",
                this.usuario, this.contraseña);

            Conexion consulta = new Conexion();

            consulta.setQuery(query);

            usuario = consulta.ConsultaDatos();

            return usuario;
        }

        public DataTable buscar_usuario4()
        {
            DataTable usuario = new DataTable();

            String query = String.Format("call sp_buscar_usuario4('{0}','{1}');",
                this.usuario, this.contraseña);

            Conexion consulta = new Conexion();

            consulta.setQuery(query);

            usuario = consulta.ConsultaDatos();

            return usuario;
        }
    }
}
