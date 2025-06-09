using System.Security.Cryptography;
using System.Text;
using System;

public static class Criptografia
{
    private static readonly string clave = "claveSecreta1234"; // 16 caracteres

    public static string Encriptar(string texto)
    {
        byte[] key = Encoding.UTF8.GetBytes(clave);
        using (Aes aes = Aes.Create())
        {
            aes.Key = key;
            aes.IV = key;

            ICryptoTransform encryptor = aes.CreateEncryptor();
            byte[] buffer = Encoding.UTF8.GetBytes(texto);

            return Convert.ToBase64String(encryptor.TransformFinalBlock(buffer, 0, buffer.Length));
        }
    }

    public static string Desencriptar(string textoEncriptado)
    {
        byte[] key = Encoding.UTF8.GetBytes(clave);
        using (Aes aes = Aes.Create())
        {
            aes.Key = key;
            aes.IV = key;

            ICryptoTransform decryptor = aes.CreateDecryptor();
            byte[] buffer = Convert.FromBase64String(textoEncriptado);

            return Encoding.UTF8.GetString(decryptor.TransformFinalBlock(buffer, 0, buffer.Length));
        }
    }
}
