using System.Security.Cryptography;
using System.Text;

namespace Core.Entities.Security
{
    public class Encrypt
    {
        public static string encrypt_using_sha256(string str)
        {
            var sha = new SHA256Managed();

            var input_bytes = Encoding.UTF8.GetBytes(str);
            var hashed_bytes = sha.ComputeHash(input_bytes);

            return to_string(hashed_bytes);
        }

        public static string to_string(byte[] bytes)
        {
            var output = new StringBuilder("");

            for (var i = 0; i < bytes.Length; i++)
            {
                output.Append(bytes[i].ToString("x2"));
            }

            return output.ToString();
        }
    }
}
