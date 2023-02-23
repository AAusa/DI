using System;
using System.Windows.Forms;
using MySqlConnector;

namespace GUI_MODERNISTA
{
    public partial class LeerBD : Form
    {
        public LeerBD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString =
        "Server=192.168.56.104;Database=biblioteca;Uid=miusuario;Pwd=Pass!123456; ";
            string salida = "Resultado:\n";
            using (var connection = new
            MySqlConnection(connectionString))
            {
                connection.Open();
                // Consulta para obtener los nombres de los socios
                string query = "SELECT nombre FROM socio";
                using (var command = new MySqlCommand(query,
                connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            salida += "\t-"+reader["nombre"].ToString()+"\n";
                        }
                    }
                }
                resultado.Text = salida;
                connection.Close();
            }
        }
    }
}
