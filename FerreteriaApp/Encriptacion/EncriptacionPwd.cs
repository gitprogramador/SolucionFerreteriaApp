using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaApp.Encriptacion
{
    public class EncriptacionPwd
    {
        /// <summary>
        /// Encripta una contraseña utilizando el algoritmo Bcrypt.
        /// </summary>
        /// <param name="password">Contraseña en texto plano.</param>
        /// <returns>Contraseña encriptada.</returns>
        public static string EncryptPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("La contraseña no puede estar vacía.");
            }

            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        /// <summary>
        /// Compara una contraseña en texto plano con una contraseña encriptada.
        /// </summary>
        /// <param name="plainPassword">Contraseña en texto plano.</param>
        /// <param name="encryptedPassword">Contraseña encriptada.</param>
        /// <returns>True si coinciden, de lo contrario False.</returns>
        public static bool VerifyPassword(string plainPassword, string encryptedPassword)
        {
            if (string.IsNullOrEmpty(plainPassword) || string.IsNullOrEmpty(encryptedPassword))
            {
                throw new ArgumentException("Las contraseñas no pueden estar vacías.");
            }

            return BCrypt.Net.BCrypt.Verify(plainPassword, encryptedPassword);
        }
    }
}
