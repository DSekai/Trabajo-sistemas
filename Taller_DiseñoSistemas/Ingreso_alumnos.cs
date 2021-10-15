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
    public partial class Ingreso_alumnos : Form
    {
        public Ingreso_alumnos()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.CenterToScreen();

            cargar_alumnos();
        }

        private void cargar_alumnos()
        {
            DataTable infoalumnos = new DataTable();

            alumnos datosalumnos = new alumnos();

            infoalumnos = datosalumnos.ConsultarAlumnos();

            dataGridView1.DataSource = infoalumnos;

        }

        private void cargar_alumnos2()
        {
            int opcion = bunifuDropdown1.SelectedIndex;
            String valor = bunifuTextBox1.Text;

            DataTable infoalumnos = new DataTable();

            alumnos datosalumnos = new alumnos(opcion, valor);

            infoalumnos = datosalumnos.ConsultarAlumnos2();

            dataGridView1.DataSource = infoalumnos;
        }

        private void limpiar()
        {
            txtrut.Clear();
            txtnombre.Clear();
            txtapellido.Clear();
            dateTimePicker1.ResetText();
            txtdirec.Clear();
            txttutor.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtrut.Text == "" || txtnombre.Text == "" || txtapellido.Text == "" ||
    dateTimePicker1.Value.ToString("dd-MM-yyyy") == "" || txttutor.Text == "")
            {
                MessageBox.Show("Ingrese los datos");
            }
            else
            {
                String rut = txtrut.Text;
                String nombre = txtnombre.Text;
                String apellido = txtapellido.Text;
                String nacimiento = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                String direccion = txtdirec.Text;
                String tutor = txttutor.Text;

                alumnos a = new alumnos(rut, nombre, apellido, nacimiento, direccion, tutor);

                a.ingresar_alumno();

                limpiar();

                cargar_alumnos();
            }
        }

        String id;

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

                String nombre, apellido, direc, tutor, nacimiento;
                string fila;
                fila = dataGridView1.CurrentRow.Index.ToString();

                id = dataGridView1.Rows[Int32.Parse(fila)].Cells[0].Value.ToString();
                nombre = dataGridView1.Rows[Int32.Parse(fila)].Cells[1].Value.ToString();
                apellido = dataGridView1.Rows[Int32.Parse(fila)].Cells[2].Value.ToString();
                nacimiento = dataGridView1.Rows[Int32.Parse(fila)].Cells[3].Value.ToString();
                direc = dataGridView1.Rows[Int32.Parse(fila)].Cells[4].Value.ToString();
                tutor = dataGridView1.Rows[Int32.Parse(fila)].Cells[5].Value.ToString();

                txtrut.Text = id;
                txtnombre.Text = nombre;
                txtapellido.Text = apellido;
                dateTimePicker1.Value = Convert.ToDateTime(nacimiento);
                txtdirec.Text = direc;
                txttutor.Text = tutor;

            }
            catch (NullReferenceException)
            {
                //MessageBox.Show("Seleccione fila correcta");
            }

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de eliminar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                String rut2 = id;

                alumnos a = new alumnos(rut2);

                a.EliminarAlumnos();

                cargar_alumnos();
            }
            else
            {
            }

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (txtrut.Text == "" || txtnombre.Text == "" || txtapellido.Text == "" ||
    dateTimePicker1.Value.ToString("dd-MM-yyyy") == "" || txttutor.Text == "")
            {
                MessageBox.Show("Ingrese los datos");
            }
            else
            {
                String rut = txtrut.Text;
                String nombre = txtnombre.Text;
                String apellido = txtapellido.Text;
                String nacimiento = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                String direccion = txtdirec.Text;
                String tutor = txttutor.Text;

                alumnos a = new alumnos(rut, nombre, apellido, nacimiento, direccion, tutor);

                a.modificar_alumno();

                limpiar();

                cargar_alumnos();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cargar_alumnos2();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
            limpiar();
        }
    }
}
