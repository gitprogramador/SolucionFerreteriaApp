using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace FerreteriaApp.Gestion_BD
{
    public class Operaciones_Base_de_Datos
    {
        private string server = "localhost";         // Dirección del servidor MySQL
        private string user = "root";         // Nombre de usuario para la base de datos
        private string password = "12345"; // Contraseña del usuario
        private string database = "bdatosfer";      // Nombre de la base de datos

        // Ruta del ejecutable de MySQL y mysqldump
        private string mysqlPath = @"C:\Program Files\MySQL\MySQL Server 8.0\bin\mysql.exe";
        private string mysqldumpPath = @"C:\Program Files\MySQL\MySQL Server 8.0\bin\mysqldump.exe";

        // Constructor sin parámetros, los valores ya están definidos en las variables
        public Operaciones_Base_de_Datos() { }

        // Método para realizar la restauración desde un archivo SQL
        public bool RestaurarBaseDeDatos(string backupFilePath)
        {
            try
            {
                // Asegúrate de que el archivo exista
                if (!File.Exists(backupFilePath))
                {
                    throw new FileNotFoundException("El archivo de respaldo no existe.");
                }

                // Comando para restaurar la base de datos
                string restoreCommand = $"--host={server} --user={user} --password={password} --database={database} --execute=\"source {backupFilePath}\"";

                ProcessStartInfo restoreProcessInfo = new ProcessStartInfo()
                {
                    FileName = mysqlPath,
                    Arguments = restoreCommand,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardError = true, // Redirigir el error estándar
                    RedirectStandardOutput = true  // Redirigir la salida estándar
                };

                // Ejecutar el proceso
                using (Process restoreProcess = Process.Start(restoreProcessInfo))
                {
                    string output = restoreProcess.StandardOutput.ReadToEnd();
                    string error = restoreProcess.StandardError.ReadToEnd();

                    restoreProcess.WaitForExit();

                    // Verificar el código de salida
                    if (restoreProcess.ExitCode == 0)
                    {
                        // Mostrar la salida de la restauración para depuración (opcional)
                        Console.WriteLine("Salida de la restauración: ");
                        Console.WriteLine(output);
                        return true; // Restauración exitosa
                    }
                    else
                    {
                        // Mostrar el error de la restauración para depuración
                        Console.WriteLine("Error de la restauración: ");
                        Console.WriteLine(error);
                        throw new Exception($"Error en la restauración: {error}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al restaurar la base de datos: {ex.Message}");
                return false;
            }
        }

        // Método para realizar el respaldo de la base de datos
        public bool RespaldarBaseDeDatos(string backupFilePath)
        {
            try
            {
                string backupCommand = $"--host={server} --user={user} --password={password} --databases {database} --routines --events --result-file=\"{backupFilePath}\"";

                ProcessStartInfo backupProcessInfo = new ProcessStartInfo()
                {
                    FileName = mysqldumpPath,
                    Arguments = backupCommand,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardError = true,
                    RedirectStandardOutput = true
                };

                // Ejecutar el proceso de respaldo
                using (Process backupProcess = Process.Start(backupProcessInfo))
                {
                    string output = backupProcess.StandardOutput.ReadToEnd();
                    string error = backupProcess.StandardError.ReadToEnd();

                    backupProcess.WaitForExit();

                    // Verificar el código de salida
                    if (backupProcess.ExitCode == 0)
                    {
                        return true; // Respaldo exitoso
                    }
                    else
                    {
                        throw new Exception($"Error en el respaldo: {error}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al respaldar la base de datos: {ex.Message}");
                return false;
            }
        }
    
    }
}
