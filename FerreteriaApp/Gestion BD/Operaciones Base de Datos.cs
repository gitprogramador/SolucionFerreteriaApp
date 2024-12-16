using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaApp.Gestion_BD
{
    public class Operaciones_Base_de_Datos
    {
        // Configuración de conexión
        private string Server { get; set; } = "localhost";
        private string Database { get; set; } = "bdatosfer";
        private string User { get; set; } = "root";
        private string Password { get; set; } = "root";

        // Ruta al ejecutable de mysqldump y mysql (asegúrate de que estén en el PATH o especifica la ruta completa)
        private string MySqlDumpPath { get; set; } = "mysqldump";
        private string MySqlPath { get; set; } = "mysql";

        /// <summary>
        /// Realiza un respaldo de la base de datos especificada y lo guarda en la ruta indicada.
        /// </summary>
        /// <param name="backupFilePath">Ruta completa del archivo de respaldo.</param>
        public void BackupDatabase(string backupFilePath)
        {
            try
            {
                string arguments = $"-h {Server} -u {User} -p{Password} --routines --triggers --databases {Database}";

                using (Process process = new Process())
                {
                    process.StartInfo.FileName = MySqlDumpPath;
                    process.StartInfo.Arguments = arguments;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.CreateNoWindow = true;

                    using (StreamWriter writer = new StreamWriter(backupFilePath))
                    {
                        process.Start();
                        writer.Write(process.StandardOutput.ReadToEnd());
                        process.WaitForExit();
                    }
                }

                Console.WriteLine("Respaldo completado con éxito.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al realizar el respaldo: {ex.Message}");
            }
        }

        /// <summary>
        /// Restaura una base de datos desde un archivo de respaldo.
        /// </summary>
        /// <param name="backupFilePath">Ruta completa del archivo de respaldo.</param>
        public void RestoreDatabase(string backupFilePath)
        {
            try
            {
                string arguments = $"-h {Server} -u {User} -p{Password} {Database}";

                using (Process process = new Process())
                {
                    process.StartInfo.FileName = MySqlPath;
                    process.StartInfo.Arguments = arguments;
                    process.StartInfo.RedirectStandardInput = true;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.CreateNoWindow = true;

                    process.Start();

                    using (StreamReader reader = new StreamReader(backupFilePath))
                    {
                        process.StandardInput.Write(reader.ReadToEnd());
                        process.StandardInput.Close();
                    }

                    process.WaitForExit();
                }

                Console.WriteLine("Restauración completada con éxito.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al realizar la restauración: {ex.Message}");
            }
        }
    }
}
