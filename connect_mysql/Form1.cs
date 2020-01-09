using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace connect_mysql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost; database=login; Uid=sebas; pwd=esfot");
            connection.Open();

            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conexion = new MySqlConnection();
            codigo.Connection = connection;

            codigo.CommandText = ("select * from usuers where username='" + txtnombre.Text + "'and password = '" + txtpwd.Text + "'");

            MySqlDataReader leer = codigo.ExecuteReader();
            if(leer.Read())
            {
                MessageBox.Show("Bienbenido");
                Inicio inicio = new Inicio();
                inicio.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usurio o contraseña incorrectos");
            }
            connection.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
