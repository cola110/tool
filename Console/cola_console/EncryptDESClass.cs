using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace cola_console
{
    public class EncryptDESClass
    {
        /// <summary>
        /// DES加密
        /// </summary>
        /// <param name="strContent"></param>
        /// <param name="strKey"></param>
        /// <returns></returns>
        public static string EncryptDES(string strContent, string strKey = "Dw&7#~d2")
        {
            DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
            byte[] bytes = Encoding.GetEncoding("UTF-8").GetBytes(strContent);
            provider.Key = Encoding.GetEncoding("UTF-8").GetBytes(strKey);
            provider.IV = Encoding.GetEncoding("UTF-8").GetBytes(strKey);
            //provider.Mode = CipherMode.ECB;
            //provider.Padding = PaddingMode.PKCS7;
            MemoryStream stream = new MemoryStream();
            CryptoStream stream2 = new CryptoStream(stream, provider.CreateEncryptor(), CryptoStreamMode.Write);
            stream2.Write(bytes, 0, bytes.Length);
            stream2.FlushFinalBlock();

            var result = Convert.ToBase64String(stream.ToArray());

            //byte[] resultBytes = provider.CreateEncryptor().TransformFinalBlock(bytes, 0, bytes.Length);
            // var result = Convert.ToBase64String(resultBytes);

            return result;
        }

        /// <summary>
        /// DES解码 
        /// </summary>
        /// <param name="strContent"></param>
        /// <param name="strKey"></param>
        /// <returns></returns>
        public static string DecryptDES(string strContent, string strKey = "Dw&7#~d2")
        {
            byte[] bytes = Convert.FromBase64String(strContent);
            DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
            provider.Key = Encoding.GetEncoding("UTF-8").GetBytes(strKey);
            provider.IV = Encoding.GetEncoding("UTF-8").GetBytes(strKey);
            //MemoryStream stream = new MemoryStream();
            //CryptoStream stream2 = new CryptoStream(stream, provider.CreateDecryptor
            //    (), CryptoStreamMode.Write);
            //stream2.Write(bytes, 0, bytes.Length);
            //stream2.FlushFinalBlock();
            // var result = Encoding.UTF8.GetString(stream.ToArray());

            byte[] resultBytes = provider.CreateDecryptor().TransformFinalBlock(bytes, 0, bytes.Length);
            var result = Encoding.UTF8.GetString(resultBytes.ToArray());
            return result;
        }
    }
}
