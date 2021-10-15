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
    public partial class menu_profesor : Form
    {
        public menu_profesor()
        {
            InitializeComponent();
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

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            this.Close();

            Login l = new Login();

            l.Show();
        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            AbrirForm(new registro_anotaciones());
        }

        private void menu_profesor_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.CenterToParent();
        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            AbrirForm(new ingreso_notas());
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            AbrirForm(new Registro_asistencia());
        }
    }
}
