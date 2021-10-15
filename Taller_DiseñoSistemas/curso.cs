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
    public partial class curso : Form
    {
        public curso()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.CenterToScreen();

            cargar_curso();
        }

        private void cargar_curso()
        {
            DataTable infocurso = new DataTable();

            cursos datoscurso = new cursos();

            infocurso = datoscurso.Consultarcurso();

            dataGridView1.DataSource = infocurso;
        }

        private void cargar_curso2()
        {
            String nombre = txtbuscar.Text;

            DataTable infocurso = new DataTable();

            cursos datoscurso = new cursos(nombre);

            infocurso = datoscurso.Consultarcurso2();

            dataGridView1.DataSource = infocurso;

        }

        private void limpiar()
        {
            txtid.Clear();
            txtnombre.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtnombre.Text == "")
            {
                MessageBox.Show("Ingrese los datos");
            }
            else
            {
                String nombre = txtnombre.Text;

                cursos c = new cursos(nombre);

                c.ingresar_curso();

                limpiar();

                cargar_curso();

            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cargar_curso2();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
            limpiar();
        }
    }
}
