using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taller_DiseñoSistemas.Class;

namespace Taller_DiseñoSistemas
{
    public partial class Registro_asistencia : Form
    {
        public Registro_asistencia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String rut = txt_rut.Text;

            String fecha = monthCalendar1.Text;
            String asis = registro();


            asistencia p = new asistencia(rut, fecha, asis);

            p.ingresar_asistencia();

        }


        private string registro()
        {
            if (radio_presente.Checked)

                return "Presente";

            else if (radio_ausente.Checked)

                return "Ausente";

            else
                return null;
        }

        private void consultar_curso()
        {
            DataTable infocurso = new DataTable();

            anotaciones datoscurso = new anotaciones();

            infocurso = datoscurso.consultar_curso();

            combo_curso.DataSource = infocurso;
        }

        private void carga_dt()
        {
            DataTable infocurso = new DataTable();

            anotaciones datoscurso = new anotaciones();

            infocurso = datoscurso.consultar_curso();

            DataTable1.DataSource = infocurso;
        }

        private void Registro_asistencia_Load(object sender, EventArgs e)
        {
            consultar_curso();
            carga_dt();

        }
    }




}
