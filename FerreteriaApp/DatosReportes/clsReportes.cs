using FerreteriaApp.bdatosfer;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaApp.DatosReportes
{
    public class clsReportes
    {
        // Configuración de conexión
        private string Server { get; set; } = "localhost";
        private string Database { get; set; } = "bdatosfer";
        private string User { get; set; } = "root";
        private string Password { get; set; } = "root";

        // Método para ejecutar el procedimiento almacenado y obtener los datos
        public DataTable ObtenerVentasDelDia()
        {
            DataTable dt = new DataTable();

            // Cadena de conexión
            string connectionString = $"Server={Server};Database={Database};Uid={User};Pwd={Password};";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Comando para ejecutar el procedimiento almacenado
                    using (MySqlCommand cmd = new MySqlCommand("VentasDelDia", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Adaptador para llenar el DataTable
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los datos: " + ex.Message);
                }
            }

            return dt;
        }


        public DataTable ObtenerInventario()
        {
            DataTable dt = new DataTable();

            // Cadena de conexión
            string connectionString = $"Server={Server};Database={Database};Uid={User};Pwd={Password};";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Comando para ejecutar el procedimiento almacenado
                    using (MySqlCommand cmd = new MySqlCommand("ReporteInventario", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Adaptador para llenar el DataTable
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los datos: " + ex.Message);
                }
            }

            return dt;
        }

        // Método para obtener compras entre dos fechas
        public DataTable ObtenerComprasEntreFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable dt = new DataTable();
            string connectionString = $"Server={Server};Database={Database};Uid={User};Pwd={Password};";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("ComprasEntreFechas", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_FechaInicio", fechaInicio);
                        cmd.Parameters.AddWithValue("@p_FechaFin", fechaFin);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los datos: " + ex.Message);
                }
            }

            return dt;
        }

        // Método para obtener compras entre dos fechas por usuario
        public DataTable ObtenerComprasEntreFechasPorUsuario(int idUsuario, DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable dt = new DataTable();
            string connectionString = $"Server={Server};Database={Database};Uid={User};Pwd={Password};";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("ComprasEntreFechasPorUsuario", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_IdUsuario", idUsuario);
                        cmd.Parameters.AddWithValue("@p_FechaInicio", fechaInicio);
                        cmd.Parameters.AddWithValue("@p_FechaFin", fechaFin);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los datos: " + ex.Message);
                }
            }

            return dt;
        }

        // Método para obtener ventas entre dos fechas
        public DataTable ObtenerVentasEntreFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable dt = new DataTable();
            string connectionString = $"Server={Server};Database={Database};Uid={User};Pwd={Password};";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("VentasEntreFechas", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_FechaInicio", fechaInicio);
                        cmd.Parameters.AddWithValue("@p_FechaFin", fechaFin);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los datos: " + ex.Message);
                }
            }

            return dt;
        }

        // Método para obtener ventas entre dos fechas por usuario
        public DataTable ObtenerVentasEntreFechasPorUsuario(int idUsuario, DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable dt = new DataTable();
            string connectionString = $"Server={Server};Database={Database};Uid={User};Pwd={Password};";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("VentasEntreFechasPorUsuario", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_IdUsuario", idUsuario);
                        cmd.Parameters.AddWithValue("@p_FechaInicio", fechaInicio);
                        cmd.Parameters.AddWithValue("@p_FechaFin", fechaFin);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los datos: " + ex.Message);
                }
            }

            return dt;
        }


        // Método para obtener los detalles de una venta específica
        public DataTable ObtenerDetallesVenta(int idVenta)
        {
            DataTable dt = new DataTable();
            string connectionString = $"Server={Server};Database={Database};Uid={User};Pwd={Password};";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("DetallesVenta", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_IdVenta", idVenta);

                        // Usamos el adaptador para llenar el DataTable con los resultados del procedimiento almacenado
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los detalles de la venta: " + ex.Message);
                }
            }

            return dt;
        }



    }
}
