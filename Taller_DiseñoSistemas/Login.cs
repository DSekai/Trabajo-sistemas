using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Taller_DiseñoSistemas.Class;

namespace Taller_DiseñoSistemas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        String contador;

        private void verificar_usuario()
        {
            String user = txtuser.Text;
            String pass = txtpass.Text;

            DataTable infousuario = new DataTable();

            usuarios datos_usuarios = new usuarios(user, pass);

            infousuario = datos_usuarios.buscar_usuario2();

            contador = infousuario.Rows[0]["Count(*)"].ToString();
        }

        String contador2;

        private void verificar_usuario2()
        {
            String user = txtuser.Text;
            String pass = txtpass.Text;

            DataTable infousuario = new DataTable();

            usuarios datos_usuarios = new usuarios(user, pass);

            infousuario = datos_usuarios.buscar_usuario4();

            contador2 = infousuario.Rows[0]["Count(*)"].ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                //this.Close();

                Application.Exit();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        // Codigo Login button normal

        /*private void button1_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "" || txtpass.Text == "")
            {
                MessageBox.Show("Ingrese datos");
            }
            else
            {
                verificar_usuario2();

                if (Convert.ToInt16(contador2) <= 0)
                {
                    verificar_usuario();

                    if (Convert.ToInt16(contador) <= 0)
                    {
                        MessageBox.Show("Usuario o contraseña invalida");
                    }
                    else
                    {
                        Form_principal f = new Form_principal();

                        f.Show();
                        f.label2.Text = txtuser.Text;

                        this.Close();
                    }
                }
                else
                {
                    Form_principal2 f = new Form_principal2();

                    f.Show();
                    f.label2.Text = "Admin";

                    this.Close();
                }

            }
        }*/

        private void bunifuLabel1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Login_registro l = new Login_registro();
            l.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "" || txtpass.Text == "")
            {
                MessageBox.Show("Ingrese datos");
            }
            else
            {
                verificar_usuario2();

                if (Convert.ToInt16(contador2) <= 0)
                {
                    verificar_usuario();

                    if (Convert.ToInt16(contador) <= 0)
                    {
                        MessageBox.Show("Usuario o contraseña invalida");
                    }
                    else
                    {
                        menu_profesor f = new menu_profesor();

                        f.Show();
                        f.label2.Text = txtuser.Text;

                        this.Close();
                    }
                }
                else
                {
                    Form_principal f = new Form_principal();

                    f.Show();

                    f.label2.Text = "Admin";

                    this.Close();
                }
            }
        }
    }
}
