using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace النظام_النهائي.A_Data_entry_A.Login_A
{
    public class SecurityHelper
    {
        public static string HashPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password)) return string.Empty;

            using (SHA256 sha256 = SHA256.Create())
            {
                // التعديل الجوهري: استخدام Encoding.Unicode بدلاً من UTF8
                byte[] bytes = sha256.ComputeHash(Encoding.Unicode.GetBytes(password.Trim()));

                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
