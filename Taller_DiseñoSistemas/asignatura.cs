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
    public partial class asignatura : Form
    {
        public asignatura()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.CenterToScreen();

            cargar_asignatura();
        }

        private void cargar_asignatura()
        {
            DataTable infoasignatura = new DataTable();

            asignaturas datosasignatura = new asignaturas();

            infoasignatura = datosasignatura.ConsultarAsignaturas();

            dataGridView1.DataSource = infoasignatura;
        }

        private void cargar_asignatura2()
        {
            String nombre = txtbuscar.Text;

            DataTable infoasignatura = new DataTable();

            asignaturas datosasignatura = new asignaturas(nombre);

            infoasignatura = datosasignatura.ConsultarAsignaturas2();

            dataGridView1.DataSource = infoasignatura;

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

                asignaturas a = new asignaturas(nombre);

                a.ingresar_asignatura();

                limpiar();

                cargar_asignatura();

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
            cargar_asignatura2();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
            limpiar();
        }
    }
}
