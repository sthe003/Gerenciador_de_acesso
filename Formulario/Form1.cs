using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassEntidades;
using ClassNegocios;


namespace Formulario
{
    public partial class Form1 : Form
    {

        ClasseNegocios clUser = new ClasseNegocios();
        ClasseEntidade clEntidade = new ClasseEntidade();

        public static string user_name;
        public static string id_type;
        public static string user_general;
        public static string user_pass;

        FormPrincipal f = new FormPrincipal();


        public Form1()
        {
            InitializeComponent();
        }

        private void Clean()
        {
            textBox1.Text = "";
            textBox3.Text = "";
        }
     

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            clUser.userform = textBox1.Text;
            clUser.passform = textBox3.Text;
            dt = clUser.N_login(clUser);

            if(dt.Rows.Count>0)
            {
                MessageBox.Show("Bem-vindo" + dt.Rows[0][0].ToString(), "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                user_name = dt.Rows[0][0].ToString();
                id_type = dt.Rows[0][1].ToString();
                user_general = dt.Rows[0][2].ToString();
                user_pass = dt.Rows[0][3].ToString();
                this.Hide();
                f.ShowDialog();
                Clean();
    }
            else
            {
                MessageBox.Show("usuário e/ou senha incorreto(s)", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clean();
            }
        }
    }
}
