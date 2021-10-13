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
    public partial class ingreso_notas : Form
    {
        public ingreso_notas()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //cargar_alumnos2();
            cargar_alumnos();
        }

        private void cargar_alumnos()
        {
            DataTable infonotas = new DataTable();
            notas datosnotas = new notas();
            infonotas = datosnotas.ConsultarNotas();
            dataGridView1.DataSource = infonotas;
        }

        private void ingreso_notas_Load(object sender, EventArgs e)
        {

        }
    }
}
