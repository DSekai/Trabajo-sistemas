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

        private void limpiar()
        {
            txtnombre.Text = "";
            txtnota1.Text = "";
            txtrut.Text = "";
            txtnota2.Text = "";
            txtnota3.Text = "";
            txtnota4.Text = "";
            txtnota5.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //cargar_alumnos2();
            
        }

        private void cargar_alumnos()
        {
            DataTable infonotas = new DataTable();
            notas datosnotas = new notas(label2.Text);
            infonotas = datosnotas.ConsultarNotas();
            dataGridView1.DataSource = infonotas;
        }

        private void cargar_Asignatura()
        {
            //DataSet infoasignatura = new DataSet();
            //notas datosasignatura = new notas("Sekai");
            //infoasignatura = datosasignatura.ConsultarAsignatura();
            //bunifuDropdown1.DataSource = infoasignatura;

        }

        private void ingreso_notas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gestion_notasDataSet8.asignatura' Puede moverla o quitarla según sea necesario.

            this.CenterToScreen();
            cargar_alumnos();
            cargar_Asignatura();
            
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
            limpiar();
        }

        string id;

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                String nombre, nota1, nota2, nota3, nota4, nota5;
                string fila;
                fila = dataGridView1.CurrentRow.Index.ToString();

                id = dataGridView1.Rows[Int32.Parse(fila)].Cells[0].Value.ToString();
                nombre = dataGridView1.Rows[Int32.Parse(fila)].Cells[1].Value.ToString();
                nota1 = dataGridView1.Rows[Int32.Parse(fila)].Cells[2].Value.ToString();
                nota2 = dataGridView1.Rows[Int32.Parse(fila)].Cells[3].Value.ToString();
                nota3 = dataGridView1.Rows[Int32.Parse(fila)].Cells[4].Value.ToString();
                nota4 = dataGridView1.Rows[Int32.Parse(fila)].Cells[5].Value.ToString();
                nota5 = dataGridView1.Rows[Int32.Parse(fila)].Cells[5].Value.ToString();
                txtnombre.Text = nombre;
                txtrut.Text = id;
                txtnota1.Text = nota1;
                txtnota2.Text = nota2;
                txtnota3.Text = nota3;
                txtnota4.Text = nota4;
                txtnota5.Text = nota5;
                txtrut.Text = dataGridView1.Rows[Int32.Parse(fila)].Cells[0].Value.ToString();

            }
            catch (NullReferenceException)
            {
                //MessageBox.Show("Seleccione fila correcta");
            }
        }
    }
}
