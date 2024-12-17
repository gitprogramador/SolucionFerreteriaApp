using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerreteriaApp.Gestion_BD
{
    public class Operaciones_Base_de_Datos
    {
        // Configuración de conexión
        private string Server { get; set; } = "localhost";
        private string Database { get; set; } = "bdatosfer";
        private string User { get; set; } = "root";
        private string Password { get; set; } = "root";

        // Constructor
        public void OperacionesBaseDatos()
        {
            // Constructor vacío, puedes inicializar variables si lo necesitas
        }

        /// <summary>
        /// Realiza un respaldo de la base de datos MySQL.
        /// </summary>
        /// <param name="backupFilePath">Ruta del archivo donde se guardará el respaldo.</param>
        public void Respaldo(string backupFilePath)
        {
            try
            {
                string mysqldumpPath = @"C:\Program Files\MySQL\MySQL Server 8.0\bin\mysqldump.exe";

                if (!File.Exists(mysqldumpPath))
                {
                    MessageBox.Show("No se encontró mysqldump en la ruta especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Parámetros para el respaldo incluyendo procedimientos, triggers y eventos
                string arguments = $"--routines --triggers --events -h {Server} -u {User} -p{Password} {Database} -r \"{backupFilePath}\"";

                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = mysqldumpPath,
                    Arguments = arguments,
                    UseShellExecute = false,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                };

                Process process = Process.Start(startInfo);
                string errorOutput = process.StandardError.ReadToEnd();
                process.WaitForExit();

                if (process.ExitCode == 0)
                {
                    MessageBox.Show("Respaldo completado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Error durante el respaldo: {errorOutput}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error en el respaldo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Restaura la base de datos MySQL a partir de un archivo de respaldo.
        /// </summary>
        /// <param name="backupFilePath">Ruta del archivo de respaldo.</param>
        public void Restauracion(string backupFilePath)
        {
            try
            {
                string mysqlPath = @"C:\Program Files\MySQL\MySQL Server 8.0\bin\mysql.exe";

                if (!File.Exists(mysqlPath))
                {
                    MessageBox.Show("No se encontró mysql en la ruta especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!File.Exists(backupFilePath))
                {
                    MessageBox.Show("El archivo de respaldo especificado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/C \"{mysqlPath} -h {Server} -u {User} -p{Password} {Database} < \"{backupFilePath}\"\"",
                    UseShellExecute = false,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                };

                Process process = Process.Start(startInfo);
                string errorOutput = process.StandardError.ReadToEnd();
                process.WaitForExit();

                if (process.ExitCode == 0)
                {
                    MessageBox.Show("Restauración completada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Error durante la restauración: {errorOutput}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error en la restauración: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
