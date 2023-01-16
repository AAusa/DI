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
using System;
using MySql.Data.MySqlClient;

namespace conexionBDInterfaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString =
        "Server=192.168.56.104;Database=biblioteca;Uid=miusuario;Pwd=Pass!123456; ";
            using (var connection = new
            MySqlConnection(connectionString))
            {
                connection.Open();
                // Consulta para obtener los nombres de los socios
                string query = textBox1.Text;//SELECT nombre FROM socio
                using (var command = new MySqlCommand(query,
                connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            label1.Text += "\n\t"+reader["nombre"].ToString();
                        }
                    }
                }
                connection.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
