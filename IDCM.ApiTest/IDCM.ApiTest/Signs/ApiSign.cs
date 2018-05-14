using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace IDCM.ApiTest.Signs
{
    public class ApiSign
    {
        public static string CreateSign(string secretKey, string content)
        {
            var hmacSha = new HMACSHA384(Encoding.UTF8.GetBytes(secretKey));
            var hash = hmacSha.ComputeHash(Encoding.UTF8.GetBytes(content)).ToArray();
            return Convert.ToBase64String(hash);
        }
    }
}
