using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller_DiseñoSistemas
{
    public partial class Form_principal : Form
    {
        public Form_principal()
        {
            InitializeComponent();
        }

        private void Form_principal_Load(object sender, EventArgs e)
        {
            this.CenterToParent();

        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            AbrirForm(new Ingreso_alumnos());
        }

        private Form formactivado = null;

        private void AbrirForm(Form FormHijo) 
        {
            if (formactivado != null)
                formactivado.Close();
            formactivado = FormHijo;
            FormHijo.TopLevel = false;
            FormHijo.Dock = DockStyle.Fill;
            Wrapper.Controls.Add(FormHijo);
            Wrapper.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            AbrirForm(new Form2());
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            this.Close();

            Login l = new Login();

            l.Show();
        }
    }
}
