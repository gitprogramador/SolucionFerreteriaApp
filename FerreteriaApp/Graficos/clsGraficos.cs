using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FerreteriaApp.Graficos
{
    public class clsGraficos
    {
        private string Server = "localhost";
        private string User = "root";
        private string Pass = "12345";
        private string Bd = "bdatosfer";
        public DataTable GetProductosStockBajo()
        {
            DataTable dt = new DataTable();
            string connectionString = $"Server={Server};User={User};Password={Pass};Database={Bd};";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand("ProductosStockBajo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        adapter.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al obtener los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return dt;
        }
        public DataTable GetProductosPorCategoria()
        {
            DataTable dt = new DataTable();
            string connectionString = $"Server={Server};User={User};Password={Pass};Database={Bd};";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand("ProductosPorCategoria", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        adapter.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al obtener los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return dt;
        }

    }
}
