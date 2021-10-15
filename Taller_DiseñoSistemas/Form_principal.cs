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
            //FormHijo.Parent = Wrapper;

            //FormHijo.Location = new Point((Wrapper.Width - FormHijo.Width) / 2, (Wrapper.Height - FormHijo.Height) / 2);

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
            AbrirForm(new Ingreso_Profesor());
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (Sidebar.Width == 180)
            {
                Sidebar.Visible = false;
                Sidebar.Width = 53;
                SidebarWrapper.Width = 68;
                bunifuSeparator1.Width = 40;
                animacion1.Show(Sidebar);
            }
            else
            {
                Sidebar.Visible = false;
                Sidebar.Width = 180;
                SidebarWrapper.Width = 195;
                bunifuSeparator1.Width = 168;
                animacion1.Show(Sidebar);
            }
        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            Wrapper.Controls.Clear();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            pictureBox3.Visible = false;
            pictureBox5.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            pictureBox3.Visible = true;
            pictureBox5.Visible = false;
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            this.Close();

            Login l = new Login();

            l.Show();
        }

        private void bunifuButton25_Click(object sender, EventArgs e)
        {
            AbrirForm(new asignatura());
        }

        private void bunifuButton26_Click(object sender, EventArgs e)
        {
            AbrirForm(new curso());
        }
    }
}
