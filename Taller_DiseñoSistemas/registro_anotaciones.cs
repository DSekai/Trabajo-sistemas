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
    public partial class registro_anotaciones : Form
    {
        public registro_anotaciones()
        {
            InitializeComponent();
        }

        private string registro()
        {
            if (rd_positivo.Checked)

                return "Positiva";

            else if (rd_negativo.Checked)

                return "Negativo";

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


        private void registro_anotaciones_Load(object sender, EventArgs e)
        {
            consultar_curso();
            carga_dt();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String rut = txt_rut.Text;

            String fecha = dateTimePicker1.Value.ToString("dd / MM / yyyy");
            String asis = registro();
            String detalle = txt_detalle.Text;

            anotaciones p = new anotaciones(rut, fecha, asis, detalle);

            p.ingresar_anotacion();

        }
    }
}
