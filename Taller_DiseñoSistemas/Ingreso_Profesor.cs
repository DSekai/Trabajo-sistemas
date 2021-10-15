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
    public partial class Ingreso_Profesor : Form
    {
        public Ingreso_Profesor()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gestion_notasDataSet.asignatura' Puede moverla o quitarla según sea necesario.
            this.asignaturaTableAdapter.Fill(this.gestion_notasDataSet.asignatura);
            this.CenterToScreen();
            cargar_profesores();

        }

        private void cargar_profesores()
        {
            DataTable infoprofesor = new DataTable();

            profesores datosprofesor = new profesores();

            infoprofesor = datosprofesor.ConsultarProfesores();

            dataGridView1.DataSource = infoprofesor;
        }
        private void cargar_profesores2()
        {
            int opcion = bunifuDropdown1.SelectedIndex;
            String valor = bunifuTextBox1.Text;

            DataTable infoprofesor = new DataTable();

            profesores datosprofesor = new profesores(opcion, valor);

            infoprofesor = datosprofesor.ConsultarProfesores2();

            dataGridView1.DataSource = infoprofesor;
        }

        /*private void cargar_asignatura()
        {
            
            DataTable infoasignatura = new DataTable();

            asignaturas datosasignatura = new asignaturas();

            infoasignatura = datosasignatura.ConsultarAsignaturas3();

        }*/

        private void limpiar()
        {
            txtrut.Clear();
            txtnombre.Clear();
            txtapellido.Clear();
            txtdirec.Clear();
            txtcargo.Clear();
            comboBox1.ResetText();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtrut.Text == "" || txtnombre.Text == "" || txtapellido.Text == "" || txtcargo.Text == "")
            {
                MessageBox.Show("Ingrese los datos");
            }
            else
            {
                String rut = txtrut.Text;
                String nombre = txtnombre.Text;
                String apellido = txtapellido.Text;
                String direccion = txtdirec.Text;
                String cargo = txtcargo.Text;
                int asignatura = Convert.ToInt32(comboBox1.SelectedValue);

                profesores p = new profesores(rut, nombre, apellido, direccion, cargo, asignatura);

                p.ingresar_profesor();

                limpiar();

                cargar_profesores();

            }
        }

        String id;

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                String nombre, apellido, direc, cargo, fila, nombre_asig;
                String id_asig;

                fila = dataGridView1.CurrentRow.Index.ToString();

                id = dataGridView1.Rows[Int32.Parse(fila)].Cells[0].Value.ToString();
                nombre = dataGridView1.Rows[Int32.Parse(fila)].Cells[1].Value.ToString();
                apellido = dataGridView1.Rows[Int32.Parse(fila)].Cells[2].Value.ToString();
                direc = dataGridView1.Rows[Int32.Parse(fila)].Cells[3].Value.ToString();
                cargo = dataGridView1.Rows[Int32.Parse(fila)].Cells[4].Value.ToString();

                //llenado de combobox
                id_asig = dataGridView1.Rows[Int32.Parse(fila)].Cells[5].Value.ToString();

                DataTable infoasignatura = new DataTable();
                asignaturas datosasignatura = new asignaturas(id_asig);
                infoasignatura = datosasignatura.ConsultarAsignaturas3();
                nombre_asig = infoasignatura.Rows[0]["nombre"].ToString();
                comboBox1.Text = nombre_asig;
                

                txtnombre.Text = nombre;
                txtrut.Text = id;
                txtapellido.Text = apellido;
                txtdirec.Text = direc;
                txtcargo.Text = cargo;
                //txtrut.Text = dataGridView1.Rows[Int32.Parse(fila)].Cells[0].Value.ToString();

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

                profesores p = new profesores(rut2);

                p.EliminarProfesores();

                cargar_profesores();
            }
            else
            {
            }

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            /*if (txtrut.Text == "" || txtnombre.Text == "" || txtapellido.Text == "" ||
    dateTimePicker1.Value.ToString("dd-MM-yyyy") == "" || txtcargo.Text == "")
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
                String tutor = txtcargo.Text;

                alumnos a = new alumnos(rut, nombre, apellido, nacimiento, direccion, tutor);

                a.modificar_alumno();

                limpiar();

                cargar_alumnos();
            }*/
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cargar_profesores2();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
            limpiar();
        }
    }
}
