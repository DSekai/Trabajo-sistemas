using System;
using System.Data;
using System.Windows.Forms;

using Taller_DiseñoSistemas.Class;

namespace Taller_DiseñoSistemas
{
    public partial class Login_registro : Form
    {
        public Login_registro()
        {
            InitializeComponent();
        }

        String contador;

        private void verificar_usuario()
        {
            String user = txtuser.Text;

            DataTable infousuario = new DataTable();

            usuarios datos_usuarios = new usuarios(user);

            infousuario = datos_usuarios.buscar_usuario();

            //dataGridView1.DataSource = infoalumnos;

            contador = infousuario.Rows[0]["Count(*)"].ToString();
        }

        String contador2;

        private void verificar_usuario2()
        {
            String user = txtuser.Text;

            DataTable infousuario = new DataTable();

            usuarios datos_usuarios = new usuarios(user);

            infousuario = datos_usuarios.buscar_usuario3();

            //dataGridView1.DataSource = infoalumnos;

            contador2 = infousuario.Rows[0]["Count(*)"].ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();

            Login l = new Login();
            l.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            String user = txtuser.Text;
            String pass = txtpass.Text;

            if (user == "" || pass == "")
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
                        usuarios u = new usuarios(user, pass);

                        u.ingresar_usuario();

                        MessageBox.Show("Usuario agregado");

                        txtuser.Clear();
                        txtpass.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Usuario usado");
                    }

                }
                else
                {
                    MessageBox.Show("Usuario usado");
                }

            }
        }
    }
}
