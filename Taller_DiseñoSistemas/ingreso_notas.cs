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
        }

        private void cargar_alumnos()
        {
            DataTable infoalumnos = new DataTable();
            alumnos datosalumnos = new alumnos();
            //infoalumnos = datosalumnos.ConsultarAlumnos
        }

        private void ingreso_notas_Load(object sender, EventArgs e)
        {

        }
    }
}
