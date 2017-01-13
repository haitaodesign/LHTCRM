using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace LHT.CRM.Common.Encrypt
{
    public class MD5Encrypt
    {
        //对一段字符串进行MD5加密

        public static string GetMD5Hash(string password)
        {
            using(MD5 md5Hash = MD5.Create())
            {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sBuilder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }
                return sBuilder.ToString().Substring(2,22);
            }
        }

        //验证加密字符串方法

        public static bool VeriyMd5Hash(string password,string hash)
        {
            string hashOfPassword = GetMD5Hash(password);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (comparer.Compare(hashOfPassword, hash)==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
