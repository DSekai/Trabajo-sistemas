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

        }

        private void menu_profesor_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {

        }
    }
}
